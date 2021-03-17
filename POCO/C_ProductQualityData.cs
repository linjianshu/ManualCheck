namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ProductQualityData")]
    public partial class C_ProductQualityData
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

        public int? CheckType { get; set; }

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

        [StringLength(50)]
        public string CheckStaffCode { get; set; }

        [StringLength(50)]
        public string CheckStaffName { get; set; }

        public long? ItemID { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public decimal? UpperLimit { get; set; }

        public decimal? LowerLimit { get; set; }

        public decimal? StandardValue { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public decimal? CollectValue { get; set; }

        [StringLength(500)]
        public string CheckReportPath { get; set; }

        public int? CheckResult { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
