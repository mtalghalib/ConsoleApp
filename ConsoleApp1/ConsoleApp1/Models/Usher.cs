/*
 * Description: This file represents the Usher class
 * Author: Mtsharif 
 * Date: 27/2/2018
 */

namespace ConsoleApp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// This class includes all properties of the Usher table and its connection to other tables
    /// </summary>
    [Table("Usher")]
    public partial class Usher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usher()
        {
            UsherAppointeds = new HashSet<UsherAppointed>();
            UsherEvaluations = new HashSet<UsherEvaluation>();
            UsherLanguages = new HashSet<UsherLanguage>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsherId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string MobileNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        public int Gender { get; set; }

        [StringLength(30)]
        public string Nationality { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        public bool? CarAvailability { get; set; }

        [StringLength(200)]
        public string MedicalCard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherAppointed> UsherAppointeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherEvaluation> UsherEvaluations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherLanguage> UsherLanguages { get; set; }
    }
}
