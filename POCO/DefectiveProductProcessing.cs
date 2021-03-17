namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DefectiveProductProcessing")]
    public partial class DefectiveProductProcessing
    {
        public long ID { get; set; }

        public long? OrderID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        public long? ProductID { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public long? ProjectID { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        public long? PlanID { get; set; }

        [StringLength(50)]
        public string PlanCode { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        [StringLength(50)]
        public string ProcedureName { get; set; }

        [StringLength(50)]
        public string ProcedureID { get; set; }

        public int? State { get; set; }

        [StringLength(50)]
        public string EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }

        public long? OnlineStaffID { get; set; }

        [StringLength(50)]
        public string OnlineStaffCode { get; set; }

        [StringLength(50)]
        public string OnlineStaffName { get; set; }

        public long? OfflineStaffID { get; set; }

        [StringLength(50)]
        public string OfflineStaffCode { get; set; }

        [StringLength(50)]
        public string OfflineStaffName { get; set; }

        [StringLength(500)]
        public string CauseDescription { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
