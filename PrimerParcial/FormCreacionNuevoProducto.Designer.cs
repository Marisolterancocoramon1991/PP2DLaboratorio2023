﻿namespace PrimerParcial
{
    partial class FormCreacionNuevoProducto
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
            comboBox1 = new ComboBox();
            groupBoxAve = new GroupBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            labelRazaCerdo = new Label();
            comboBoxTipoAve = new ComboBox();
            labelTipoAve = new Label();
            groupBoxCarneVacuno = new GroupBox();
            comboBoxCategoria = new ComboBox();
            comboBoxRVacuno = new ComboBox();
            labelCategoria = new Label();
            labelRazasVaca = new Label();
            groupBoxCarneCerdo = new GroupBox();
            comboBoxRCerdo = new ComboBox();
            labelRCerdo = new Label();
            buttonLogearse = new Button();
            buttonRegresar = new Button();
            labelNombre = new Label();
            labelTipo = new Label();
            labelPrecio = new Label();
            labelCantidadInventario = new Label();
            textBoxNombre = new TextBox();
            textBoxTipoCarne = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxUnidades = new TextBox();
            buttonCrearProducto = new Button();
            pictureBox1 = new PictureBox();
            groupBoxAve.SuspendLayout();
            groupBoxCarneVacuno.SuspendLayout();
            groupBoxCarneCerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de Producto,", "Ave,", "Cerdo,", "Vacuno" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBoxAve
            // 
            groupBoxAve.Controls.Add(comboBox2);
            groupBoxAve.Controls.Add(label2);
            groupBoxAve.Controls.Add(label1);
            groupBoxAve.Controls.Add(labelRazaCerdo);
            groupBoxAve.Controls.Add(comboBoxTipoAve);
            groupBoxAve.Controls.Add(labelTipoAve);
            groupBoxAve.Location = new Point(215, 23);
            groupBoxAve.Name = "groupBoxAve";
            groupBoxAve.Size = new Size(281, 187);
            groupBoxAve.TabIndex = 1;
            groupBoxAve.TabStop = false;
            groupBoxAve.Text = "Producto Ave";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "label1";
            // 
            // labelRazaCerdo
            // 
            labelRazaCerdo.AutoSize = true;
            labelRazaCerdo.Location = new Point(322, 61);
            labelRazaCerdo.Name = "labelRazaCerdo";
            labelRazaCerdo.Size = new Size(63, 15);
            labelRazaCerdo.TabIndex = 16;
            labelRazaCerdo.Text = "RazaCerdo";
            // 
            // comboBoxTipoAve
            // 
            comboBoxTipoAve.FormattingEnabled = true;
            comboBoxTipoAve.Location = new Point(19, 100);
            comboBoxTipoAve.Name = "comboBoxTipoAve";
            comboBoxTipoAve.Size = new Size(229, 23);
            comboBoxTipoAve.TabIndex = 15;
            // 
            // labelTipoAve
            // 
            labelTipoAve.AutoSize = true;
            labelTipoAve.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoAve.Location = new Point(19, 59);
            labelTipoAve.Name = "labelTipoAve";
            labelTipoAve.Size = new Size(158, 21);
            labelTipoAve.TabIndex = 14;
            labelTipoAve.Text = "Tipo de Producto Ave";
            // 
            // groupBoxCarneVacuno
            // 
            groupBoxCarneVacuno.Controls.Add(comboBoxCategoria);
            groupBoxCarneVacuno.Controls.Add(comboBoxRVacuno);
            groupBoxCarneVacuno.Controls.Add(labelCategoria);
            groupBoxCarneVacuno.Controls.Add(labelRazasVaca);
            groupBoxCarneVacuno.Location = new Point(215, 23);
            groupBoxCarneVacuno.Name = "groupBoxCarneVacuno";
            groupBoxCarneVacuno.Size = new Size(287, 203);
            groupBoxCarneVacuno.TabIndex = 2;
            groupBoxCarneVacuno.TabStop = false;
            groupBoxCarneVacuno.Text = "Producto Carne Vacuno";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "novillos,", "vaca,", "ternero,", "toro" });
            comboBoxCategoria.Location = new Point(66, 92);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 23);
            comboBoxCategoria.TabIndex = 3;
            // 
            // comboBoxRVacuno
            // 
            comboBoxRVacuno.FormattingEnabled = true;
            comboBoxRVacuno.Items.AddRange(new object[] { "Belga,", "Brangus,", "Braford,", "Pardo" });
            comboBoxRVacuno.Location = new Point(66, 37);
            comboBoxRVacuno.Name = "comboBoxRVacuno";
            comboBoxRVacuno.Size = new Size(121, 23);
            comboBoxRVacuno.TabIndex = 2;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(34, 74);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 1;
            labelCategoria.Text = "Categoria";
            // 
            // labelRazasVaca
            // 
            labelRazasVaca.AutoSize = true;
            labelRazasVaca.Location = new Point(34, 19);
            labelRazasVaca.Name = "labelRazasVaca";
            labelRazasVaca.Size = new Size(92, 15);
            labelRazasVaca.TabIndex = 0;
            labelRazasVaca.Text = "Raza del Vacuno";
            // 
            // groupBoxCarneCerdo
            // 
            groupBoxCarneCerdo.Controls.Add(comboBoxRCerdo);
            groupBoxCarneCerdo.Controls.Add(labelRCerdo);
            groupBoxCarneCerdo.Location = new Point(215, 23);
            groupBoxCarneCerdo.Name = "groupBoxCarneCerdo";
            groupBoxCarneCerdo.Size = new Size(281, 196);
            groupBoxCarneCerdo.TabIndex = 0;
            groupBoxCarneCerdo.TabStop = false;
            groupBoxCarneCerdo.Text = "Carne Cerdo";
            // 
            // comboBoxRCerdo
            // 
            comboBoxRCerdo.FormattingEnabled = true;
            comboBoxRCerdo.Location = new Point(30, 79);
            comboBoxRCerdo.Name = "comboBoxRCerdo";
            comboBoxRCerdo.Size = new Size(121, 23);
            comboBoxRCerdo.TabIndex = 1;
            // 
            // labelRCerdo
            // 
            labelRCerdo.AutoSize = true;
            labelRCerdo.Location = new Point(30, 59);
            labelRCerdo.Name = "labelRCerdo";
            labelRCerdo.Size = new Size(85, 15);
            labelRCerdo.TabIndex = 0;
            labelRCerdo.Text = "Raza del Cerdo";
            // 
            // buttonLogearse
            // 
            buttonLogearse.BackColor = Color.FromArgb(128, 255, 255);
            buttonLogearse.Location = new Point(421, 250);
            buttonLogearse.Name = "buttonLogearse";
            buttonLogearse.Size = new Size(75, 23);
            buttonLogearse.TabIndex = 3;
            buttonLogearse.Text = "logearse";
            buttonLogearse.UseVisualStyleBackColor = false;
            buttonLogearse.Click += button1_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Lime;
            buttonRegresar.Location = new Point(421, 279);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.TabStop = false;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += button2_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(12, 38);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(12, 82);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(80, 15);
            labelTipo.TabIndex = 6;
            labelTipo.Text = "Tipo de Carne";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(12, 126);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 7;
            labelPrecio.Text = "Precio";
            // 
            // labelCantidadInventario
            // 
            labelCantidadInventario.AutoSize = true;
            labelCantidadInventario.Location = new Point(12, 170);
            labelCantidadInventario.Name = "labelCantidadInventario";
            labelCantidadInventario.Size = new Size(133, 15);
            labelCantidadInventario.TabIndex = 8;
            labelCantidadInventario.Text = "unidades por Kg u otros";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(12, 56);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(175, 23);
            textBoxNombre.TabIndex = 9;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxTipoCarne
            // 
            textBoxTipoCarne.Location = new Point(12, 100);
            textBoxTipoCarne.Name = "textBoxTipoCarne";
            textBoxTipoCarne.Size = new Size(175, 23);
            textBoxTipoCarne.TabIndex = 10;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(12, 144);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(175, 23);
            textBoxPrecio.TabIndex = 11;
            // 
            // textBoxUnidades
            // 
            textBoxUnidades.Location = new Point(12, 188);
            textBoxUnidades.Name = "textBoxUnidades";
            textBoxUnidades.Size = new Size(175, 23);
            textBoxUnidades.TabIndex = 12;
            // 
            // buttonCrearProducto
            // 
            buttonCrearProducto.BackColor = Color.FromArgb(255, 255, 128);
            buttonCrearProducto.Location = new Point(396, 308);
            buttonCrearProducto.Name = "buttonCrearProducto";
            buttonCrearProducto.Size = new Size(128, 23);
            buttonCrearProducto.TabIndex = 13;
            buttonCrearProducto.Text = "Crear Producto";
            buttonCrearProducto.UseVisualStyleBackColor = false;
            buttonCrearProducto.Click += buttonCrearProducto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NuevoProducto;
            pictureBox1.Location = new Point(32, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormCreacionNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(536, 343);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCrearProducto);
            Controls.Add(textBoxUnidades);
            Controls.Add(textBoxPrecio);
            Controls.Add(groupBoxCarneVacuno);
            Controls.Add(textBoxTipoCarne);
            Controls.Add(textBoxNombre);
            Controls.Add(labelCantidadInventario);
            Controls.Add(labelPrecio);
            Controls.Add(groupBoxCarneCerdo);
            Controls.Add(labelTipo);
            Controls.Add(labelNombre);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonLogearse);
            Controls.Add(groupBoxAve);
            Controls.Add(comboBox1);
            Name = "FormCreacionNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreacionNuevoProducto";
            Load += FormCreacionNuevoProducto_Load;
            groupBoxAve.ResumeLayout(false);
            groupBoxAve.PerformLayout();
            groupBoxCarneVacuno.ResumeLayout(false);
            groupBoxCarneVacuno.PerformLayout();
            groupBoxCarneCerdo.ResumeLayout(false);
            groupBoxCarneCerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBoxAve;
        protected GroupBox groupBoxCarneVacuno;
        private GroupBox groupBoxCarneCerdo;
        private Button buttonLogearse;
        private Button buttonRegresar;
        private Label labelNombre;
        private Label labelTipo;
        private Label labelPrecio;
        private Label labelCantidadInventario;
        private TextBox textBoxNombre;
        private TextBox textBoxTipoCarne;
        private TextBox textBoxPrecio;
        private TextBox textBoxUnidades;
        private ComboBox comboBoxTipoAve;
        private Label labelTipoAve;
        private Label labelCategoria;
        private Label labelRazasVaca;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxRVacuno;
        private Label labelRazaCerdo;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRCerdo;
        private Label labelRCerdo;
        private Button buttonCrearProducto;
        private PictureBox pictureBox1;
    }
}