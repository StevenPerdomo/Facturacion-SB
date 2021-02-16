using BLFacturacionSB;
using System;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmClientes : Form
    {
        ClientesBL _clientes;


        public FrmClientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClienteBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            
            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClienteBindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClienteBindingSource.EndEdit();

            var cliente = (Cliente)listaClienteBindingSource.Current;

            var resultado = _clientes.GuardarCliente(cliente);

            if( resultado == true)
            {
                listaClienteBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un error guardando el Cliente");
            }
        }
    }
}
