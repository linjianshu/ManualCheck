namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_FileFloderInformation")]
    public partial class C_FileFloderInformation
    {
        [Key]
        public long FileFloderID { get; set; }

        [StringLength(50)]
        public string FileFloderCode { get; set; }

        [StringLength(50)]
        public string FileFloderName { get; set; }

        public long? ParentID { get; set; }

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

        [StringLength(200)]
        public string DataSourcePath { get; set; }
    }
}
