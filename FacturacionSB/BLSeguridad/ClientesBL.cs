using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaCliente { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();

            ListaCliente = new BindingList<Cliente>();
            
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaCliente = _contexto.Clientes.Local.ToBindingList();
            return ListaCliente;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if ( resultado.Exitoso == false )
            {
                return resultado;
            } 
            if (cliente.Id == 0)
            {
                cliente.Id = ListaCliente.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
          ListaCliente.Add(nuevoCliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaCliente)
            {
                if (cliente.Id == id)
                {
                    ListaCliente.Remove(cliente);
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if( String.IsNullOrEmpty(cliente.RazonSocial ) == true)
            {
                resultado.Mensaje = "Ingrese una Razon Social";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.RtnCliente) == true)
            {
                resultado.Mensaje = "Ingrese un #RTN";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.TermPago) == true)
            {
                resultado.Mensaje = "Ingrese un termino de pago";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.TipoCliente) == true)
            {
                resultado.Mensaje = "Ingrese el tipo de cliente";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.Nombrecont) == true)
            {
                resultado.Mensaje = "Ingrese un Contacto";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.Puesto) == true)
            {
                resultado.Mensaje = "Ingrese el Puesto";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.Email) == true)
            {
                resultado.Mensaje = "Ingrese un un correo valido";
                resultado.Exitoso = false;
            }

            if (String.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un #Telefono";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }


    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RtnCliente { get; set; }
        public string TipoCliente { get; set; }
        public string TermPago { get; set; }
        public string Nombrecont { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
  }

