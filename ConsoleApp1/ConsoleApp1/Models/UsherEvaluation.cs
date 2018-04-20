/*
 * Description: This file represents the UsherEvaluation class
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
    /// This class includes all properties of the UsherEvaluation table and its connection to other tables
    /// </summary>
    [Table("UsherEvaluation")]
    public partial class UsherEvaluation
    {
        public int UsherEvaluationId { get; set; }

        public int GradeAttained { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateGraded { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        public int UsherId { get; set; }

        public int CriterionId { get; set; }

        public int ProductionEmployeeId { get; set; }

        public virtual Criterion Criterion { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Usher Usher { get; set; }
    }
}
