namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_OrderBase
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        [StringLength(50)]
        public string OrderName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public long CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerCode { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public int? State { get; set; }

        public int? OrderType { get; set; }

        public int? Priority { get; set; }

        [StringLength(50)]
        public string TechnicalDirector { get; set; }

        [StringLength(50)]
        public string ManufacturingDirector { get; set; }

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
