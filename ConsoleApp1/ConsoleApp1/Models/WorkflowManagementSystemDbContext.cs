/*
 * Description: This file represents the database context
 * Author: Mtsharif 
 * Date: 27/2/2018
 */

namespace ConsoleApp1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    /// <summary>
    /// This class includes all relations present in the database
    /// </summary>
    public partial class WorkflowManagementSystemDbContext : DbContext
    {
        public WorkflowManagementSystemDbContext()
            : base("name=WorkflowManagementSystemDbContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientSatisfaction> ClientSatisfactions { get; set; }
        public virtual DbSet<CostSheet> CostSheets { get; set; }
        public virtual DbSet<CostSheetItem> CostSheetItems { get; set; }
        public virtual DbSet<CostVariance> CostVariances { get; set; }
        public virtual DbSet<CostVarianceItem> CostVarianceItems { get; set; }
        public virtual DbSet<Criterion> Criteria { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EventProject> EventProjects { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ProjectSchedule> ProjectSchedules { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskAssignment> TaskAssignments { get; set; }
        public virtual DbSet<Usher> Ushers { get; set; }
        public virtual DbSet<UsherAppointed> UsherAppointeds { get; set; }
        public virtual DbSet<UsherEvaluation> UsherEvaluations { get; set; }
        public virtual DbSet<UsherLanguage> UsherLanguages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ForeignKeyIndexConvention>();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientSatisfactions)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.EventProjects)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CostSheet>()
                .HasMany(e => e.CostSheetItems)
                .WithRequired(e => e.CostSheet)
                .HasForeignKey(e => e.CostSheetId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CostSheet>()
                .HasRequired(e => e.CostVariance)
                .WithRequiredPrincipal(e => e.CostSheet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CostVariance>()
                .HasMany(e => e.CostVarianceItems)
                .WithRequired(e => e.CostVariance)
                .HasForeignKey(e => e.CostVarianceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CostVarianceItem>()
                .Property(e => e.ActualCost)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Criterion>()
                .HasMany(e => e.ClientSatisfactions)
                .WithRequired(e => e.Criterion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Criterion>()
                .HasMany(e => e.UsherEvaluations)
                .WithRequired(e => e.Criterion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.CostSheets)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.CEOEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ConfirmCostSheet)
                .WithRequired(e => e.FinanceEmployee)
                .HasForeignKey(e => e.FinanceEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SubmitCostSheet)
                .WithRequired(e => e.ProductionEmployee)
                .HasForeignKey(e => e.ProductionEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.CostVariances)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.FinanceEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventProjects)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ClientServiceEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ClientServiceEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.AssignTaskAssignments)
                .WithRequired(e => e.ClientServiceEmployee)
                .HasForeignKey(e => e.ClientServiceEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.TaskAssignments)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.UsherAppointeds)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ProductionEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.UsherEvaluations)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.ProductionEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.ClientSatisfactions)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.CostSheets)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.Documents)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.ProjectSchedules)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventProject>()
                .HasMany(e => e.UsherAppointeds)
                .WithRequired(e => e.EventProject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.UnitCost)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.CostSheetItems)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.ItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.CostVarianceItems)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.ItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskAssignments)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usher>()
                .HasMany(e => e.UsherAppointeds)
                .WithRequired(e => e.Usher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usher>()
                .HasMany(e => e.UsherEvaluations)
                .WithRequired(e => e.Usher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usher>()
                .HasMany(e => e.UsherLanguages)
                .WithRequired(e => e.Usher)
                .HasForeignKey(e => e.UsherId)
                .WillCascadeOnDelete(false);
        }
    }
}
