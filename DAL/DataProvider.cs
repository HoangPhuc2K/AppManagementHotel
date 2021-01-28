using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        public  static string TenServer = ".";
        public static string TenDatabase = "QUANLYKHACHSAN";
        private string connectionSTR = @"Data Source="+TenServer+";Initial Catalog="+TenDatabase+";Integrated Security=True";

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set { DataProvider.instance = value; } 
        }

        private DataProvider() { }
        public DataTable ExecuteQuery(string query,object[] parameter = null) 
        {
            DataTable Data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                if (ConnectionState.Closed == connection.State)
                    connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null) 
                    {
                        string[] ListPara = query.Split(' ');
                        int i = 0;
                        foreach(string Item in ListPara)
                        {
                            if (Item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(Item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    Adapter.Fill(Data);
                }
                catch (Exception err)
                {
                    
                }
                finally
                {
                    connection.Close();
                }
            }
            return Data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int Data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                if (ConnectionState.Closed == connection.State)
                    connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] ListPara = query.Split(' ');
                        int i = 0;
                        foreach (string Item in ListPara)
                        {
                            if (Item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(Item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    Data = cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception("Lỗi Query", err);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object Data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                if (ConnectionState.Closed == connection.State)
                    connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] ListPara = query.Split(' ');
                        int i = 0;
                        foreach (string Item in ListPara)
                        {
                            if (Item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(Item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    Data = cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    throw new Exception("Lỗi Query", err);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Data;
        }
    }
}
