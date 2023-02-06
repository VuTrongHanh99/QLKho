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
    public class DAL_Customer : DBConnect
    {
        /// <summary>
        /// Get toàn bộ thành viên
        /// </summary>
        /// <returns></returns>
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        /// <summary>
        /// Thêm thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themThanhVien(Customer tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO Customers(DisplayName, PhoneNumber, Email) VALUES ('{0}', '{1}', '{2}')", tv.DisplayName, tv.PhoneNumber, tv.Email);

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
        /// Sửa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool suaThanhVien(Customer tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE Customers SET DisplayName = '{0}', PhoneNumber = '{1}', Email = '{2}' WHERE Id = {3}", tv.DisplayName, tv.PhoneNumber, tv.Email, tv.Id);

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
        /// Xóa thành viên
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool xoaThanhVien(int TV_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Customers WHERE Id = {0})", TV_ID);

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
