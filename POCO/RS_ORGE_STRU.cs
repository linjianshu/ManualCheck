namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RS_ORGE_STRU
    {
        [Key]
        [StringLength(50)]
        public string RECORD_ID { get; set; }

        [StringLength(50)]
        public string PARENT_ORGE { get; set; }

        [StringLength(50)]
        public string CHILD_ORGE { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(50)]
        public string ENABLED { get; set; }
    }
}
