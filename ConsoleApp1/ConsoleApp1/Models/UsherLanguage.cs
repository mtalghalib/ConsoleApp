/*
 * Description: This file represents the UsherLanguage class
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
    /// This class includes all properties of the UsherLanguage table and its connection to other tables
    /// </summary>
    [Table("UsherLanguage")]
    public partial class UsherLanguage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsherId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string Language { get; set; }

        public virtual Usher Usher { get; set; }
    }
}
