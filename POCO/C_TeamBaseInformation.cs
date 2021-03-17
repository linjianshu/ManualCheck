namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_TeamBaseInformation")]
    public partial class C_TeamBaseInformation
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string TeamCode { get; set; }

        [StringLength(50)]
        public string TeamName { get; set; }

        [StringLength(50)]
        public string TeamType { get; set; }

        [StringLength(50)]
        public string Describe { get; set; }

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
