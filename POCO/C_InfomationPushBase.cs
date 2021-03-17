namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_InfomationPushBase")]
    public partial class C_InfomationPushBase
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string PushCode { get; set; }

        [StringLength(50)]
        public string PushCategory { get; set; }

        [StringLength(50)]
        public string PushRank { get; set; }

        public decimal? IntervalTime { get; set; }

        [StringLength(50)]
        public string TimeUnit { get; set; }

        public bool? IsEnable { get; set; }

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
