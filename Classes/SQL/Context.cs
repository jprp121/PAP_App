
using Microsoft.EntityFrameworkCore;

namespace PAP_AppParaGestaoDeEmpresas.Classes.SQL
{
    public class DB : DbContext
    {
        public DbSet<Artigo> Artigos;
        public DbSet<Morada> Moradas;
        public DbSet<OrdemTrabalho> OrdemTrabalhos;
        public DbSet<User> Users;
        public DbSet<Team> Teams;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artigo>().HasMany((u) => u.user);
            modelBuilder.Entity<Artigo>().HasMany((a) => a.artigo_OrdemTrabalho);

            modelBuilder.Entity<Morada>().HasOne((m) => m.user);

            modelBuilder.Entity<Team>().HasOne((t) => t.categoriaTeam);
            
            modelBuilder.Entity<User>().HasMany((m) => m.moradas);
            modelBuilder.Entity<User>().HasMany((m) => m.user_Team);
            modelBuilder.Entity<User>().HasMany((m) => m.ordemTrabalho);
            modelBuilder.Entity<User>().HasMany((m) => m.artigo);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=db.db");
    }
}
