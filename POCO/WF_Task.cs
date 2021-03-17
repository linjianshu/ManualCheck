namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_Task
    {
        [Key]
        [StringLength(50)]
        public string FlowTaskId { get; set; }

        [StringLength(50)]
        public string InstanceId { get; set; }

        [StringLength(50)]
        public string FlowMainId { get; set; }

        [StringLength(50)]
        public string FrmMainId { get; set; }

        [StringLength(50)]
        public string TaskId { get; set; }

        [StringLength(50)]
        public string StepId { get; set; }

        public string ExcuteObjectId { get; set; }

        public string ExcuteObjectName { get; set; }

        public DateTime? TastStartTime { get; set; }

        public DateTime? TaskEndTime { get; set; }

        [StringLength(50)]
        public string BeforeStepId { get; set; }

        [StringLength(50)]
        public string LastStepId { get; set; }

        public string LastStepUserId { get; set; }

        [StringLength(50)]
        public string ExcuteUserId { get; set; }

        public DateTime? ExcuteTime { get; set; }

        public int? ExcuteResult { get; set; }

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
