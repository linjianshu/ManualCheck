namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_FactoryBaseInformation")]
    public partial class C_FactoryBaseInformation
    {
        [Key]
        public long FactoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string FactoryCode { get; set; }

        [Required]
        [StringLength(50)]
        public string FactoryName { get; set; }

        [StringLength(200)]
        public string FactoryDescription { get; set; }

        public long CompanyID { get; set; }

        public bool? IsAvailable { get; set; }

        public long? SolversID { get; set; }

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
