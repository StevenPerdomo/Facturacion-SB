using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public SeguridadBL()
        {
            _contexto = new Contexto();
        }
                    
        public bool Acceder(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioAdmin in usuarios)
            {
                if (usuario == usuarioAdmin.Nombre && contrasena == usuarioAdmin.Contrasena)
                {
                    return true;
                }

            }

                return false;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}
