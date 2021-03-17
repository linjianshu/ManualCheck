namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_CompanyBaseInformation")]
    public partial class C_CompanyBaseInformation
    {
        [Key]
        public long CompanyID { get; set; }

        [StringLength(50)]
        public string CompanyCode { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Nature { get; set; }

        [StringLength(50)]
        public string ArtificialPerson { get; set; }

        [StringLength(50)]
        public string Contacts { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

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
