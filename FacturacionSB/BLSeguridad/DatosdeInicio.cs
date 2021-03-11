using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed (Contexto contexto)
        {
             var usuarioAdmin = new Usuario();
             usuarioAdmin.Nombre = "admin";
             usuarioAdmin.Contrasena = "123";
             contexto.Usuarios.Add(usuarioAdmin);


            var Departamento1 = new Departamento();
            Departamento1.Descripcion = "Atlántida";
            contexto.Departamento.Add(Departamento1);

            var Departamento2 = new Departamento();
            Departamento2.Descripcion = "Choluteca";
            contexto.Departamento.Add(Departamento2);

            var Departamento3 = new Departamento();
            Departamento3.Descripcion = "Colón";
            contexto.Departamento.Add(Departamento3);

            var Departamento4 = new Departamento();
            Departamento4.Descripcion = "Comayagua";
            contexto.Departamento.Add(Departamento4);

            var Departamento5 = new Departamento();
            Departamento5.Descripcion = "Copán";
            contexto.Departamento.Add(Departamento5);

            var Departamento6 = new Departamento();
            Departamento6.Descripcion = "Cortés";
            contexto.Departamento.Add(Departamento6);

            var Departamento7 = new Departamento();
            Departamento7.Descripcion = "El Paraíso";
            contexto.Departamento.Add(Departamento7);

            var Departamento8 = new Departamento();
            Departamento8.Descripcion = "Francisco Morazán";
            contexto.Departamento.Add(Departamento8);

            var Departamento9 = new Departamento();
            Departamento9.Descripcion = "Gracias a Dios";
            contexto.Departamento.Add(Departamento9);

            var Departamento10 = new Departamento();
            Departamento10.Descripcion = "Intibucá";
            contexto.Departamento.Add(Departamento10);

            var Departamento11 = new Departamento();
            Departamento11.Descripcion = "Islas de la Bahía";
            contexto.Departamento.Add(Departamento11);

            var Departamento12 = new Departamento();
            Departamento12.Descripcion = "La Paz";
            contexto.Departamento.Add(Departamento12);

            var Departamento13 = new Departamento();
            Departamento13.Descripcion = "Lempira";
            contexto.Departamento.Add(Departamento13);

            var Departamento14 = new Departamento();
            Departamento14.Descripcion = "Ocotepeque";
            contexto.Departamento.Add(Departamento14);

            var Departamento15 = new Departamento();
            Departamento15.Descripcion = "Olancho";
            contexto.Departamento.Add(Departamento15);

            var Departamento16 = new Departamento();
            Departamento16.Descripcion = "Santa Bárbara";
            contexto.Departamento.Add(Departamento16);

            var Departamento17 = new Departamento();
            Departamento17.Descripcion = "Valle";
            contexto.Departamento.Add(Departamento17);

            var Departamento18 = new Departamento();
            Departamento18.Descripcion = "Yoro";
            contexto.Departamento.Add(Departamento18);

            base.Seed(contexto);
        }

    }
}
