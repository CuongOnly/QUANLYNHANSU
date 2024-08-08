using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QLYNHANSUEntities td = new QLYNHANSUEntities();
        public tb_TRINHDO getItem(int id)
        {
            return td.tb_TRINHDO.FirstOrDefault(x => x.IDTD == id);
        }
        public List<tb_TRINHDO> getList()
        {
            return td.tb_TRINHDO.ToList();
        }
        public tb_TRINHDO Add(tb_TRINHDO dt)
        {
            try
            {
                td.tb_TRINHDO.Add(dt);
                td.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
        public tb_TRINHDO Update(tb_TRINHDO dt)
        {
            try
            {
                var _dt = td.tb_TRINHDO.FirstOrDefault(x => x.IDTD == dt.IDTD);
                _dt.TENTD = dt.TENTD;
                td.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dt = td.tb_TRINHDO.FirstOrDefault(x => x.IDTD == id);
                td.tb_TRINHDO.Remove(_dt);
                td.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
    }
}
