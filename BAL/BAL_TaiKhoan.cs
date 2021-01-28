using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Security.Cryptography;


namespace BAL
{
    public class BAL_TaiKhoan
    {
        private static BAL_TaiKhoan instance;

        public static BAL_TaiKhoan Instance 
        { 
            get { if (instance == null) instance = new BAL_TaiKhoan(); return BAL_TaiKhoan.instance; }
            private set { BAL_TaiKhoan.instance = value;}
        }
        private BAL_TaiKhoan() { }

        public bool Login(string Username, string Password)
        {
            Password = MaHoa(Password);
            return DAL_TaiKhoan.Instance.Login(Username, Password);
        }
        public bool AddAccount(BEL_TaiKhoan tk)
        {
            int result = DAL_TaiKhoan.Instance.AddAccount(tk, MaHoa("123"));
            return result > 0;
        }
        public bool UpAccount(BEL_TaiKhoan tk)
        {
            int result = DAL_TaiKhoan.Instance.UpAccount(tk);
            return result > 0;
        }
        public bool DelAccount(int manv)
        {
            int result = DAL_TaiKhoan.Instance.DelAccount(manv);
            return result > 0;
        }
        public List<BEL_TaiKhoan> LoadListTK()
        {
            List<BEL_TaiKhoan> list = new List<BEL_TaiKhoan>();
            DataTable data = DAL_TaiKhoan.Instance.LoadListTK();
            foreach (DataRow row in data.Rows)
            {
                BEL_TaiKhoan item = new BEL_TaiKhoan(row);
                list.Add(item);
            }
            return list;
        }
        public BEL_TaiKhoan LoadTK(string Username, string Password)
        {
            Password = MaHoa(Password);
            BEL_TaiKhoan tk  = null;
            DataTable data = DAL_TaiKhoan.Instance.LoadTK(Username, Password);
            foreach (DataRow row in data.Rows)
            {
                tk = new BEL_TaiKhoan(row);
            }
            return tk;
        }
        public string MaHoa(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public bool ResetPassword(int MaNV)
        {
            string Password = MaHoa("123");
            int result = DAL_TaiKhoan.Instance.ResetPassword(MaNV, Password);
            return result > 0;
        }
        public bool DoiMatKhau(string password, string tentk)
        {
            password = MaHoa(password);
            int result = DAL_TaiKhoan.Instance.DoiMatKhau(password, tentk);
            return result > 0;
        }
    }
}
