using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSB
{

    public partial class FrmProductos : Form
    {
        ProductosBL _productos;


        public FrmProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void ToolstripButtonSalvar_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

       
            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Almacenamiento con Exitoso");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void ToolstripButtonAgregar_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }


        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCancelar.Visible = !valor;


            //ToolstripButtonAgregar.Enabled = valor;
            //ToolstripButtonEliminar.Enabled = valor;
            //ToolstripButtonCancelar.Visible = !valor;
            
        }


        private void ToolstripButtonEliminar_Click(object sender, EventArgs e)
        {


            if (idTextBox.Text != "")
            {

                var resultado = MessageBox.Show("Desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }

        }

        private void Eliminar(int id)
        {

            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error a Eliminar este Producto");
            }
        }
   
        private void ToolstripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void categoriaIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriaIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
