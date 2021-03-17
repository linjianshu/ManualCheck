namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_KitProcessing")]
    public partial class C_KitProcessing
    {
        public long ID { get; set; }

        public long? KitID { get; set; }

        [StringLength(50)]
        public string KitCode { get; set; }

        [StringLength(50)]
        public string KitName { get; set; }

        public int? ApplianceType { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        [StringLength(50)]
        public string StaffName { get; set; }

        public int? PositionType { get; set; }

        public long? PositionID { get; set; }

        [StringLength(50)]
        public string PositionCode { get; set; }

        [StringLength(50)]
        public string PositionName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
