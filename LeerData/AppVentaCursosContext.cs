using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {

        public AppVentaCursosContext(){
            DatabaseGeneratedAttribute.SetCommandTimeout(15000);
        }

        private const string ConnectionStringMySql = @"Server=89.46.111.105;database=Sql1341964_1;user=Sql1341964;password=fv47461kpj;old guids=true;default command timeout=800";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseMySQL(ConnectionStringMySql)
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci=> new {ci.CursoId, ci.InstructorId});
        }

        public DbSet<Curso> Curso { get; set; }
        public DbSet<Precio> Precio { get;set; }
        public DbSet<Comentario> Comentario { get;set; }
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<CursoInstructor> CursoInstructor{get;set;}
    }
}