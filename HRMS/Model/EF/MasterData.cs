namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MasterData")]
    public partial class MasterData
    {
        public long ID { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string FullName { get; set; }

        public long? ParentID { get; set; }

        [StringLength(4000)]
        public string Classiffy { get; set; }

        public DateTime? DateOfEstablish { get; set; }

        [StringLength(4000)]
        public string Representative { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public long? Position { get; set; }

        public long? Department { get; set; }

        public long? Organ { get; set; }

        public long? Bank { get; set; }

        public long? BankBranch { get; set; }

        public long? University { get; set; }

        public long? Nation { get; set; }

        public long? Province { get; set; }

        public long? District { get; set; }

        public long? Wards { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(4000)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(4000)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? Status { get; set; }
    }
}
