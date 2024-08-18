using Microsoft.EntityFrameworkCore;
using RepositoryPattern._2___Domain.Concreta;
using RepositoryPattern._2___Domain.Entity;
using RepositoryPattern.Entity;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RepositoryPattern.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UsuarioEntity>   Usuario     { get; set; }
        public DbSet<CategoriaEntity> Categoria   { get; set; }
        public DbSet<LoginEntity>     Login       { get; set; }
        public DbSet<MesGastoEntity>  MesGasto    { get; set; }
        public DbSet<ReceitaEntity>   Receita     { get; set; }
        public DbSet<GastoEntity>     Gasto       { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Método de definição bem interessante
            modelBuilder.Entity<UsuarioEntity>()
                        .HasOne(u => u.LoginEntity)
                        .WithOne(u => u.UsuarioEntity)
                        .HasForeignKey<LoginEntity>(l => l.FkUsuario);

            modelBuilder.Entity<UsuarioEntity>()
                        .HasMany(g => g.GastosEntity)
                        .WithOne(u => u.UsuarioEntity)
                        .HasForeignKey(fk => fk.FkUsuario);

            modelBuilder.Entity<GastoEntity>()
                        .HasOne(g => g.CategoriaEntity)
                        .WithMany(c => c.GastoEntities)
                        .HasForeignKey(g => g.FkCategoria);

            modelBuilder.Entity<ReceitaEntity>()
                        .HasMany(p => p.CategoriaEntity)
                        .WithOne(c => c.ReceitaEntities)
                        .HasForeignKey(c => c.FkReceita);

            base.OnModelCreating(modelBuilder);
        }
    }
}    
        