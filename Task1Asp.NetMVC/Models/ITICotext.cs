using Microsoft.EntityFrameworkCore;

namespace Task1Asp.NetMVC.Models
{
    public class ITICotext :DbContext   
    {
        public virtual DbSet<Guest> guests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Party; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}
