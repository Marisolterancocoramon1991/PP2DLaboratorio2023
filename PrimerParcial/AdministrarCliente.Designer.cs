namespace PrimerParcial
{
    partial class AdministrarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GrpCrearCliente = new GroupBox();
            textCorrreoCliente = new TextBox();
            textContraseñaCliente = new TextBox();
            btnCrearCliente = new Button();
            textSaldo = new TextBox();
            textCuenta = new TextBox();
            textDireccion = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            GrpCrearVendedores = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            btnCrearVendedor = new Button();
            textSueldoTra = new TextBox();
            textContraseñaTra = new TextBox();
            textCorreoTra = new TextBox();
            textDireccionTra = new TextBox();
            textApellidoTra = new TextBox();
            textNombreTrabajador = new TextBox();
            GrpEditar = new GroupBox();
            btnModificar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labelDireccion = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCuentaUsuario = new TextBox();
            txtSaldoUsuario = new TextBox();
            txtContraseñaUsuario = new TextBox();
            txtCorreoUsuario = new TextBox();
            txtDireccioUsuario = new TextBox();
            txtApellidoUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Saldo = new DataGridViewTextBoxColumn();
            NumeroDeCuenta = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            btnLogearse = new Button();
            btnAtras = new Button();
            GrpCrearCliente.SuspendLayout();
            GrpCrearVendedores.SuspendLayout();
            GrpEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GrpCrearCliente
            // 
            GrpCrearCliente.Controls.Add(textCorrreoCliente);
            GrpCrearCliente.Controls.Add(textContraseñaCliente);
            GrpCrearCliente.Controls.Add(btnCrearCliente);
            GrpCrearCliente.Controls.Add(textSaldo);
            GrpCrearCliente.Controls.Add(textCuenta);
            GrpCrearCliente.Controls.Add(textDireccion);
            GrpCrearCliente.Controls.Add(textApellido);
            GrpCrearCliente.Controls.Add(textNombre);
            GrpCrearCliente.Controls.Add(label19);
            GrpCrearCliente.Controls.Add(label18);
            GrpCrearCliente.Controls.Add(label17);
            GrpCrearCliente.Controls.Add(label16);
            GrpCrearCliente.Controls.Add(label15);
            GrpCrearCliente.Controls.Add(label14);
            GrpCrearCliente.Controls.Add(label13);
            GrpCrearCliente.Location = new Point(12, 12);
            GrpCrearCliente.Name = "GrpCrearCliente";
            GrpCrearCliente.Size = new Size(423, 199);
            GrpCrearCliente.TabIndex = 0;
            GrpCrearCliente.TabStop = false;
            GrpCrearCliente.Text = "Crear Cliente";
            // 
            // textCorrreoCliente
            // 
            textCorrreoCliente.Location = new Point(6, 108);
            textCorrreoCliente.Name = "textCorrreoCliente";
            textCorrreoCliente.Size = new Size(100, 23);
            textCorrreoCliente.TabIndex = 16;
            // 
            // textContraseñaCliente
            // 
            textContraseñaCliente.Location = new Point(140, 108);
            textContraseñaCliente.Name = "textContraseñaCliente";
            textContraseñaCliente.Size = new Size(100, 23);
            textContraseñaCliente.TabIndex = 15;
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.Location = new Point(304, 160);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(75, 23);
            btnCrearCliente.TabIndex = 14;
            btnCrearCliente.Text = "crear";
            btnCrearCliente.UseVisualStyleBackColor = true;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // textSaldo
            // 
            textSaldo.Location = new Point(272, 107);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(100, 23);
            textSaldo.TabIndex = 13;
            // 
            // textCuenta
            // 
            textCuenta.Location = new Point(6, 159);
            textCuenta.Name = "textCuenta";
            textCuenta.Size = new Size(100, 23);
            textCuenta.TabIndex = 11;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(272, 57);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 9;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(140, 57);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 8;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(6, 57);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(30, 144);
            label19.Name = "label19";
            label19.Size = new Size(45, 15);
            label19.TabIndex = 6;
            label19.Text = "Cuenta";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(306, 89);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 5;
            label18.Text = "Saldo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(155, 89);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 4;
            label17.Text = "Contraseña";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(30, 90);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 3;
            label16.Text = "Correo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(296, 35);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 2;
            label15.Text = "Direccion";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(164, 35);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 1;
            label14.Text = "Apellido ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 35);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 0;
            label13.Text = "Nombre";
            label13.Click += label13_Click;
            // 
            // GrpCrearVendedores
            // 
            GrpCrearVendedores.Controls.Add(label12);
            GrpCrearVendedores.Controls.Add(label11);
            GrpCrearVendedores.Controls.Add(label10);
            GrpCrearVendedores.Controls.Add(label9);
            GrpCrearVendedores.Controls.Add(label8);
            GrpCrearVendedores.Controls.Add(label3);
            GrpCrearVendedores.Controls.Add(btnCrearVendedor);
            GrpCrearVendedores.Controls.Add(textSueldoTra);
            GrpCrearVendedores.Controls.Add(textContraseñaTra);
            GrpCrearVendedores.Controls.Add(textCorreoTra);
            GrpCrearVendedores.Controls.Add(textDireccionTra);
            GrpCrearVendedores.Controls.Add(textApellidoTra);
            GrpCrearVendedores.Controls.Add(textNombreTrabajador);
            GrpCrearVendedores.Location = new Point(11, 12);
            GrpCrearVendedores.Name = "GrpCrearVendedores";
            GrpCrearVendedores.Size = new Size(424, 199);
            GrpCrearVendedores.TabIndex = 0;
            GrpCrearVendedores.TabStop = false;
            GrpCrearVendedores.Text = "Crear Vendedores";
            GrpCrearVendedores.Enter += GrpCrearVendedores_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(302, 30);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 13;
            label12.Text = "direccion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(194, 30);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 12;
            label11.Text = "Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 100);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 11;
            label10.Text = "Correo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(302, 100);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 10;
            label9.Text = "Sueldo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 100);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 9;
            label8.Text = "contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 30);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // btnCrearVendedor
            // 
            btnCrearVendedor.Location = new Point(320, 164);
            btnCrearVendedor.Name = "btnCrearVendedor";
            btnCrearVendedor.Size = new Size(75, 23);
            btnCrearVendedor.TabIndex = 7;
            btnCrearVendedor.Text = "Crear ";
            btnCrearVendedor.UseVisualStyleBackColor = true;
            btnCrearVendedor.Click += btnCrearVendedor_Click;
            // 
            // textSueldoTra
            // 
            textSueldoTra.Location = new Point(275, 126);
            textSueldoTra.Name = "textSueldoTra";
            textSueldoTra.Size = new Size(100, 23);
            textSueldoTra.TabIndex = 6;
            // 
            // textContraseñaTra
            // 
            textContraseñaTra.Location = new Point(169, 126);
            textContraseñaTra.Name = "textContraseñaTra";
            textContraseñaTra.Size = new Size(100, 23);
            textContraseñaTra.TabIndex = 4;
            // 
            // textCorreoTra
            // 
            textCorreoTra.Location = new Point(63, 126);
            textCorreoTra.Name = "textCorreoTra";
            textCorreoTra.Size = new Size(100, 23);
            textCorreoTra.TabIndex = 3;
            // 
            // textDireccionTra
            // 
            textDireccionTra.Location = new Point(275, 58);
            textDireccionTra.Name = "textDireccionTra";
            textDireccionTra.Size = new Size(100, 23);
            textDireccionTra.TabIndex = 2;
            // 
            // textApellidoTra
            // 
            textApellidoTra.Location = new Point(169, 58);
            textApellidoTra.Name = "textApellidoTra";
            textApellidoTra.Size = new Size(100, 23);
            textApellidoTra.TabIndex = 1;
            // 
            // textNombreTrabajador
            // 
            textNombreTrabajador.Location = new Point(63, 58);
            textNombreTrabajador.Name = "textNombreTrabajador";
            textNombreTrabajador.Size = new Size(100, 23);
            textNombreTrabajador.TabIndex = 0;
            // 
            // GrpEditar
            // 
            GrpEditar.Controls.Add(btnModificar);
            GrpEditar.Controls.Add(label7);
            GrpEditar.Controls.Add(label6);
            GrpEditar.Controls.Add(label5);
            GrpEditar.Controls.Add(label4);
            GrpEditar.Controls.Add(labelDireccion);
            GrpEditar.Controls.Add(label2);
            GrpEditar.Controls.Add(label1);
            GrpEditar.Controls.Add(txtCuentaUsuario);
            GrpEditar.Controls.Add(txtSaldoUsuario);
            GrpEditar.Controls.Add(txtContraseñaUsuario);
            GrpEditar.Controls.Add(txtCorreoUsuario);
            GrpEditar.Controls.Add(txtDireccioUsuario);
            GrpEditar.Controls.Add(txtApellidoUsuario);
            GrpEditar.Controls.Add(txtNombreUsuario);
            GrpEditar.Controls.Add(dataGridView1);
            GrpEditar.Location = new Point(11, 15);
            GrpEditar.Name = "GrpEditar";
            GrpEditar.Size = new Size(464, 263);
            GrpEditar.TabIndex = 0;
            GrpEditar.TabStop = false;
            GrpEditar.Text = "Editar Cliente";
            GrpEditar.Enter += GrpEditar_Enter;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(349, 226);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 202);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 15;
            label7.Text = "Cuenta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 202);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 14;
            label6.Text = "Saldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 202);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 149);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Correo";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(243, 149);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 11;
            labelDireccion.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 149);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 149);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtCuentaUsuario
            // 
            txtCuentaUsuario.Location = new Point(218, 227);
            txtCuentaUsuario.Name = "txtCuentaUsuario";
            txtCuentaUsuario.Size = new Size(100, 23);
            txtCuentaUsuario.TabIndex = 7;
            // 
            // txtSaldoUsuario
            // 
            txtSaldoUsuario.Location = new Point(112, 227);
            txtSaldoUsuario.Name = "txtSaldoUsuario";
            txtSaldoUsuario.Size = new Size(100, 23);
            txtSaldoUsuario.TabIndex = 6;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Location = new Point(6, 227);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.Size = new Size(100, 23);
            txtContraseñaUsuario.TabIndex = 5;
            // 
            // txtCorreoUsuario
            // 
            txtCorreoUsuario.Location = new Point(324, 170);
            txtCorreoUsuario.Name = "txtCorreoUsuario";
            txtCorreoUsuario.Size = new Size(100, 23);
            txtCorreoUsuario.TabIndex = 4;
            // 
            // txtDireccioUsuario
            // 
            txtDireccioUsuario.Location = new Point(218, 170);
            txtDireccioUsuario.Name = "txtDireccioUsuario";
            txtDireccioUsuario.Size = new Size(100, 23);
            txtDireccioUsuario.TabIndex = 3;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Location = new Point(112, 170);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(100, 23);
            txtApellidoUsuario.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(6, 170);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Direccion, Correo, Contraseña, Saldo, NumeroDeCuenta, Tipo });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(451, 117);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña ";
            Contraseña.Name = "Contraseña";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // NumeroDeCuenta
            // 
            NumeroDeCuenta.HeaderText = "NuemeroDeCuenta";
            NumeroDeCuenta.Name = "NumeroDeCuenta";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "TipoUsuario";
            Tipo.Name = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.IndianRed;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cerrar", "CrearClientes", "CrearVendedores", "EditarClientes" });
            comboBox1.Location = new Point(481, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnLogearse
            // 
            btnLogearse.BackColor = Color.FromArgb(255, 128, 128);
            btnLogearse.Location = new Point(537, 226);
            btnLogearse.Name = "btnLogearse";
            btnLogearse.Size = new Size(75, 23);
            btnLogearse.TabIndex = 1;
            btnLogearse.Text = "logearse";
            btnLogearse.UseVisualStyleBackColor = false;
            btnLogearse.Click += btnLogearse_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaption;
            btnAtras.Location = new Point(490, 255);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Regresar";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // AdministrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(614, 361);
            Controls.Add(GrpEditar);
            Controls.Add(GrpCrearVendedores);
            Controls.Add(btnAtras);
            Controls.Add(btnLogearse);
            Controls.Add(comboBox1);
            Controls.Add(GrpCrearCliente);
            Name = "AdministrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministrarCliente";
            Load += AdministrarCliente_Load;
            GrpCrearCliente.ResumeLayout(false);
            GrpCrearCliente.PerformLayout();
            GrpCrearVendedores.ResumeLayout(false);
            GrpCrearVendedores.PerformLayout();
            GrpEditar.ResumeLayout(false);
            GrpEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpCrearCliente;
        private GroupBox GrpEditar;
        private GroupBox GrpCrearVendedores;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewTextBoxColumn NumeroDeCuenta;
        private DataGridViewTextBoxColumn Tipo;
        private Button btnLogearse;
        private Button btnAtras;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label labelDireccion;
        private Label label2;
        private Label label1;
        private TextBox txtCuentaUsuario;
        private TextBox txtSaldoUsuario;
        private TextBox txtContraseñaUsuario;
        private TextBox txtCorreoUsuario;
        private TextBox txtDireccioUsuario;
        private TextBox txtApellidoUsuario;
        private TextBox txtNombreUsuario;
        private Button btnModificar;
        private TextBox textSaldo;
        private TextBox textCuenta;
        private TextBox textDireccion;
        private TextBox textApellido;
        private TextBox textNombre;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label3;
        private Button btnCrearVendedor;
        private TextBox textSueldoTra;
        private TextBox textContraseñaTra;
        private TextBox textCorreoTra;
        private TextBox textDireccionTra;
        private TextBox textApellidoTra;
        private TextBox textNombreTrabajador;
        private Button btnCrearCliente;
        private TextBox textCorrreoCliente;
        private TextBox textContraseñaCliente;
    }
}