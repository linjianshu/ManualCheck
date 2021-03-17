namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_StaffBaseInformation")]
    public partial class C_StaffBaseInformation
    {
        [Key]
        public long StaffID { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        [StringLength(50)]
        public string StaffName { get; set; }

        [StringLength(50)]
        public string StaffSex { get; set; }

        public DateTime? Birth { get; set; }

        [StringLength(50)]
        public string IDCard { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Wechat { get; set; }

        [StringLength(50)]
        public string DingID { get; set; }

        [Column(TypeName = "image")]
        public byte[] StaffImage { get; set; }

        [StringLength(50)]
        public string ImageType { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string SkillType { get; set; }

        [StringLength(50)]
        public string SkillGrade { get; set; }

        [StringLength(50)]
        public string MarryStatue { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public int? Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
