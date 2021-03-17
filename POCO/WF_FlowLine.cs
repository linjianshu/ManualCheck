namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FlowLine
    {
        [Key]
        [StringLength(50)]
        public string FlowLineId { get; set; }

        [StringLength(50)]
        public string FlowMainId { get; set; }

        [StringLength(50)]
        public string FlowLineCode { get; set; }

        [StringLength(50)]
        public string SourceNodeId { get; set; }

        [StringLength(50)]
        public string GoNodeId { get; set; }

        public int? ConditionType { get; set; }

        public string ConditionString { get; set; }

        public string ConditionJson { get; set; }

        public string ConditionValueJson { get; set; }

        public string CreateInclude { get; set; }

        public string CreateWithout { get; set; }

        public string ExcuteInclude { get; set; }

        public string ExcuteWithout { get; set; }

        [StringLength(200)]
        public string UserMethod { get; set; }

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
