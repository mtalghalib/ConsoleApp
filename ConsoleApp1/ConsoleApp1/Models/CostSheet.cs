/*
 * Description: This file represents the CostSheet class
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
    /// This class includes all properties of the CostSheet table and its connection to other tables
    /// </summary>
    [Table("CostSheet")]
    public partial class CostSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CostSheet()
        {
            CostSheetItems = new HashSet<CostSheetItem>();
            //CostVariances = new HashSet<CostVariance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CostSheetId { get; set; }

        public int Status { get; set; }

        public int CDecision { get; set; }

        [StringLength(300)]
        public string CFeedback { get; set; }

        public int FDecision { get; set; }

        [StringLength(300)]
        public string FFeedback { get; set; }

        public int ProductionEmployeeId { get; set; }

        public int EventProjectId { get; set; }

        public int CEOEmployeeId { get; set; }

        public int FinanceEmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostSheetItem> CostSheetItems { get; set; }

        public virtual EventProject EventProject { get; set; }

        public virtual Employee FinanceEmployee { get; set; }

        public virtual Employee ProductionEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CostVariance> CostVariances { get; set; }
        public virtual CostVariance CostVariance { get; set; }
    }
}
