namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_FileInformation")]
    public partial class C_FileInformation
    {
        [Key]
        public long FileID { get; set; }

        [StringLength(50)]
        public string FileCode { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        [StringLength(200)]
        public string FileEdition { get; set; }

        [StringLength(200)]
        public string FileSize { get; set; }

        [StringLength(500)]
        public string FileStoragePath { get; set; }

        [StringLength(100)]
        public string UploadPcMac { get; set; }

        [StringLength(100)]
        public string UploadPcIP { get; set; }

        [StringLength(50)]
        public string UploadPcName { get; set; }

        [StringLength(1000)]
        public string FileData { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        public long? FileFloderID { get; set; }

        [StringLength(50)]
        public string FileFloderCode { get; set; }

        [StringLength(500)]
        public string FileFloderName { get; set; }

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
