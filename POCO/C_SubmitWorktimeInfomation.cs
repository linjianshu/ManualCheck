namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_SubmitWorktimeInfomation")]
    public partial class C_SubmitWorktimeInfomation
    {
        public long ID { get; set; }

        public long? StaffID { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        [StringLength(50)]
        public string StaffName { get; set; }

        public long? EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }

        public long? OrderID { get; set; }

        [StringLength(50)]
        public string OrderCode { get; set; }

        [StringLength(50)]
        public string OrderName { get; set; }

        [StringLength(50)]
        public string ProjectCode { get; set; }

        [StringLength(50)]
        public string ProjectName { get; set; }

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

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        [StringLength(50)]
        public string ProcedureName { get; set; }

        public int? ApprovalStatus { get; set; }

        public decimal? SubmitWorktime { get; set; }

        public decimal? ActualWorktime { get; set; }

        [StringLength(10)]
        public string TimeUnit { get; set; }

        [StringLength(50)]
        public string ReviewerCode { get; set; }

        [StringLength(50)]
        public string ReviewerName { get; set; }

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
