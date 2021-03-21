using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFacturacionSB
{
    public class ProductosBL
    {
        Contexto _contexto;

        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();


        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public ResultadoProducto GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);

        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        private ResultadoProducto Validar(Producto producto)
        {
            var resultado = new ResultadoProducto();
            resultado.Exitoso = true;

            if (producto.Descripcion == null)
            {

                resultado.Mensaje = "Favor Ingrese Descripcion";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {

                resultado.Mensaje = "Existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {

                resultado.Mensaje = "Precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.CategoriaId == 0)
            {

                resultado.Mensaje = "Favor Seleccione Categoria";
                resultado.Exitoso = false;
            }

            resultado.Exitoso = true;
            return resultado;

        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
        public byte[] ImagProd { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }


        public Producto()
        {
            Activo = true;
        }

    }


    public class ResultadoProducto
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
