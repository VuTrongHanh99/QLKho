using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Object
    {
        DAL_Object _dal = new DAL_Object();

        public DataTable getObject()
        {
            return _dal.get();
        }

        public bool themObject(NetCore.Domain.Entities.Object model)
        {
            return _dal.them(model);
        }

        public bool suaObject(NetCore.Domain.Entities.Object model)
        {
            return _dal.sua(model);
        }

        public bool xoaObject(int Id)
        {
            return _dal.xoa(Id);
        }
    }
}
