using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaMyNghe.Models.CustomModels
{
    public class DanhMuc_MauDa
    {
        public DanhMuc danhMuc { get; set; }
        public List<MauDa> mauDa { get; set; }
    }
}