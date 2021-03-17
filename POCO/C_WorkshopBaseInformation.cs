namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_WorkshopBaseInformation")]
    public partial class C_WorkshopBaseInformation
    {
        [Key]
        public long WorkshopID { get; set; }

        public long? FactoryID { get; set; }

        [StringLength(50)]
        public string WorkshopCode { get; set; }

        [StringLength(50)]
        public string WorkshopName { get; set; }

        [StringLength(50)]
        public string WorkshopType { get; set; }

        public long? SolversID { get; set; }

        [StringLength(50)]
        public string WorkshopAddress { get; set; }

        [StringLength(50)]
        public string WorkshopPhone { get; set; }

        [StringLength(50)]
        public string WorkshopDescription { get; set; }

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
