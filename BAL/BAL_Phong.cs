using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_Phong
    {
        private static BAL_Phong instance;

        public static BAL_Phong Instance {
            get { if (instance == null) instance = new BAL_Phong(); return instance; }
            private set { instance = value; } 
        }
        private BAL_Phong() { }
        public static int RoomHeight = 90;
        public static int RoomWidth = 80;
        public List<BEL_Phong> LoadRoomList()
        {
            List<BEL_Phong> roomlist = new List<BEL_Phong>();
            DataTable data = DAL_Phong.Instance.LoadRoomList();
            foreach(DataRow item in data.Rows)
            {
                BEL_Phong phong = new BEL_Phong(item);
                roomlist.Add(phong);
            }
            return roomlist;
        }
        public BEL_Phong LoadRoomSoPhong(string sophong)
        {
            BEL_Phong phong = null;
            DataTable data = DAL_Phong.Instance.LoadRoomSoPhong(sophong);
            foreach (DataRow item in data.Rows)
            {
                phong = new BEL_Phong(item);
            }
            return phong;
        }
        public List<BEL_Phong> LoadRoomTrangThai(string trangthai)
        {

            List<BEL_Phong> roomlist = new List<BEL_Phong>();
            DataTable data = DAL_Phong.Instance.LoadRoomTrangThai(trangthai);
            foreach (DataRow item in data.Rows)
            {
                BEL_Phong phong = new BEL_Phong(item);
                roomlist.Add(phong);
            }
            return roomlist;
        }
        public bool InsertRoom(BEL_Phong room)
        {
            int result = DAL_Phong.Instance.InsertRoom(room);
            return result > 0;
        }
        public bool UpdateRoom(BEL_Phong room)
        {
            int result = DAL_Phong.Instance.UpdateRoom(room);
            return result > 0;
        }
        public bool UpdateRoomTrangThai(string sophong,string trangthai)
        {
            int result = DAL_Phong.Instance.UpdateRoomTrangThai(sophong, trangthai);
            return result > 0;
        }
        public bool DeleteRoom(BEL_Phong room)
        {
            int result = DAL_Phong.Instance.DeleteRoom(room);
            return result > 0;
        }
    }
}
