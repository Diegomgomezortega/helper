using Helper.Shared.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Helper.Shared.Data
{
    public class dbContext : DbContext
    {
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public dbContext(DbContextOptions<dbContext> options ): base(options)
        {

        }
        #region Código para evitar el Borrado en cascada
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership
                        && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
