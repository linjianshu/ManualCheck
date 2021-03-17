namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_Instance
    {
        [Key]
        [StringLength(50)]
        public string InstanceId { get; set; }

        [StringLength(50)]
        public string FlowMainId { get; set; }

        [StringLength(50)]
        public string FrmMainId { get; set; }

        [StringLength(50)]
        public string TaskId { get; set; }

        [StringLength(50)]
        public string FirstStepId { get; set; }

        [StringLength(50)]
        public string StartUserId { get; set; }

        [StringLength(50)]
        public string CurrentStepId { get; set; }

        public int? FlowStatus { get; set; }

        public DateTime? CompleteTime { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? Enabled { get; set; }

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

        [StringLength(50)]
        public string FlowTitle { get; set; }
    }
}
