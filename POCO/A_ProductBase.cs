namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProductBase
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? ProductType { get; set; }

        [StringLength(50)]
        public string ProductSpeCode { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public decimal? StandardCost { get; set; }

        public int? PackingNum { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
