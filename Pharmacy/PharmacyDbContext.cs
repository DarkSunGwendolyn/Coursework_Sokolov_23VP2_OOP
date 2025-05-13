using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Pharmacy
{
    public class PharmacyDbContext : DbContext
    {
        private readonly SQLiteConnection connection;
        public DbSet<Medicine> Medicines { get; set; }

        public PharmacyDbContext(string connectionString) : base(new SQLiteConnection(connectionString), true)
        {
            connection = (SQLiteConnection)this.Database.Connection;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicine>().HasKey(m => m.Name);
            base.OnModelCreating(modelBuilder);
        }

        public void CloseConnection()
        {
            if (this.Database.Connection.State == System.Data.ConnectionState.Open)
            {
                this.Database.Connection.Close();
            }
        }
    }
}
