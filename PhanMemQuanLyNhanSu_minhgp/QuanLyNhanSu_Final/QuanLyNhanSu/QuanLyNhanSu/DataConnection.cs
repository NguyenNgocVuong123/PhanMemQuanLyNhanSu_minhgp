using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows;

namespace QuanLyNhanSu
{
    class DataConnection
    {
        string ConStr;
        string path = Directory.GetCurrentDirectory();

        public DataConnection()
        {
            ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        }

        public SqlConnection GetConnect()
        {
            return new SqlConnection(ConStr);
        }
    }
}
