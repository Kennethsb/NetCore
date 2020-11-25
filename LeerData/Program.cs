using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {
                var cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var comentario in curso.ComentarioLista)
                    {
                        Console.WriteLine("*************" + comentario.ComentarioTexto);
                    }
                }
            }
        }
    }
}