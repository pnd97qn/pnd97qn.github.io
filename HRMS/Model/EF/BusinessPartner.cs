namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessPartner")]
    public partial class BusinessPartner
    {
        public long ID { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Image { get; set; }

        public bool? Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(4000)]
        public string PlaceOfBirth { get; set; }

        public long? ParentID { get; set; }

        public long? IDNation { get; set; }

        public long? IDProvince { get; set; }

        public long? IDDistrict { get; set; }

        public long? IDWards { get; set; }

        [StringLength(4000)]
        public string Race { get; set; }

        [StringLength(4000)]
        public string Religion { get; set; }

        public long? IDPosition { get; set; }

        public long? IDDepartment { get; set; }

        public long? IDOrgan { get; set; }

        public DateTime? DayToWork { get; set; }

        public long? IDInsurrance { get; set; }

        public long? IDLaborContract { get; set; }

        public long? IDBank { get; set; }

        public long? IDBankBranch { get; set; }

        [StringLength(4000)]
        public string Tax { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string Phone { get; set; }

        [StringLength(4000)]
        public string Email { get; set; }

        [StringLength(4000)]
        public string Fax { get; set; }

        [StringLength(4000)]
        public string IDNumber { get; set; }

        [StringLength(4000)]
        public string PlaceOfIssue { get; set; }

        [StringLength(4000)]
        public string MaritalStatus { get; set; }

        [StringLength(4000)]
        public string EducationalLevel { get; set; }

        public long? IDUniversity { get; set; }

        [StringLength(4000)]
        public string Speciality { get; set; }

        public DateTime? GraduatedYear { get; set; }

        [StringLength(4000)]
        public string DegreeAchieved { get; set; }

        [StringLength(4000)]
        public string LanguageSkill { get; set; }

        [StringLength(4000)]
        public string ComputerSkill { get; set; }

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
