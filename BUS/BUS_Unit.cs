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
    public class BUS_Unit
    {
        DAL_Unit _dal = new DAL_Unit();

        public DataTable getUnit()
        {
            return _dal.getUnit();
        }

        public bool themUnit(Unit model)
        {
            return _dal.themUnit(model);
        }

        public bool suaUnit(Unit model)
        {
            return _dal.suaUnit(model);
        }

        public bool xoaUnit(int Id)
        {
            return _dal.xoaUnit(Id);
        }
    }
}
