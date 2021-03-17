namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CommingMaterialDetail")]
    public partial class C_CommingMaterialDetail
    {
        public long ID { get; set; }

        public long? CommingMaterialID { get; set; }

        [StringLength(50)]
        public string MaterialCode { get; set; }

        public int? MaterielType { get; set; }

        public int? MaterielState { get; set; }

        [StringLength(50)]
        public string CheckReportPath { get; set; }

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
