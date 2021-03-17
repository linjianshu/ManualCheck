namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BBdbR_CntlPntBase")]
    public partial class C_BBdbR_CntlPntBase
    {
        [Key]
        public long CntlPntId { get; set; }

        [StringLength(50)]
        public string CntlPntCd { get; set; }

        [StringLength(50)]
        public string CntlPntNm { get; set; }

        [StringLength(50)]
        public string CntlPntTyp { get; set; }

        public int? CntlPntSort { get; set; }

        [StringLength(50)]
        public string Enabled { get; set; }

        public DateTime? CreTm { get; set; }

        [StringLength(50)]
        public string CreCd { get; set; }

        [StringLength(50)]
        public string CreNm { get; set; }

        public DateTime? MdfTm { get; set; }

        [StringLength(50)]
        public string MdfCd { get; set; }

        [StringLength(50)]
        public string MdfNm { get; set; }

        [StringLength(200)]
        public string Rem { get; set; }
    }
}
