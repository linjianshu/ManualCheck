namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CheckTask")]
    public partial class C_CheckTask
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

        public int? TaskState { get; set; }

        public int? CheckReason { get; set; }

        public int? CheckType { get; set; }

        [StringLength(50)]
        public string EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }  
        
        [StringLength(50)]
        public string WorkerCode { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

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
