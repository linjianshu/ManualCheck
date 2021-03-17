namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_FrmNodeRelation
    {
        [Key]
        [StringLength(50)]
        public string FrmNodeRelationId { get; set; }

        [StringLength(50)]
        public string FlowNodeId { get; set; }

        [StringLength(50)]
        public string FrmTable { get; set; }

        [StringLength(50)]
        public string FrmField { get; set; }

        public int? DisplayMark { get; set; }

        public int? OperType { get; set; }

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
