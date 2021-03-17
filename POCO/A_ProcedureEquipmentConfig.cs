namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class A_ProcedureEquipmentConfig
    {
        public long ID { get; set; }

        public long? ProcedureID { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        public int? ProcedureIndex { get; set; }

        [StringLength(50)]
        public string EquipmentCategory { get; set; }

        [StringLength(50)]
        public string EquipmentType { get; set; }

        [StringLength(50)]
        public string EquipmentGroupName { get; set; }

        [StringLength(50)]
        public string EquipmentGroupCode { get; set; }

        [StringLength(50)]
        public string SpecialEquipmentCode { get; set; }

        public int? SpecialEquipmentTag { get; set; }

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
