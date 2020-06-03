using DaMyNghe.Models.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaMyNghe.Models
{
    public class DBContext
    {
        public static List<DanhMuc_MauDa> getAllDanhMuc_MauDa()
        {
            using(var db=new Model1())
            {
                List<DanhMuc> danhmuc = db.DanhMucs.ToList();
                List<DanhMuc_MauDa> list = new List<DanhMuc_MauDa>();
                foreach(DanhMuc item in danhmuc)
                {
                    list.Add(new DanhMuc_MauDa { danhMuc = item, mauDa = db.MauDas.Where(x => x.DanhMucID == item.Id).ToList() });
                }
                return list;
            }
        }
    }
}