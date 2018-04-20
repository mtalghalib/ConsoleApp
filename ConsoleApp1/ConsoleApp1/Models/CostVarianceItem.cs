/*
 * Description: This file represents the CostVarianceItem class
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
    /// This class includes all properties of the CostVarianceItem table and its connection to other tables
    /// </summary>
    [Table("CostVarianceItem")]
    public partial class CostVarianceItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CostVarianceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        public decimal ActualCost { get; set; }

        public int ActualQuantity { get; set; }

        public virtual CostVariance CostVariance { get; set; }

        public virtual Item Item { get; set; }
    }
}
