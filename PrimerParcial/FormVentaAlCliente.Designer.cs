﻿namespace PrimerParcial
{
    partial class FormVentaAlCliente
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
            listBoxClientes = new ListBox();
            labeCliente = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            buttonRegresar = new Button();
            buttonLogearse = new Button();
            labelMostrarSeleccion = new Label();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            labelComPraFacturacion = new Label();
            label8 = new Label();
            labelSaldo1 = new Label();
            labelSaldo2 = new Label();
            labelGastoTotal = new Label();
            groupBoxModoPago = new GroupBox();
            radioButtonTarjeteDebito = new RadioButton();
            radioButtonMarcadoPago = new RadioButton();
            radioButtonTarjetaC = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            dataGridViewVaca = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            dataGridViewCerdo = new DataGridView();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBoxModoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVaca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCerdo).BeginInit();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.ForeColor = Color.FromArgb(0, 64, 64);
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(12, 52);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(408, 64);
            listBoxClientes.TabIndex = 0;
            listBoxClientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // labeCliente
            // 
            labeCliente.AutoSize = true;
            labeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeCliente.ForeColor = Color.Red;
            labeCliente.Location = new Point(32, 7);
            labeCliente.Name = "labeCliente";
            labeCliente.Size = new Size(122, 21);
            labeCliente.TabIndex = 1;
            labeCliente.Text = "Lista de Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 34);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 34);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Saldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 34);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Cuenta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 34);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Direccion";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(446, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(331, 182);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Raza";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Stock";
            Column5.Name = "Column5";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(686, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Agregar Venta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.RosyBrown;
            buttonRegresar.Location = new Point(713, 370);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += button2_Click;
            // 
            // buttonLogearse
            // 
            buttonLogearse.BackColor = Color.FromArgb(255, 128, 0);
            buttonLogearse.ForeColor = Color.Red;
            buttonLogearse.Location = new Point(713, 399);
            buttonLogearse.Name = "buttonLogearse";
            buttonLogearse.Size = new Size(75, 23);
            buttonLogearse.TabIndex = 11;
            buttonLogearse.Text = "Logearse";
            buttonLogearse.UseVisualStyleBackColor = false;
            buttonLogearse.Click += button3_Click;
            // 
            // labelMostrarSeleccion
            // 
            labelMostrarSeleccion.ForeColor = Color.FromArgb(64, 0, 0);
            labelMostrarSeleccion.Location = new Point(313, 219);
            labelMostrarSeleccion.Name = "labelMostrarSeleccion";
            labelMostrarSeleccion.Size = new Size(211, 205);
            labelMostrarSeleccion.TabIndex = 12;
            labelMostrarSeleccion.Text = "Mostrar en texto informacion del cliente ";
            labelMostrarSeleccion.Click += labelMostrarSeleccion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Carnicero;
            pictureBox1.Location = new Point(468, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9 });
            dataGridView2.Location = new Point(5, 157);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(288, 226);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nombre";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Tipo";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Precio Unidad ";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Precio Cantidad";
            Column9.Name = "Column9";
            // 
            // labelComPraFacturacion
            // 
            labelComPraFacturacion.AutoSize = true;
            labelComPraFacturacion.ForeColor = Color.Red;
            labelComPraFacturacion.Location = new Point(17, 133);
            labelComPraFacturacion.Name = "labelComPraFacturacion";
            labelComPraFacturacion.Size = new Size(179, 15);
            labelComPraFacturacion.TabIndex = 15;
            labelComPraFacturacion.Text = "Compra y facturacion del cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(507, 13);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 16;
            label8.Text = "Lista de Productos";
            // 
            // labelSaldo1
            // 
            labelSaldo1.AutoSize = true;
            labelSaldo1.Location = new Point(334, 201);
            labelSaldo1.Name = "labelSaldo1";
            labelSaldo1.Size = new Size(95, 15);
            labelSaldo1.TabIndex = 17;
            labelSaldo1.Text = "Saldo del Cliente";
            // 
            // labelSaldo2
            // 
            labelSaldo2.AutoSize = true;
            labelSaldo2.Location = new Point(166, 396);
            labelSaldo2.Name = "labelSaldo2";
            labelSaldo2.Size = new Size(16, 15);
            labelSaldo2.TabIndex = 18;
            labelSaldo2.Text = "...";
            // 
            // labelGastoTotal
            // 
            labelGastoTotal.AutoSize = true;
            labelGastoTotal.Location = new Point(68, 396);
            labelGastoTotal.Name = "labelGastoTotal";
            labelGastoTotal.Size = new Size(78, 15);
            labelGastoTotal.TabIndex = 19;
            labelGastoTotal.Text = "TOTAL GASTO";
            // 
            // groupBoxModoPago
            // 
            groupBoxModoPago.Controls.Add(radioButtonTarjeteDebito);
            groupBoxModoPago.Controls.Add(radioButtonMarcadoPago);
            groupBoxModoPago.Controls.Add(radioButtonTarjetaC);
            groupBoxModoPago.Location = new Point(507, 222);
            groupBoxModoPago.Name = "groupBoxModoPago";
            groupBoxModoPago.Size = new Size(281, 69);
            groupBoxModoPago.TabIndex = 20;
            groupBoxModoPago.TabStop = false;
            groupBoxModoPago.Text = "Modo de Pago";
            // 
            // radioButtonTarjeteDebito
            // 
            radioButtonTarjeteDebito.AutoSize = true;
            radioButtonTarjeteDebito.Location = new Point(85, 44);
            radioButtonTarjeteDebito.Name = "radioButtonTarjeteDebito";
            radioButtonTarjeteDebito.Size = new Size(97, 19);
            radioButtonTarjeteDebito.TabIndex = 22;
            radioButtonTarjeteDebito.TabStop = true;
            radioButtonTarjeteDebito.Text = "Tarjeta Debito";
            radioButtonTarjeteDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarcadoPago
            // 
            radioButtonMarcadoPago.AutoSize = true;
            radioButtonMarcadoPago.Location = new Point(17, 22);
            radioButtonMarcadoPago.Name = "radioButtonMarcadoPago";
            radioButtonMarcadoPago.Size = new Size(90, 19);
            radioButtonMarcadoPago.TabIndex = 21;
            radioButtonMarcadoPago.TabStop = true;
            radioButtonMarcadoPago.Text = "Mercado PG";
            radioButtonMarcadoPago.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjetaC
            // 
            radioButtonTarjetaC.AutoSize = true;
            radioButtonTarjetaC.Location = new Point(137, 18);
            radioButtonTarjetaC.Name = "radioButtonTarjetaC";
            radioButtonTarjetaC.Size = new Size(117, 19);
            radioButtonTarjetaC.TabIndex = 0;
            radioButtonTarjetaC.TabStop = true;
            radioButtonTarjetaC.Text = "Tarjeta de Credito";
            radioButtonTarjetaC.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(668, 297);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // dataGridViewVaca
            // 
            dataGridViewVaca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVaca.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11, Column12, Column13, Column14 });
            dataGridViewVaca.Location = new Point(446, 34);
            dataGridViewVaca.Name = "dataGridViewVaca";
            dataGridViewVaca.RowTemplate.Height = 25;
            dataGridViewVaca.Size = new Size(331, 182);
            dataGridViewVaca.TabIndex = 24;
            dataGridViewVaca.CellContentClick += dataGridViewVaca_CellContentClick;
            // 
            // Column10
            // 
            Column10.HeaderText = "Nombre";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Tipo";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Precio";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Tipo";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "Cantidad";
            Column14.Name = "Column14";
            // 
            // dataGridViewCerdo
            // 
            dataGridViewCerdo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCerdo.Columns.AddRange(new DataGridViewColumn[] { Column15, Column16, Column17, Column18, Column19 });
            dataGridViewCerdo.Location = new Point(446, 34);
            dataGridViewCerdo.Name = "dataGridViewCerdo";
            dataGridViewCerdo.RowTemplate.Height = 25;
            dataGridViewCerdo.Size = new Size(331, 182);
            dataGridViewCerdo.TabIndex = 25;
            dataGridViewCerdo.CellContentClick += dataGridViewCerdo_CellContentClick;
            // 
            // Column15
            // 
            Column15.HeaderText = "Nombre";
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "Tipo";
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "Precio";
            Column17.Name = "Column17";
            // 
            // Column18
            // 
            Column18.HeaderText = "Tipo";
            Column18.Name = "Column18";
            // 
            // Column19
            // 
            Column19.HeaderText = "Cantidad";
            Column19.Name = "Column19";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ninguna", "Ave", "Cerdo", "Vaca" });
            comboBox1.Location = new Point(644, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormVentaAlCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 433);
            Controls.Add(comboBox1);
            Controls.Add(dataGridViewCerdo);
            Controls.Add(dataGridViewVaca);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBoxModoPago);
            Controls.Add(labelGastoTotal);
            Controls.Add(labelSaldo2);
            Controls.Add(labelSaldo1);
            Controls.Add(label8);
            Controls.Add(labelComPraFacturacion);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMostrarSeleccion);
            Controls.Add(buttonLogearse);
            Controls.Add(buttonRegresar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labeCliente);
            Controls.Add(listBoxClientes);
            Name = "FormVentaAlCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentaAlCliente";
            Load += FormVentaAlCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBoxModoPago.ResumeLayout(false);
            groupBoxModoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVaca).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCerdo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClientes;
        private Label labeCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonRegresar;
        private Button buttonLogearse;
        private Label labelMostrarSeleccion;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Label labelComPraFacturacion;
        private Label label8;
        private Label labelSaldo1;
        private Label labelSaldo2;
        private Label labelGastoTotal;
        private GroupBox groupBoxModoPago;
        private RadioButton radioButtonMarcadoPago;
        private RadioButton radioButtonTarjetaC;
        private RadioButton radioButtonTarjeteDebito;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridViewVaca;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridView dataGridViewCerdo;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private ComboBox comboBox1;
    }
}