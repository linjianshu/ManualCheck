namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProcedureBase
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string GroupCode { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        [StringLength(50)]
        public string ProcedureName { get; set; }

        public int? ProcedureIndex { get; set; }

        [StringLength(50)]
        public string StandardTaskSpan { get; set; }

        public bool? IsProgramDemand { get; set; }

        public bool? IsMaterialDemand { get; set; }

        public int? TimeUnit { get; set; }

        public bool? IsNeedCheck { get; set; }

        public int? CheckFrequency { get; set; }

        public decimal? CheckTime { get; set; }

        public int? MaxNgNumber { get; set; }

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
