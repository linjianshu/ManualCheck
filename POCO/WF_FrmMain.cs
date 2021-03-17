namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FrmMain
    {
        [Key]
        [StringLength(50)]
        public string FrmMainId { get; set; }

        [StringLength(50)]
        public string FrmCode { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string FrmVersion { get; set; }

        [StringLength(50)]
        public string FrmTable { get; set; }

        [StringLength(50)]
        public string PrimaryKey { get; set; }

        [StringLength(200)]
        public string Heading { get; set; }

        [Column(TypeName = "text")]
        public string FrmHtml { get; set; }

        [Column(TypeName = "text")]
        public string FrmEventJson { get; set; }

        [StringLength(50)]
        public string FrmDept { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        public int? FrmType { get; set; }

        [StringLength(50)]
        public string FrmURL { get; set; }
    }
}
