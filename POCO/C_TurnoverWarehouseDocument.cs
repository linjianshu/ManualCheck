namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_TurnoverWarehouseDocument")]
    public partial class C_TurnoverWarehouseDocument
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ShelvesCode { get; set; }

        [StringLength(50)]
        public string ShelvesName { get; set; }

        public long? OrderID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        public long? ProjectID { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public long? PlanID { get; set; }

        [StringLength(50)]
        public string PlanCode { get; set; }

        [StringLength(50)]
        public string PlanName { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? InStaffID { get; set; }

        [StringLength(50)]
        public string InStaffCode { get; set; }

        [StringLength(50)]
        public string InStaffName { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public long? OutStaffID { get; set; }

        [StringLength(50)]
        public string OutStaffCode { get; set; }

        [StringLength(50)]
        public string OutStaffName { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
