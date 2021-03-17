namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FlowNodeRole
    {
        [Key]
        [StringLength(50)]
        public string FlowNodeRoleId { get; set; }

        [StringLength(50)]
        public string FlowNodeId { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        public int? ObjectType { get; set; }

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
    }
}
