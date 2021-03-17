namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EquipmentAlarmDocument")]
    public partial class C_EquipmentAlarmDocument
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string EquipmentCategory { get; set; }

        [StringLength(50)]
        public string EquipmentType { get; set; }

        [StringLength(50)]
        public string EquipmentModel { get; set; }

        public long? EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }

        public long? AlarmID { get; set; }

        [StringLength(50)]
        public string AlarmCode { get; set; }

        [StringLength(50)]
        public string AlarmName { get; set; }

        [StringLength(50)]
        public string AlarmCategory { get; set; }

        [StringLength(50)]
        public string AlarmType { get; set; }

        [StringLength(50)]
        public string AlarmCause { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(500)]
        public string RelieveCause { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        public long? ProcedureID { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        public long? StaffID { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        public long? SolverID { get; set; }

        [StringLength(50)]
        public string SolverCode { get; set; }

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
