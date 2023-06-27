namespace PrimerParcial
{
    partial class FormVentaDeCarne
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupCerdo = new GroupBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewVacuno = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            clm6 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewCerdo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            PrecioColumna = new DataGridViewTextBoxColumn();
            clm4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            buttonFactura = new Button();
            textBuscador = new TextBox();
            buttonBuscar = new Button();
            groupBoxTipoPago = new GroupBox();
            radioButtonTarjeteDebito = new RadioButton();
            radioButtonMarcadoPago = new RadioButton();
            radioButtonTarjetaC = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            buttonComprar = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            labelDinero = new Label();
            labelNombre = new Label();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            raza = new DataGridViewTextBoxColumn();
            groupCerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVacuno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCerdo).BeginInit();
            groupBoxTipoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupCerdo
            // 
            groupCerdo.BackColor = Color.FromArgb(255, 128, 128);
            groupCerdo.Controls.Add(label4);
            groupCerdo.Controls.Add(comboBox1);
            groupCerdo.Controls.Add(dataGridViewVacuno);
            groupCerdo.Controls.Add(dataGridViewCerdo);
            groupCerdo.Controls.Add(buttonFactura);
            groupCerdo.Controls.Add(textBuscador);
            groupCerdo.Controls.Add(buttonBuscar);
            groupCerdo.Controls.Add(groupBoxTipoPago);
            groupCerdo.Controls.Add(label3);
            groupCerdo.Controls.Add(label2);
            groupCerdo.Controls.Add(button3);
            groupCerdo.Controls.Add(button2);
            groupCerdo.Controls.Add(buttonComprar);
            groupCerdo.Controls.Add(label1);
            groupCerdo.Controls.Add(numericUpDown1);
            groupCerdo.Controls.Add(labelDinero);
            groupCerdo.Controls.Add(labelNombre);
            groupCerdo.Controls.Add(dataGridView1);
            groupCerdo.Location = new Point(-2, 3);
            groupCerdo.Name = "groupCerdo";
            groupCerdo.Size = new Size(637, 426);
            groupCerdo.TabIndex = 0;
            groupCerdo.TabStop = false;
            groupCerdo.Text = "Carniceria_Teran";
            groupCerdo.Enter += groupCerdo_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 13);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 17;
            label4.Text = "Elegir lista de producto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ave", "Cerdo", "Vacuno" });
            comboBox1.Location = new Point(498, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewVacuno
            // 
            dataGridViewVacuno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVacuno.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, clm6, Column6 });
            dataGridViewVacuno.Location = new Point(51, 67);
            dataGridViewVacuno.Name = "dataGridViewVacuno";
            dataGridViewVacuno.RowTemplate.Height = 25;
            dataGridViewVacuno.Size = new Size(502, 250);
            dataGridViewVacuno.TabIndex = 15;
            dataGridViewVacuno.CellContentClick += dataGridViewVacuno_CellContentClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tipo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Precio";
            Column5.Name = "Column5";
            // 
            // clm6
            // 
            clm6.HeaderText = "Raza";
            clm6.Name = "clm6";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.Name = "Column6";
            // 
            // dataGridViewCerdo
            // 
            dataGridViewCerdo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCerdo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, PrecioColumna, clm4, dataGridViewTextBoxColumn1 });
            dataGridViewCerdo.Location = new Point(51, 67);
            dataGridViewCerdo.Name = "dataGridViewCerdo";
            dataGridViewCerdo.RowTemplate.Height = 25;
            dataGridViewCerdo.Size = new Size(502, 250);
            dataGridViewCerdo.TabIndex = 14;
            dataGridViewCerdo.CellContentClick += dataGridViewCerdo_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo";
            Column2.Name = "Column2";
            // 
            // PrecioColumna
            // 
            PrecioColumna.HeaderText = "Precio";
            PrecioColumna.Name = "PrecioColumna";
            // 
            // clm4
            // 
            clm4.HeaderText = "Raza";
            clm4.Name = "clm4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Precio";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // buttonFactura
            // 
            buttonFactura.Location = new Point(538, 350);
            buttonFactura.Name = "buttonFactura";
            buttonFactura.Size = new Size(86, 49);
            buttonFactura.TabIndex = 13;
            buttonFactura.Text = "Factura";
            buttonFactura.UseVisualStyleBackColor = true;
            buttonFactura.Click += buttonFactura_Click;
            // 
            // textBuscador
            // 
            textBuscador.Location = new Point(327, 37);
            textBuscador.Name = "textBuscador";
            textBuscador.Size = new Size(155, 23);
            textBuscador.TabIndex = 12;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(367, 9);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 11;
            buttonBuscar.Text = "Buscador";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // groupBoxTipoPago
            // 
            groupBoxTipoPago.Controls.Add(radioButtonTarjeteDebito);
            groupBoxTipoPago.Controls.Add(radioButtonMarcadoPago);
            groupBoxTipoPago.Controls.Add(radioButtonTarjetaC);
            groupBoxTipoPago.Location = new Point(32, 319);
            groupBoxTipoPago.Name = "groupBoxTipoPago";
            groupBoxTipoPago.Size = new Size(314, 100);
            groupBoxTipoPago.TabIndex = 10;
            groupBoxTipoPago.TabStop = false;
            groupBoxTipoPago.Text = "Tipo de Pago";
            // 
            // radioButtonTarjeteDebito
            // 
            radioButtonTarjeteDebito.AutoSize = true;
            radioButtonTarjeteDebito.Location = new Point(89, 61);
            radioButtonTarjeteDebito.Name = "radioButtonTarjeteDebito";
            radioButtonTarjeteDebito.Size = new Size(113, 19);
            radioButtonTarjeteDebito.TabIndex = 2;
            radioButtonTarjeteDebito.TabStop = true;
            radioButtonTarjeteDebito.Text = "Tarjeta de Debito";
            radioButtonTarjeteDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarcadoPago
            // 
            radioButtonMarcadoPago.AutoSize = true;
            radioButtonMarcadoPago.Location = new Point(165, 31);
            radioButtonMarcadoPago.Name = "radioButtonMarcadoPago";
            radioButtonMarcadoPago.Size = new Size(102, 19);
            radioButtonMarcadoPago.TabIndex = 1;
            radioButtonMarcadoPago.TabStop = true;
            radioButtonMarcadoPago.Text = "Marcado Pago";
            radioButtonMarcadoPago.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjetaC
            // 
            radioButtonTarjetaC.AutoSize = true;
            radioButtonTarjetaC.Location = new Point(19, 31);
            radioButtonTarjetaC.Name = "radioButtonTarjetaC";
            radioButtonTarjetaC.Size = new Size(117, 19);
            radioButtonTarjetaC.TabIndex = 0;
            radioButtonTarjetaC.TabStop = true;
            radioButtonTarjetaC.Text = "Tarjeta de Credito";
            radioButtonTarjetaC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(207, 19);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 9;
            label3.Text = "Monto disponible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Location = new Point(107, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // button3
            // 
            button3.BackColor = Color.Chocolate;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(433, 390);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Logearte";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Location = new Point(352, 376);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.FromArgb(0, 192, 0);
            buttonComprar.Location = new Point(433, 361);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 5;
            buttonComprar.Text = "Compra";
            buttonComprar.UseVisualStyleBackColor = false;
            buttonComprar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Location = new Point(369, 319);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 4;
            label1.Text = "Agregar producto por Kilos Kg";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.SteelBlue;
            numericUpDown1.Location = new Point(393, 337);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.BackColor = Color.Goldenrod;
            labelDinero.Location = new Point(236, 48);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(38, 15);
            labelDinero.TabIndex = 2;
            labelDinero.Text = "label1";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Goldenrod;
            labelNombre.Location = new Point(107, 48);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(38, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, tipo, precio, raza });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.Location = new Point(51, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(502, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // raza
            // 
            raza.HeaderText = "Raza";
            raza.Name = "raza";
            // 
            // FormVentaDeCarne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 428);
            Controls.Add(groupCerdo);
            Name = "FormVentaDeCarne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FormVentaDeCarne_Load;
            groupCerdo.ResumeLayout(false);
            groupCerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVacuno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCerdo).EndInit();
            groupBoxTipoPago.ResumeLayout(false);
            groupBoxTipoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupCerdo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn raza;
        private Label labelNombre;
        private Label labelDinero;
        private Button buttonComprar;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private GroupBox groupBoxTipoPago;
        private RadioButton radioButtonTarjeteDebito;
        private RadioButton radioButtonMarcadoPago;
        private RadioButton radioButtonTarjetaC;
        private TextBox textBuscador;
        private Button buttonBuscar;
        private Button buttonFactura;
        private DataGridView dataGridViewCerdo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn PrecioColumna;
        private DataGridViewTextBoxColumn clm4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridViewVacuno;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn clm6;
        private DataGridViewTextBoxColumn Column6;
        private Label label4;
        private ComboBox comboBox1;
    }
}