using System.Collections.Generic;

namespace LeerData
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public Precio PrecioPromocion{ get; set; } 
        public ICollection<Comentario> ComentarioLista{ get ;set; }
        public ICollection<CursoInstructor> InstructorLink { get; set; }
    }
}