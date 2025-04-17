using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace ekz
{
    public class PartnerContext : DbContext
    {
        //string sql = "Host=localhost;Port=5050;Database=ekzdb;Username=postgres;Password=Pass11";
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Partner_type> Partner_type_id { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=ekzdb;Username=postgres;Password=Pass11");
        }

        //protected void SqlConnectionReader()
        //{
        //    NpgsqlConnection sqlConnection = new NpgsqlConnection(sql);
        //    sqlConnection.Open();
        //    NpgsqlCommand sqlCommand = new NpgsqlCommand();
        //    sqlCommand.Connection = sqlConnection;
        //    sqlConnection.Close();
        //}
    }
}
