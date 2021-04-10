using System;

namespace Switch.Domain.Entities
{
   public class Comentario
    {
        public int Id { get; set; }
        public DateTime DataPublicaca { get; set; }  
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; private set; }

        public Comentario()
        {
            DataPublicaca = DateTime.Now;
        }
        public void SetUsuario(Usuario usuario)
        {
            if(usuario != null)
            {
                Usuario = usuario;
            }
        }
    }
}
