using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class UsuarioBL
    {
        Contexto _contexto;

        public BindingList<usuarios> ListaUsuarios { get; set; }

        public UsuarioBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<usuarios>();
        }

        public BindingList<usuarios> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }
    }

    public class usuarios
    {
        public string Nombre { get; set; }
        public string contrasena { get; set; }
    }
}
