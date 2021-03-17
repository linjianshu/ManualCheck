namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProjectInfomation
    {
        public long ID { get; set; }

        public long? OrderID { get; set; }

        public long? ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProjectName { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public int? Type { get; set; }

        public int? Num { get; set; }

        public decimal? Price { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public DateTime? DeadLine { get; set; }

        public int? SubPriority { get; set; }

        public int? State { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(1)]
        public string Reserve1 { get; set; }

        [StringLength(1)]
        public string Reserve2 { get; set; }

        [StringLength(1)]
        public string Reserve3 { get; set; }
    }
}
