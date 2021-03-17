namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FlowMain
    {
        [Key]
        [StringLength(50)]
        public string FlowMainId { get; set; }

        [StringLength(50)]
        public string FlowCode { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string RunWay { get; set; }

        public string FlowJson { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(200)]
        public string LinkUrl { get; set; }

        [StringLength(50)]
        public string FrmType { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public string RunSQL { get; set; }

        public int? IsBill { get; set; }

        public int? IsJoinTable { get; set; }

        public int? IsCC { get; set; }

        public string CCRole { get; set; }

        public decimal? ValidDays { get; set; }

        public int? VersionNo { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
