namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProjectPlanInfomation
    {
        public long ID { get; set; }

        public long? ProductID { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        [StringLength(50)]
        public string PlanCode { get; set; }

        public int? Status { get; set; }

        public int? Type { get; set; }

        public int? Batch { get; set; }

        public int? PlanNo { get; set; }

        public int? HasFirstPiece { get; set; }

        public DateTime? DeadLine { get; set; }

        public int? SubPriority { get; set; }

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
