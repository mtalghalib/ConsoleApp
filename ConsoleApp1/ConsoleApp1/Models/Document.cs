/*
 * Description: This file represents the Document class
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
    /// This class includes all properties of the Document table and its connection to other tables
    /// </summary>
    [Table("Document")]
    public partial class Document
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocumentId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(200)]
        public string FilePath { get; set; }

        [StringLength(300)]
        public string CEOFeedback { get; set; }

        public int EventProjectId { get; set; }

        public virtual EventProject EventProject { get; set; }
    }
}
