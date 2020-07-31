using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}