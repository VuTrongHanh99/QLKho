using DAL;
using NetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Customer
    {
        DAL_Customer dalThanhVien = new DAL_Customer();

        public DataTable getThanhVien()
        {
            return dalThanhVien.getThanhVien();
        }

        public bool themThanhVien(Customer tv)
        {
            return dalThanhVien.themThanhVien(tv);
        }

        public bool suaThanhVien(Customer tv)
        {
            return dalThanhVien.suaThanhVien(tv);
        }

        public bool xoaThanhVien(int TV_ID)
        {
            return dalThanhVien.xoaThanhVien(TV_ID);
        }
    }
}
