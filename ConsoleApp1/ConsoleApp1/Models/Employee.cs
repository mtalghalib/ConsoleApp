/*
 * Description: This file represents the Employee class
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
    /// This class includes all properties of the Employee table and its connection to other tables
    /// </summary>
    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            CostSheets = new HashSet<CostSheet>();
            ConfirmCostSheet = new HashSet<CostSheet>();
            SubmitCostSheet = new HashSet<CostSheet>();
            CostVariances = new HashSet<CostVariance>();
            EventProjects = new HashSet<EventProject>();
            Tasks = new HashSet<Task>();
            AssignTaskAssignments = new HashSet<TaskAssignment>();
            TaskAssignments = new HashSet<TaskAssignment>();
            UsherAppointeds = new HashSet<UsherAppointed>();
            UsherEvaluations = new HashSet<UsherEvaluation>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(50)]
        public string JobTitle { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        public int EmployeeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheet> CostSheets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheet> ConfirmCostSheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheet> SubmitCostSheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostVariance> CostVariances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventProject> EventProjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> AssignTaskAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherAppointed> UsherAppointeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsherEvaluation> UsherEvaluations { get; set; }
    }
}
