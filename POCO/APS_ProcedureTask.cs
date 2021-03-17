namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APS_ProcedureTask
    {
        public long ID { get; set; }

        public int? Marks { get; set; }

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

        [StringLength(50)]
        public string PlanCode { get; set; }

        public long? EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string WorkerCode { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? IndentLevel { get; set; }

        public int? SortOrder { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public decimal? ProgressPercent { get; set; }

        public int? PredecessorIndices { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Priority { get; set; }

        public int? ProductNumber { get; set; }

        public int? Batch { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        public int? TaskState { get; set; }

        public int? IsChecked { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        [StringLength(50)]
        public string ModifierID { get; set; }

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
