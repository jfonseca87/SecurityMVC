using System.Data.Entity;

namespace SecurityMVC.Models
{
    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext") => Configuration.LazyLoadingEnabled = false;

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}