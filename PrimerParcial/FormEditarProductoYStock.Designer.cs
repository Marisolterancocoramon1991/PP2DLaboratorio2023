namespace PrimerParcial
{
    partial class FormEditarProductoYStock
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
            buttonlogearte = new Button();
            buttonCantidad = new Button();
            buttonEditar = new Button();
            labelOpcionCarne = new Label();
            label2 = new Label();
            labelCategoria = new Label();
            labelRazaCerdo = new Label();
            labelRazaDelVacuno = new Label();
            textBoxNombre = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxTipo = new TextBox();
            groupBoxAve = new GroupBox();
            comboBoxTipoAve = new ComboBox();
            labelTipoAve = new Label();
            dataGridView1 = new DataGridView();
            NombreAve = new DataGridViewTextBoxColumn();
            TipoAve = new DataGridViewTextBoxColumn();
            PrecioAve = new DataGridViewTextBoxColumn();
            CategoriaAve = new DataGridViewTextBoxColumn();
            groupBoxVacuno = new GroupBox();
            comboBox4 = new ComboBox();
            comboBoxCategoria = new ComboBox();
            comboBoxRazaVacuno = new ComboBox();
            dataGridViewVacuno = new DataGridView();
            Nombre2 = new DataGridViewTextBoxColumn();
            TipoVacuno = new DataGridViewTextBoxColumn();
            PrecioVacuno = new DataGridViewTextBoxColumn();
            RazaVacuno = new DataGridViewTextBoxColumn();
            groupBoxCerdo = new GroupBox();
            comboBoxRCerdo = new ComboBox();
            dataGridView2 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            TipoCerdo = new DataGridViewTextBoxColumn();
            RazaCerdo = new DataGridViewTextBoxColumn();
            comboBoxTipoProducto = new ComboBox();
            labelNombre = new Label();
            label3 = new Label();
            textBoxCantidad = new TextBox();
            buttonRegresar = new Button();
            pictureBox1 = new PictureBox();
            groupBoxAve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxVacuno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVacuno).BeginInit();
            groupBoxCerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonlogearte
            // 
            buttonlogearte.BackColor = Color.FromArgb(255, 128, 0);
            buttonlogearte.Location = new Point(601, 347);
            buttonlogearte.Name = "buttonlogearte";
            buttonlogearte.Size = new Size(83, 45);
            buttonlogearte.TabIndex = 1;
            buttonlogearte.Text = "Logearte";
            buttonlogearte.UseVisualStyleBackColor = false;
            buttonlogearte.Click += buttonlogearte_Click;
            // 
            // buttonCantidad
            // 
            buttonCantidad.BackColor = Color.FromArgb(128, 255, 128);
            buttonCantidad.Location = new Point(397, 339);
            buttonCantidad.Name = "buttonCantidad";
            buttonCantidad.Size = new Size(162, 23);
            buttonCantidad.TabIndex = 2;
            buttonCantidad.Text = "Agregar Stock";
            buttonCantidad.UseVisualStyleBackColor = false;
            buttonCantidad.Click += buttonCantidad_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Yellow;
            buttonEditar.Location = new Point(37, 254);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 3;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelOpcionCarne
            // 
            labelOpcionCarne.AutoSize = true;
            labelOpcionCarne.Location = new Point(32, 9);
            labelOpcionCarne.Name = "labelOpcionCarne";
            labelOpcionCarne.Size = new Size(109, 15);
            labelOpcionCarne.TabIndex = 4;
            labelOpcionCarne.Text = "Opciones Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Precio";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(391, 140);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            // 
            // labelRazaCerdo
            // 
            labelRazaCerdo.AutoSize = true;
            labelRazaCerdo.Location = new Point(384, 106);
            labelRazaCerdo.Name = "labelRazaCerdo";
            labelRazaCerdo.Size = new Size(82, 15);
            labelRazaCerdo.TabIndex = 7;
            labelRazaCerdo.Text = "Raza de Cerdo";
            //labelRazaCerdo.Click += label4_Click;
            // 
            // labelRazaDelVacuno
            // 
            labelRazaDelVacuno.AutoSize = true;
            labelRazaDelVacuno.Location = new Point(376, 69);
            labelRazaDelVacuno.Name = "labelRazaDelVacuno";
            labelRazaDelVacuno.Size = new Size(92, 15);
            labelRazaDelVacuno.TabIndex = 8;
            labelRazaDelVacuno.Text = "Raza del Vacuno";
            //labelRazaDelVacuno.Click += label5_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(12, 87);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 9;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(12, 208);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(100, 23);
            textBoxPrecio.TabIndex = 10;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(12, 144);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(100, 23);
            textBoxTipo.TabIndex = 11;
            // 
            // groupBoxAve
            // 
            groupBoxAve.Controls.Add(comboBoxTipoAve);
            groupBoxAve.Controls.Add(labelTipoAve);
            groupBoxAve.Controls.Add(dataGridView1);
            groupBoxAve.Location = new Point(164, 16);
            groupBoxAve.Name = "groupBoxAve";
            groupBoxAve.Size = new Size(520, 277);
            groupBoxAve.TabIndex = 13;
            groupBoxAve.TabStop = false;
            groupBoxAve.Text = "AVE";
            //groupBoxAve.Enter += groupBox1_Enter;
            // 
            // comboBoxTipoAve
            // 
            comboBoxTipoAve.FormattingEnabled = true;
            comboBoxTipoAve.Location = new Point(339, 89);
            comboBoxTipoAve.Name = "comboBoxTipoAve";
            comboBoxTipoAve.Size = new Size(121, 23);
            comboBoxTipoAve.TabIndex = 2;
            // 
            // labelTipoAve
            // 
            labelTipoAve.AutoSize = true;
            labelTipoAve.Location = new Point(383, 71);
            labelTipoAve.Name = "labelTipoAve";
            labelTipoAve.Size = new Size(30, 15);
            labelTipoAve.TabIndex = 1;
            labelTipoAve.Text = "Tipo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreAve, TipoAve, PrecioAve, CategoriaAve });
            dataGridView1.Location = new Point(45, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(262, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NombreAve
            // 
            NombreAve.HeaderText = "Nombre";
            NombreAve.Name = "NombreAve";
            // 
            // TipoAve
            // 
            TipoAve.HeaderText = "Tipo";
            TipoAve.Name = "TipoAve";
            // 
            // PrecioAve
            // 
            PrecioAve.HeaderText = "precio";
            PrecioAve.Name = "PrecioAve";
            // 
            // CategoriaAve
            // 
            CategoriaAve.HeaderText = "Categoria";
            CategoriaAve.Name = "CategoriaAve";
            // 
            // groupBoxVacuno
            // 
            groupBoxVacuno.Controls.Add(comboBox4);
            groupBoxVacuno.Controls.Add(comboBoxCategoria);
            groupBoxVacuno.Controls.Add(comboBoxRazaVacuno);
            groupBoxVacuno.Controls.Add(dataGridViewVacuno);
            groupBoxVacuno.Controls.Add(labelRazaDelVacuno);
            groupBoxVacuno.Controls.Add(labelCategoria);
            groupBoxVacuno.Location = new Point(159, 16);
            groupBoxVacuno.Name = "groupBoxVacuno";
            groupBoxVacuno.Size = new Size(522, 277);
            groupBoxVacuno.TabIndex = 16;
            groupBoxVacuno.TabStop = false;
            groupBoxVacuno.Text = "VACUNO";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(398, 387);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 11;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(361, 169);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 23);
            comboBoxCategoria.TabIndex = 10;
            // 
            // comboBoxRazaVacuno
            // 
            comboBoxRazaVacuno.FormattingEnabled = true;
            comboBoxRazaVacuno.Location = new Point(361, 98);
            comboBoxRazaVacuno.Name = "comboBoxRazaVacuno";
            comboBoxRazaVacuno.Size = new Size(121, 23);
            comboBoxRazaVacuno.TabIndex = 9;
            // 
            // dataGridViewVacuno
            // 
            dataGridViewVacuno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVacuno.Columns.AddRange(new DataGridViewColumn[] { Nombre2, TipoVacuno, PrecioVacuno, RazaVacuno });
            dataGridViewVacuno.Location = new Point(0, 29);
            dataGridViewVacuno.Name = "dataGridViewVacuno";
            dataGridViewVacuno.RowTemplate.Height = 25;
            dataGridViewVacuno.Size = new Size(333, 222);
            dataGridViewVacuno.TabIndex = 0;
            dataGridViewVacuno.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Nombre2
            // 
            Nombre2.HeaderText = "Nombre";
            Nombre2.Name = "Nombre2";
            // 
            // TipoVacuno
            // 
            TipoVacuno.HeaderText = "Tipo";
            TipoVacuno.Name = "TipoVacuno";
            // 
            // PrecioVacuno
            // 
            PrecioVacuno.HeaderText = "Precio";
            PrecioVacuno.Name = "PrecioVacuno";
            // 
            // RazaVacuno
            // 
            RazaVacuno.HeaderText = "Raza";
            RazaVacuno.Name = "RazaVacuno";
            // 
            // groupBoxCerdo
            // 
            groupBoxCerdo.Controls.Add(comboBoxRCerdo);
            groupBoxCerdo.Controls.Add(dataGridView2);
            groupBoxCerdo.Controls.Add(labelRazaCerdo);
            groupBoxCerdo.Location = new Point(162, 16);
            groupBoxCerdo.Name = "groupBoxCerdo";
            groupBoxCerdo.Size = new Size(522, 277);
            groupBoxCerdo.TabIndex = 15;
            groupBoxCerdo.TabStop = false;
            groupBoxCerdo.Text = "CERDO";
            //groupBoxCerdo.Enter += groupBoxCerdo_Enter;
            // 
            // comboBoxRCerdo
            // 
            comboBoxRCerdo.FormattingEnabled = true;
            comboBoxRCerdo.Location = new Point(367, 138);
            comboBoxRCerdo.Name = "comboBoxRCerdo";
            comboBoxRCerdo.Size = new Size(121, 23);
            comboBoxRCerdo.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio, TipoCerdo, RazaCerdo });
            dataGridView2.Location = new Point(49, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(262, 222);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // TipoCerdo
            // 
            TipoCerdo.HeaderText = "Tipo";
            TipoCerdo.Name = "TipoCerdo";
            // 
            // RazaCerdo
            // 
            RazaCerdo.HeaderText = "Raza";
            RazaCerdo.Name = "RazaCerdo";
            // 
            // comboBoxTipoProducto
            // 
            comboBoxTipoProducto.FormattingEnabled = true;
            comboBoxTipoProducto.Items.AddRange(new object[] { "Tipo", "Ave", "Cerdo", "Vacuno" });
            comboBoxTipoProducto.Location = new Point(32, 34);
            comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            comboBoxTipoProducto.Size = new Size(121, 23);
            comboBoxTipoProducto.TabIndex = 14;
            comboBoxTipoProducto.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBoxTipoProducto.MouseHover += comboBoxTipoProducto_MouseHover_1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(12, 69);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 15;
            labelNombre.Text = "Nombre";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 16;
            label3.Text = "Tipo";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(388, 310);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(181, 23);
            textBoxCantidad.TabIndex = 17;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = SystemColors.Info;
            buttonRegresar.Location = new Point(601, 299);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(83, 42);
            buttonRegresar.TabIndex = 18;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EditarProducto;
            pictureBox1.Location = new Point(79, 299);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormEditarProductoYStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxVacuno);
            Controls.Add(groupBoxCerdo);
            Controls.Add(buttonRegresar);
            Controls.Add(groupBoxAve);
            Controls.Add(textBoxCantidad);
            Controls.Add(label3);
            Controls.Add(labelNombre);
            Controls.Add(comboBoxTipoProducto);
            Controls.Add(textBoxTipo);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(labelOpcionCarne);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCantidad);
            Controls.Add(buttonlogearte);
            Name = "FormEditarProductoYStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditarProductoYStock";
            Load += FormEditarProductoYStock_Load;
            groupBoxAve.ResumeLayout(false);
            groupBoxAve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxVacuno.ResumeLayout(false);
            groupBoxVacuno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVacuno).EndInit();
            groupBoxCerdo.ResumeLayout(false);
            groupBoxCerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonlogearte;
        private Button buttonCantidad;
        private Button buttonEditar;
        private Label labelOpcionCarne;
        private Label label2;
        private Label labelCategoria;
        private Label labelRazaCerdo;
        private Label labelRazaDelVacuno;
        private TextBox textBoxNombre;
        private TextBox textBoxPrecio;
        private TextBox textBoxTipo;
        private GroupBox groupBoxAve;
        private DataGridView dataGridView1;
        private ComboBox comboBoxTipoProducto;
        private GroupBox groupBoxCerdo;
        private DataGridView dataGridView2;
        private GroupBox groupBoxVacuno;
        private DataGridView dataGridViewVacuno;
        private ComboBox comboBoxTipoAve;
        private Label labelTipoAve;
        private ComboBox comboBoxRazaVacuno;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBox4;
        private ComboBox comboBoxRCerdo;
        private Label labelNombre;
        private Label label3;
        private TextBox textBoxCantidad;
        private Button buttonRegresar;
        private DataGridViewTextBoxColumn NombreAve;
        private DataGridViewTextBoxColumn TipoAve;
        private DataGridViewTextBoxColumn PrecioAve;
        private DataGridViewTextBoxColumn CategoriaAve;
        private DataGridViewTextBoxColumn Nombre2;
        private DataGridViewTextBoxColumn TipoVacuno;
        private DataGridViewTextBoxColumn PrecioVacuno;
        private DataGridViewTextBoxColumn RazaVacuno;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn TipoCerdo;
        private DataGridViewTextBoxColumn RazaCerdo;
        private PictureBox pictureBox1;
    }
}