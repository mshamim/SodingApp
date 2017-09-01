using SodingApp.Models;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;

namespace SodingApp.Persistence
{
    [ExcludeFromCodeCoverage]
    public class SodingContext : DbContext, IDataContext
    {
        public SodingContext()
            : base("database")
        {
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        //public IDbSet<Application> Applications { get; set; }
        //public IDbSet<Team> Teams { get; set; }
        public IDbSet<UserTask> UserTasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void ExecuteCommand(string command, params object[] parameters)
        {
            base.Database.ExecuteSqlCommand(command, parameters);
        }
    }
}