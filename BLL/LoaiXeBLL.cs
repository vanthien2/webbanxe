using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BLL
{
    public class LoaiXeBLL
    {
        LoaiXeDAO lxDAO = new LoaiXeDAO();
        public DataTable laytoanbo()
        {
            return lxDAO.laytoanbo();
        }
        public void them(LX lx)
        {
            lxDAO.them(lx);
        }

        public void sua(LX lx)
        {
            lxDAO.sua(lx);
        }

        public void xoa(int ma)
        {
            lxDAO.xoa(ma);
        }
    }
}
