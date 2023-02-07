using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using NetCore.Domain.Entities;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Object :DBConnect
    {
        /// <summary>
        /// Get toàn bộ - GetAll
        /// </summary>
        /// <returns></returns>
        public DataTable get()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Objects", _conn);
            DataTable dtUnit = new DataTable();
            da.Fill(dtUnit);
            return dtUnit;
        }

        /// <summary>
        /// Thêm - Add
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool them(NetCore.Domain.Entities.Object model)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO Objects(DisplayName, QRCode, BarCode) VALUES ('{0}', '{1}', '{2}')", 
                    model.DisplayName, model.QRCode, model.BarCode);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa - Edit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool sua(NetCore.Domain.Entities.Object model)
        {
            try
            {
                // Ket noi
                _conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Objects SET DisplayName = '{0}', QRCode = '{1}', BarCode = '{2}' WHERE Id = {3}", 
                    model.DisplayName, model.QRCode, model.BarCode, model.Id);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Xóa - Delete
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool xoa(int Id)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Objects WHERE Id = {0}", Id);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
