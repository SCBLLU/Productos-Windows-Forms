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
            txtID.Enabled = false; // Deshabilitar el campo ID
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
                txtID.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtBuscar.Clear();
                txtCantidad.Clear();
                if (cmbProveedores.Items.Count > 0)
                {
                    cmbProveedores.SelectedIndex = 0;
                }
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
            Validaciones validaciones = new Validaciones();
            if (validaciones.validarnombre(txtNombre.Text) == false)
            {
                MessageBox.Show("El campo nombre no puede estar vacío");
                return;
            }
            if (validaciones.validarcosto(txtPrecio.Text) == false)
            {
                MessageBox.Show("El campo precio no puede estar vacío");
                return;
            }
            if (validaciones.validarproveedor(cmbProveedores.Text) == false)
            {
                MessageBox.Show("El campo proveedor no puede estar vacío");
                return;
            }
            if (validaciones.validarcantidad(txtCantidad.Text) == false)
            {
                MessageBox.Show("El campo cantidad no puede estar vacío");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El campo precio debe ser un número válido");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("El campo cantidad debe ser un número válido");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Desea agregar el producto?", "Agregar producto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Producto agregado");
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
            else
            {
                MessageBox.Show("Producto no agregado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            if (validaciones.validarnombre(txtNombre.Text) == false)
            {
                MessageBox.Show("El campo nombre no puede estar vacío");
                return;
            }
            if (validaciones.validarcosto(txtPrecio.Text) == false)
            {
                MessageBox.Show("El campo precio no puede estar vacío");
                return;
            }
            if (validaciones.validarproveedor(cmbProveedores.Text) == false)
            {
                MessageBox.Show("El campo proveedor no puede estar vacío");
                return;
            }
            if (validaciones.validarcantidad(txtCantidad.Text) == false)
            {
                MessageBox.Show("El campo cantidad no puede estar vacío");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Desea actualizar el producto?", "Actualizar producto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Producto actualizado");
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
            else
            {
                MessageBox.Show("Producto no actualizado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Producto eliminado");
                _operaciones.EliminarProducto(int.Parse(txtID.Text));
                cargarProductos();
            }
            else
            {
                MessageBox.Show("Producto no eliminado");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string BuscadorTexto = txtBuscar.Text.ToLower();
            var FiltrarProductos = productos.Where(p => p.Nombre.ToLower().Contains(BuscadorTexto)).ToList();
            dataProductos.DataSource = FiltrarProductos;
            dataProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataProductos.Columns["Id"].Visible = false;
            dataProductos.Columns["Correlativo"].HeaderText = "No.";
            dataProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            txtBuscar.Clear();
            txtCantidad.Clear();
            cmbProveedores.SelectedIndex = 0;
        }

        private void dataProductos_SelectionChanged(object sender, EventArgs e)
        {

        }
    }

}

