namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CommingMaterial")]
    public partial class C_CommingMaterial
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string CommingMaterialCode { get; set; }

        [StringLength(50)]
        public string CommingMateriaName { get; set; }

        public int? CommingMaterialCount { get; set; }

        public DateTime? CommingMaterialTime { get; set; }

        [StringLength(50)]
        public string ContactsName { get; set; }

        [StringLength(50)]
        public string ContactsPhone { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        [StringLength(50)]
        public string StaffName { get; set; }

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
