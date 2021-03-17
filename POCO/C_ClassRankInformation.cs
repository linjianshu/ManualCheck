namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ClassRankInformation")]
    public partial class C_ClassRankInformation
    {
        [Key]
        public long ClassRankID { get; set; }

        [StringLength(50)]
        public string DetailCode { get; set; }

        public long? ShiftID { get; set; }

        public DateTime? RestStartTime { get; set; }

        public DateTime? RestEndTime { get; set; }

        public DateTime? WorkStartTime { get; set; }

        public DateTime? WorkEndTime { get; set; }

        public int? TimeType { get; set; }

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
