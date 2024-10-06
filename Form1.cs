using Practica_1.Clases;
using Practica_1.Modelos;
using System.Drawing.Text;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        private List<VistaProdProvee> productos;
        private List<Proveedor> proveedores;
        Operaciones _operaciones = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataProductos.SelectedRows[0];
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtID.Text = filaSeleccionada.Cells["Id"].Value.ToString();
                cmbProveedores.Text = filaSeleccionada.Cells["Proveedor"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtCantidad.Text = filaSeleccionada.Cells["Cantidad"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargarProveedores();
            txtNombre.Select();
        }

        public void cargarProductos()
        {
            using (var context = new InventarioContext())
            {
                productos = context.VistaProdProvees.ToList();
                dataProductos.DataSource = productos;
                dataProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataProductos.Columns["Id"].Visible = false;
                dataProductos.Columns["Correlativo"].HeaderText = "No.";
                dataProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            }

        }


        public void cargarProveedores()
        {
            using (var context = new InventarioContext())
            {
                proveedores = context.Proveedors.ToList();
                cmbProveedores.DataSource = proveedores;
                cmbProveedores.DisplayMember = "NombreProveedor";
                cmbProveedores.ValueMember = "Idproveedor";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Idproveedor = Convert.ToInt32(cmbProveedores.SelectedValue),
                Cantidad = int.Parse(txtCantidad.Text)
            };
            _operaciones.AgregarProducto(producto);
            cargarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Idproveedor = Convert.ToInt32(cmbProveedores.SelectedValue),
                Cantidad = int.Parse(txtCantidad.Text)
            };
            _operaciones.Actualizarproducto(producto);
            cargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            _operaciones.EliminarProducto(id);
            cargarProductos();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<VistaProdProvee> productos_encontrados = new List<VistaProdProvee>();
            productos_encontrados = _operaciones.filtrarProductos(txtCampo.Text, comboBox1.Text, productos);
            dataProductos.DataSource = productos_encontrados;
            dataProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataProductos.Columns["Id"].Visible = false;
            dataProductos.Columns["Correlativo"].HeaderText = "No.";
            dataProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cargarProductos();

        }

        private void LimpiarCampos_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCampo.Clear();
            txtCantidad.Clear();
            cmbProveedores.SelectedIndex = 0;
        }

        private void dataProductos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }

}
