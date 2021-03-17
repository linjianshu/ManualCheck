namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PettyCash")]
    public partial class PettyCash
    {
        [StringLength(50)]
        public string PettyCashId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(50)]
        public string Keeper { get; set; }

        [StringLength(50)]
        public string KeepType { get; set; }

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
    }
}
