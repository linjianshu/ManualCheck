namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_ReformDocument")]
    public partial class C_ReformDocument
    {
        public long ID { get; set; }

        public long? OriginalOrderID { get; set; }

        [StringLength(50)]
        public string OriginalOrderCode { get; set; }

        [StringLength(50)]
        public string OriginalOrderName { get; set; }

        public long? OriginalProjectID { get; set; }

        [StringLength(50)]
        public string OriginalProjectCode { get; set; }

        [StringLength(50)]
        public string OriginalProjectName { get; set; }

        public long? OriginalPlanID { get; set; }

        [StringLength(50)]
        public string OriginalPlanCode { get; set; }

        [StringLength(50)]
        public string OriginalPlanName { get; set; }

        [StringLength(50)]
        public string OriginalWorkmanshipCode { get; set; }

        public long? OriginalWorkmanshipID { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        public long? OriginalProductID { get; set; }

        [StringLength(50)]
        public string OriginalProductCode { get; set; }

        [StringLength(50)]
        public string OriginalProductName { get; set; }

        public long? NewOrderID { get; set; }

        [StringLength(50)]
        public string NewOrderCode { get; set; }

        [StringLength(50)]
        public string NewOrderName { get; set; }

        [StringLength(50)]
        public string NewProjectCode { get; set; }

        public long? NewProjectID { get; set; }

        [StringLength(50)]
        public string NewPlanCode { get; set; }

        public long? NewPlanID { get; set; }

        [StringLength(50)]
        public string NewWorkmanshipCode { get; set; }

        public long? NewWorkmanshipID { get; set; }

        [StringLength(1)]
        public string NewProductBornCode { get; set; }

        public long? NewProductID { get; set; }

        [StringLength(50)]
        public string NewProductCode { get; set; }

        [StringLength(50)]
        public string NewProductName { get; set; }

        public long? ReformStaffID { get; set; }

        [StringLength(50)]
        public string ReformStaffCode { get; set; }

        [StringLength(50)]
        public string ReformStaffName { get; set; }

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
