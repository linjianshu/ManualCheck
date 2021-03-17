namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EquipmentStateDocument")]
    public partial class C_EquipmentStateDocument
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

        public int? EquipmentState { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public decimal? ContinueTime { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

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
