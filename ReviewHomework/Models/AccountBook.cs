namespace ReviewHomework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="種類")]
        public int Categoryyy { get; set; }
        [Required]
        [Display(Name = "金額")]
        [Range(0,Int32.MaxValue)]
        public int Amounttt { get; set; }
        [Required]
        [Display(Name = "日期")]
        [Remote("Index","OverToday",ErrorMessage ="錯誤")]
        public DateTime Dateee { get; set; }
        [Required]
        [Display(Name = "備註")]
        [StringLength(100)]
        public string Remarkkk { get; set; }
    }
}
