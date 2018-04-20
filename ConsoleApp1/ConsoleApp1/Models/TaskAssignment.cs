/*
 * Description: This file represents the TaskAssignment class
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
    /// This class includes all properties of the TaskAssignment table and its connection to other tables
    /// </summary>
    [Table("TaskAssignment")]
    public partial class TaskAssignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskAssignmentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AssignmentDate { get; set; }

        public int TaskId { get; set; }

        public int ClientServiceEmployeeId { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee ClientServiceEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Task Task { get; set; }
    }
}
