using Microsoft.Data.SqlClient;
using NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Unit : DBConnect
    {
        /// <summary>
        /// Get toàn bộ - GetAll
        /// </summary>
        /// <returns></returns>
        public DataTable getUnit()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Units", _conn);
            DataTable dtUnit = new DataTable();
            da.Fill(dtUnit);
            return dtUnit;
        }

        /// <summary>
        /// Thêm - Add
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool themUnit(Unit model)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO Units(DisplayName) VALUES ('{0}')", model.DisplayName);

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
        public bool suaUnit(Unit model)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE Units SET DisplayName = '{0}' WHERE Id = {1}",model.DisplayName,model.Id);

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
        public bool xoaUnit(int Id)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Units WHERE Id = {0}", Id);

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
