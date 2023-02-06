using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-5DHJT2A\VUHANHDEV;Initial Catalog=QLKho_DEV;Integrated Security=True;TrustServerCertificate=True;");
        //protected SqlConnection _conn = new SqlConnection("Server=.; Database=QLKho_DEV; Integrated Security=True;");
    }
    //public class DBConnect
    //{
    //    public SqlConnection _cnn= null;
    //    string strConnection = @"Server=.; Database=QLKho_DEV; Integrated Security=True;";
    //    public void Moketnoi()
    //    {
    //        if(_cnn == null)
    //        {
    //            _cnn = new SqlConnection(strConnection);
    //        }
    //        if (_cnn.State == ConnectionState.Closed)
    //        {
    //            _cnn.Open();
    //        }
    //    }
    //    public void Dongketnoi()
    //    {
    //        if (_cnn != null && _cnn.State == ConnectionState.Open)
    //        {
    //            _cnn.Close();
    //        }
    //    }
    //}
}
