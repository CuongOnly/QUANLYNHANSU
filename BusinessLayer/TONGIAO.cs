﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TONGIAO
    {
        QLYNHANSUEntities db = new QLYNHANSUEntities();
        public tb_TONGIAO getItem(int id)
        {
            return db.tb_TONGIAO.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_TONGIAO> getList()
        {
            return db.tb_TONGIAO.ToList();
        }
        public tb_TONGIAO Add(tb_TONGIAO tg)
        {
            try
            {
                db.tb_TONGIAO.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
        public tb_TONGIAO Update(tb_TONGIAO tg)
        {
            try
            {
                var _tg = db.tb_TONGIAO.FirstOrDefault(x => x.ID == tg.ID);
                _tg.TENTG = tg.TENTG;
                db.SaveChanges();
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
                var _tg = db.tb_TONGIAO.FirstOrDefault(x => x.ID == id);
                db.tb_TONGIAO.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi:" + ex.Message);
            }
        }
    }
}
