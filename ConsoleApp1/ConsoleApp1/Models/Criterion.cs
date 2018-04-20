/*
 * Description: This file represents the Criterion class
 * Aurthor: Mtsharif 
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
    /// This class includes all properties of the Criterion table and its connection to other tables
    /// </summary>
    [Table("Criterion")]
    public partial class Criterion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criterion()
        {
            ClientSatisfactions = new HashSet<ClientSatisfaction>();
            UsherEvaluations = new HashSet<UsherEvaluation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CriterionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSatisfaction> ClientSatisfactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherEvaluation> UsherEvaluations { get; set; }
    }
}
