namespace DaMyNghe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauDa")]
    public partial class MauDa
    {
        public int Id { get; set; }

        public int? DanhMucID { get; set; }

        [Required]
        [StringLength(100)]
        public string Ten { get; set; }

        public double? Gia { get; set; }

        public string Anh { get; set; }
        public string getLink
        {
            get
            {
                return "/Images/" + Anh;
            }
        }
        public string getID
        {
            get
            {
                return "T" + Id;
            }
        }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}
