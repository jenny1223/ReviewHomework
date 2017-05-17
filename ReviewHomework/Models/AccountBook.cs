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
        [Display(Name ="����")]
        public int Categoryyy { get; set; }
        [Required]
        [Display(Name = "���B")]
        [Range(0,Int32.MaxValue)]
        public int Amounttt { get; set; }
        [Required]
        [Display(Name = "���")]
        [Remote("Index","OverToday",ErrorMessage ="���~")]
        public DateTime Dateee { get; set; }
        [Required]
        [Display(Name = "�Ƶ�")]
        [StringLength(100)]
        public string Remarkkk { get; set; }
    }
}
