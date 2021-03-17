namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_InfomationPushDocument")]
    public partial class C_InfomationPushDocument
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string PushID { get; set; }

        [StringLength(50)]
        public string PushCategory { get; set; }

        [StringLength(50)]
        public string InitPushRankPushRank { get; set; }

        [StringLength(50)]
        public string PushContent { get; set; }

        [StringLength(50)]
        public string CreateType { get; set; }

        public int? PushState { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastPushTime { get; set; }

        [StringLength(50)]
        public string CurrentPushRank { get; set; }

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
