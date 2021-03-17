namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataCollect")]
    public partial class DataCollect
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string WorkCenterCode { get; set; }

        [StringLength(50)]
        public string SerialCode { get; set; }

        [StringLength(50)]
        public string AddressName { get; set; }

        [StringLength(100)]
        public string AddressValue { get; set; }

        public DateTime? CollectTime { get; set; }

        public bool? HasRead { get; set; }

        [StringLength(50)]
        public string ErrorMsg { get; set; }
    }
}
