using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaCliente { get; set; }

        public ClientesBL()
        {

            ListaCliente = new BindingList<Cliente>();


            var cliente1 = new Cliente();
            cliente1.Id = 0001;
            cliente1.RazonSocial = "Plasticos";
            cliente1.RtnCliente = "05011911150001";
            cliente1.TermPago = "30 dias";
            cliente1.TipoCliente = "Credito";
            cliente1.Nombrecont = "Juan Perez";
            cliente1.Telefono = "9999-9999";
            cliente1.Email = "Jperez@plasticos.com";
            cliente1.Puesto = "Supervisor";
            cliente1.Activo = true;

            ListaCliente.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 0002;
            cliente2.RazonSocial = "Movesa";
            cliente2.RtnCliente = "05011911150002";
            cliente2.TermPago = "0";
            cliente2.TipoCliente = "Contado";
            cliente2.Nombrecont = "Pedro Paramo";
            cliente2.Telefono = "9999-9999";
            cliente2.Email = "Paramop@movesa.com";
            cliente2.Puesto = "Jefe de Matenimiento";
            cliente2.Activo = true;

            ListaCliente.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Id = 0003;
            cliente3.RazonSocial = "Corporacoion Flores";
            cliente3.RtnCliente = "05011911150003";
            cliente3.TermPago = "0";
            cliente3.TipoCliente = "Contado";
            cliente3.Nombrecont = "John Smith";
            cliente3.Telefono = "9999-9999";
            cliente3.Email = "JSmith@cflores.com";
            cliente3.Puesto = "Jefe de Matenimiento";
            cliente3.Activo = true;

            ListaCliente.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Id = 0004;
            cliente4.RazonSocial = "Molino Harinero";
            cliente4.RtnCliente = "05011911150004";
            cliente4.TermPago = "60 dias";
            cliente4.TipoCliente = "Credito";
            cliente4.Nombrecont = "Jose Soler";
            cliente4.Telefono = "9999-9999";
            cliente4.Email = "JSoler@cflores.com";
            cliente4.Puesto = "Jefe de Matenimiento";
            cliente4.Activo = true;

            ListaCliente.Add(cliente4);

            var cliente5 = new Cliente();
            cliente5.Id = 0005;
            cliente5.RazonSocial = "COPRECA";
            cliente5.RtnCliente = "05011911150005";
            cliente5.TermPago = "30 dias";
            cliente5.TipoCliente = "Credito";
            cliente5.Nombrecont = "Marco Mejia";
            cliente5.Telefono = "9999-9999";
            cliente5.Email = "Mmejia@copreca.com";
            cliente5.Puesto = "Jefe de Matenimiento";
            cliente5.Activo = true;

            ListaCliente.Add(cliente5);

            var cliente6 = new Cliente();
            cliente6.Id = 0006;
            cliente6.RazonSocial = "CES+";
            cliente6.RtnCliente = "05011911150006";
            cliente6.TermPago = "30 dias";
            cliente6.TipoCliente = "Credito";
            cliente6.Nombrecont = "Matias Grecco";
            cliente6.Telefono = "9999-9999";
            cliente6.Email = "MGrecco@ces.com";
            cliente6.Puesto = "Jefe de Matenimiento";
            cliente6.Activo = true;

            ListaCliente.Add(cliente6);
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaCliente;
        }
    }
    
      
    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RtnCliente  { get; set; }
        public string TipoCliente { get; set; }
        public string TermPago { get; set; }
        public string Nombrecont { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
    }
  }

