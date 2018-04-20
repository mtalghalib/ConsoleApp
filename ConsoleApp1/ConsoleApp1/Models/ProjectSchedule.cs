/*
 * Description: This file represents the ProjectSchedule class
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
    /// This class includes all properties of the ProjectSchedule table and its connection to other tables
    /// </summary>
    [Table("ProjectSchedule")]
    public partial class ProjectSchedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public int EventProjectId { get; set; }

        public virtual EventProject EventProject { get; set; }
    }
}
