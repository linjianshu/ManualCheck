namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APS_ProcedureTaskDetail
    {
        public long ID { get; set; }

        public long? TaskTableID { get; set; }

        public long? EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        public int? ProcedureIndex { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        public int? TaskState { get; set; }

        public int? IsChecked { get; set; }

        public int? IsInspect { get; set; }

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
