namespace Practica_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmbProveedores = new ComboBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataProductos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            txtBuscar = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProveedores);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 439);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Productos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbProveedores
            // 
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(165, 221);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(150, 33);
            cmbProveedores.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 288);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(165, 288);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(165, 161);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(165, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 221);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "ID_PROVEEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 161);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "COSTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 109);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 50);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataProductos);
            groupBox2.Location = new Point(550, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(570, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tabla Productos en BD";
            // 
            // dataProductos
            // 
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Location = new Point(19, 50);
            dataProductos.Name = "dataProductos";
            dataProductos.RowHeadersWidth = 62;
            dataProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProductos.Size = new Size(533, 269);
            dataProductos.TabIndex = 0;
            dataProductos.CellContentClick += dataGridView1_CellContentClick;
            dataProductos.SelectionChanged += dataProductos_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 356);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 73);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(190, 356);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 73);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(335, 356);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 73);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 373);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 13;
            label6.Text = "BUSCAR";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(636, 370);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(234, 31);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(970, 361);
            button1.Name = "button1";
            button1.Size = new Size(132, 48);
            button1.TabIndex = 18;
            button1.Text = "Restablecer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 558);
            Controls.Add(button1);
            Controls.Add(txtBuscar);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataProductos;
        private Label label5;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label6;
        private TextBox txtBuscar;
        private ComboBox cmbProveedores;
        private Button button1;
    }
}
