using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICA
    {
        QLYNHANSUEntities db = new QLYNHANSUEntities();
        public tb_LOAICA getItem(int idloaica)
        {
            return db.tb_LOAICA.FirstOrDefault(x => x.IDLOAICA == idloaica);
            
        }
       
    }
}
