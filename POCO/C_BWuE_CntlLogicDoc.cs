namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_BWuE_CntlLogicDoc")]
    public partial class C_BWuE_CntlLogicDoc
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ProductBornCode { get; set; }

        [StringLength(50)]
        public string ProcedureCode { get; set; }

        public long? ControlPointID { get; set; }

        [StringLength(50)]
        public string Sort { get; set; }

        [StringLength(50)]
        public string EquipmentCode { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        public DateTime? FinishTime { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public DateTime? StartTime { get; set; }
    }
}
