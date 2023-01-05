using ChapterTurmaOi.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterTurmaOi.Contexts
{
    public class Sqlcontext : DbContext
    {
        public Sqlcontext() { }
        public Sqlcontext(DbContextOptions<Sqlcontext> options) : base(options) { }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-1EVSQU3\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
