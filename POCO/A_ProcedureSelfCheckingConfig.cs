namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProcedureSelfCheckingConfig
    {
        public long ID { get; set; }

        public long? ProcedureID { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public decimal? UpperLimit { get; set; }

        public decimal? LowerLimit { get; set; }

        public decimal? StandardValue { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public bool? IsEnable { get; set; }

        public bool? IsRequired { get; set; }

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
