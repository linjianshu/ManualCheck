namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VW_LOT_BIRTHCODE
    {
        [Key]
        [StringLength(50)]
        public string 产品出生证 { get; set; }

        [StringLength(50)]
        public string 产品名称 { get; set; }

        [StringLength(50)]
        public string 产品编号 { get; set; }

        [StringLength(50)]
        public string 订单编号 { get; set; }

        [StringLength(50)]
        public string 订单名称 { get; set; }

        public DateTime? 计划开始时间 { get; set; }

        public DateTime? 计划结束时间 { get; set; }

        public DateTime? 开始执行时间 { get; set; }

        public DateTime? 执行完成时间 { get; set; }

        [StringLength(50)]
        public string 执行状态 { get; set; }

        [StringLength(50)]
        public string 产品状态 { get; set; }

        [StringLength(50)]
        public string 生产线 { get; set; }
    }
}
