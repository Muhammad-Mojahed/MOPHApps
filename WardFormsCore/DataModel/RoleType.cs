namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleType")]
    public partial class RoleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoleType()
        {
            PartyRoles = new HashSet<PartyRole>();
        }

        public int RoleTypeId { get; set; }

        [Column("RoleType")]
        [StringLength(255)]
        public string RoleType1 { get; set; }

        [StringLength(255)]
        public string RoleTypeLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRole> PartyRoles { get; set; }
    }
}
