/*
 * Description: This file represents the ClientSatisfaction class
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
    /// This class includes all properties of the ClientSatisfaction table and its connection to other tables
    /// </summary>
    [Table("ClientSatisfaction")]
    public partial class ClientSatisfaction
    {
        public int ClientSatisfactionId { get; set; }

        public int GradeAttained { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateEvaluated { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        public int CriterionId { get; set; }

        public int EventProjectId { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Criterion Criterion { get; set; }

        public virtual EventProject EventProject { get; set; }
    }
}
