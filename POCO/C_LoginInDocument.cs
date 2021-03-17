namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_LoginInDocument")]
    public partial class C_LoginInDocument
    {
        public long ID { get; set; }

        public bool? IsSubmit { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        public long? StaffID { get; set; }

        [StringLength(50)]
        public string StaffName { get; set; }

        public DateTime? OnlineTime { get; set; }

        public DateTime? OfflineTime { get; set; }

        public long? EquipmentID { get; set; }

        [StringLength(50)]
        public string EquipmentName { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

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
