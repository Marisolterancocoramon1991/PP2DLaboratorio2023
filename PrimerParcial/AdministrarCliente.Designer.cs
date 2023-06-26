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
            GrpCrearVendedores = new GroupBox();
            comboBox1 = new ComboBox();
            btnLogearse = new Button();
            btnAtras = new Button();
            GrpEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GrpCrearCliente
            // 
            GrpCrearCliente.Location = new Point(32, 24);
            GrpCrearCliente.Name = "GrpCrearCliente";
            GrpCrearCliente.Size = new Size(423, 199);
            GrpCrearCliente.TabIndex = 0;
            GrpCrearCliente.TabStop = false;
            GrpCrearCliente.Text = "Crear Cliente";
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
            GrpEditar.Location = new Point(12, 24);
            GrpEditar.Name = "GrpEditar";
            GrpEditar.Size = new Size(463, 303);
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
            // GrpCrearVendedores
            // 
            GrpCrearVendedores.Location = new Point(32, 24);
            GrpCrearVendedores.Name = "GrpCrearVendedores";
            GrpCrearVendedores.Size = new Size(423, 199);
            GrpCrearVendedores.TabIndex = 0;
            GrpCrearVendedores.TabStop = false;
            GrpCrearVendedores.Text = "Crear Vendedores";
            GrpCrearVendedores.Enter += GrpCrearVendedores_Enter;
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
            // 
            // AdministrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(614, 361);
            Controls.Add(btnAtras);
            Controls.Add(btnLogearse);
            Controls.Add(GrpEditar);
            Controls.Add(GrpCrearVendedores);
            Controls.Add(comboBox1);
            Controls.Add(GrpCrearCliente);
            Name = "AdministrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministrarCliente";
            Load += AdministrarCliente_Load;
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
    }
}