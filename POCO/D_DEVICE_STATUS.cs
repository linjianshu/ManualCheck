namespace QualityCheckDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_DEVICE_STATUS
    {
        [Key]
        [StringLength(50)]
        public string RECORD_ID { get; set; }

        [StringLength(50)]
        public string DEVICE_ID { get; set; }

        [StringLength(50)]
        public string DEVICE_CODE { get; set; }

        [StringLength(50)]
        public string DEVICE_NAME { get; set; }

        [StringLength(50)]
        public string ADDRESS_ID { get; set; }

        [StringLength(50)]
        public string STATUS_TYPE { get; set; }

        [StringLength(50)]
        public string STATUS_CONTENT { get; set; }

        [StringLength(50)]
        public string STATUS_DESC { get; set; }

        public DateTime? START_TIME { get; set; }

        public DateTime? END_TIME { get; set; }

        public int? DURATION { get; set; }

        [StringLength(50)]
        public string STATUS_REMARK { get; set; }
    }
}
