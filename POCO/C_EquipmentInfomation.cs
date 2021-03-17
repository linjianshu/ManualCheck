namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EquipmentInfomation")]
    public partial class C_EquipmentInfomation
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        public long? EquipmentGroupID { get; set; }

        [StringLength(50)]
        public string EquipmentGroupCode { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }

        [StringLength(50)]
        public string EquipmentCategory { get; set; }

        [StringLength(50)]
        public string EquipmentType { get; set; }

        [StringLength(50)]
        public string EquipmentModel { get; set; }

        [Column(TypeName = "image")]
        public byte[] EquipmentImage { get; set; }

        [StringLength(50)]
        public string EquipmentMaker { get; set; }

        [StringLength(50)]
        public string EquipmentLife { get; set; }

        public DateTime? EquipmentMakeTime { get; set; }

        public decimal? MaxIdleTime { get; set; }

        public bool? IsMonitor { get; set; }

        [StringLength(10)]
        public string TimeUnit { get; set; }

        [StringLength(500)]
        public string EquipmentDescription { get; set; }

        public int? MaintenanceCycle { get; set; }

        public int? LeadTime { get; set; }

        public bool? IsEnable { get; set; }

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
