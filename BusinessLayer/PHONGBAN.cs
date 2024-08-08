using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class PHONGBAN
    {
        QLYNHANSUEntities pb = new QLYNHANSUEntities();
        public tb_PHONGBAN getItem(int id)
        {
            return pb.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }
        public List<tb_PHONGBAN> getList()
        {
            return pb.tb_PHONGBAN.ToList();
        }
        public tb_PHONGBAN Add(tb_PHONGBAN tg)
        {
            try
            {
                pb.tb_PHONGBAN.Add(tg);
                pb.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
        public tb_PHONGBAN Update(tb_PHONGBAN tg)
        {
            try
            {
                var _tg = pb.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == tg.IDPB);
                _tg.TENPB = tg.TENPB;
                pb.SaveChanges();
                return tg;
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
                var _tg = pb.tb_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                pb.tb_PHONGBAN.Remove(_tg);
                pb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
    }
}
