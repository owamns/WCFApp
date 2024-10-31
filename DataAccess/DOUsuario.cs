using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DOUsuario
    {
        // Simulación de una "base de datos" en memoria
        private static readonly List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nombre = "Juan Pérez", Correo = "juan.perez@example.com" },
            new Usuario { Id = 2, Nombre = "Ana Gómez", Correo = "ana.gomez@example.com" },
            new Usuario { Id = 3, Nombre = "Luis Martínez", Correo = "luis.martinez@example.com" }
        };

        public Usuario ObtenerUsuario(int id)
        {
            // Busca un usuario por su ID
            return Usuarios.Find(u => u.Id == id);
        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
        }
    }
}
