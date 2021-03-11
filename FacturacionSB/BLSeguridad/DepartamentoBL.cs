using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class DepartamentoBL
    {
        Contexto _contexto;   

        public BindingList<Departamento> ListaDepartamento { get; set; }

        public DepartamentoBL()
        {
            _contexto = new Contexto();
            ListaDepartamento = new BindingList<Departamento>();
        }

        public BindingList<Departamento> ObtenerDepartamenro()
        {
            _contexto.Departamento.Load();
            ListaDepartamento = _contexto.Departamento.Local.ToBindingList();

            return ListaDepartamento;
        }
    }

    public class Departamento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
