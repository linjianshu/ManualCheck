namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EquipmentAlarmInfomation")]
    public partial class C_EquipmentAlarmInfomation
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string EquipmentCategory { get; set; }

        [StringLength(50)]
        public string EquipmentType { get; set; }

        [StringLength(50)]
        public string EquipmentModel { get; set; }

        [StringLength(50)]
        public string AlarmCode { get; set; }

        [StringLength(50)]
        public string AlarmName { get; set; }

        [StringLength(50)]
        public string AlarmCategory { get; set; }

        [StringLength(50)]
        public string AlarmType { get; set; }

        [StringLength(500)]
        public string AlarmDescription { get; set; }

        [Column(TypeName = "image")]
        public byte[] AlarmImage { get; set; }

        public int? ImageType { get; set; }

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
