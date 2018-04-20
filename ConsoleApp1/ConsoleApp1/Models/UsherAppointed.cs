/*
 * Description: This file represents the UsherAppointed class
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
    /// This class includes all properties of the UsherAppointed table and its connection to other tables
    /// </summary>
    [Table("UsherAppointed")]
    public partial class UsherAppointed
    {
        public int UsherAppointedId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateAppointed { get; set; }

        public int UsherId { get; set; }

        public int EventProjectId { get; set; }

        public int ProductionEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual EventProject EventProject { get; set; }

        public virtual Usher Usher { get; set; }
    }
}
