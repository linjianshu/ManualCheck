namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ProductDocument")]
    public partial class C_ProductDocument
    {
        public long ID { get; set; }

        public long? PlanID { get; set; }

        [StringLength(50)]
        public string PlanCode { get; set; }

        public long? ProjectID { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public long? ProductID { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Type { get; set; }

        public DateTime? DeadLine { get; set; }

        public DateTime? OnlineTime { get; set; }

        public DateTime? OfflineTime { get; set; }

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
