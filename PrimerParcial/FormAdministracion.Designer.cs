namespace PrimerParcial
{
    partial class FormAdministracion
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
            buttonCrearProducto = new Button();
            buttonEditar = new Button();
            buttonHeladera = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonLogearte = new Button();
            pictureBox4 = new PictureBox();
            buttonVender = new Button();
            labelMontoVentasTotales = new Label();
            button1 = new Button();
            buttonArchivo = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonCrearProducto
            // 
            buttonCrearProducto.BackColor = Color.OrangeRed;
            buttonCrearProducto.Location = new Point(46, 280);
            buttonCrearProducto.Name = "buttonCrearProducto";
            buttonCrearProducto.Size = new Size(128, 23);
            buttonCrearProducto.TabIndex = 0;
            buttonCrearProducto.Text = "Crear Producto";
            buttonCrearProducto.UseVisualStyleBackColor = false;
            buttonCrearProducto.Click += buttonCrearProducto_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(255, 128, 128);
            buttonEditar.Location = new Point(255, 280);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(128, 23);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar Producto";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonHeladera
            // 
            buttonHeladera.BackColor = Color.FromArgb(0, 192, 192);
            buttonHeladera.Location = new Point(471, 280);
            buttonHeladera.Name = "buttonHeladera";
            buttonHeladera.Size = new Size(128, 23);
            buttonHeladera.TabIndex = 2;
            buttonHeladera.Text = "Heladera";
            buttonHeladera.UseVisualStyleBackColor = false;
            buttonHeladera.Click += buttonHeladera_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NuevoProducto;
            pictureBox1.Location = new Point(33, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.EditarProducto;
            pictureBox2.Location = new Point(238, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Heladera;
            pictureBox3.Location = new Point(447, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // buttonLogearte
            // 
            buttonLogearte.BackColor = Color.LightPink;
            buttonLogearte.Location = new Point(732, 320);
            buttonLogearte.Name = "buttonLogearte";
            buttonLogearte.Size = new Size(135, 41);
            buttonLogearte.TabIndex = 6;
            buttonLogearte.Text = "Logearte";
            buttonLogearte.UseVisualStyleBackColor = false;
            buttonLogearte.Click += buttonLogearte_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Carnicero;
            pictureBox4.Location = new Point(656, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(175, 157);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // buttonVender
            // 
            buttonVender.BackColor = Color.Lime;
            buttonVender.Location = new Point(690, 280);
            buttonVender.Name = "buttonVender";
            buttonVender.Size = new Size(128, 23);
            buttonVender.TabIndex = 8;
            buttonVender.Text = "Vender";
            buttonVender.UseVisualStyleBackColor = false;
            buttonVender.Click += buttonVender_Click;
            // 
            // labelMontoVentasTotales
            // 
            labelMontoVentasTotales.AutoSize = true;
            labelMontoVentasTotales.Location = new Point(204, 320);
            labelMontoVentasTotales.Name = "labelMontoVentasTotales";
            labelMontoVentasTotales.Size = new Size(170, 15);
            labelMontoVentasTotales.TabIndex = 9;
            labelMontoVentasTotales.Text = "Click para ver las ventas totales";
            labelMontoVentasTotales.Click += labelMontoVentasTotales_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.usuariosN1;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(584, 314);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 10;
            button1.Text = "Abm Usuarios";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonArchivo
            // 
            buttonArchivo.Image = Properties.Resources.Archivo;
            buttonArchivo.Location = new Point(428, 312);
            buttonArchivo.Name = "buttonArchivo";
            buttonArchivo.Size = new Size(99, 40);
            buttonArchivo.TabIndex = 11;
            buttonArchivo.UseVisualStyleBackColor = true;
            buttonArchivo.Click += buttonArchivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Location = new Point(288, 49);
            label1.Name = "label1";
            label1.Size = new Size(283, 15);
            label1.TabIndex = 12;
            label1.Text = "Haz Click aqui y sabras si tu sueldo es mayor a 10000";
            label1.Click += label1_Click;
            // 
            // FormAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(868, 362);
            Controls.Add(label1);
            Controls.Add(buttonArchivo);
            Controls.Add(button1);
            Controls.Add(labelMontoVentasTotales);
            Controls.Add(buttonVender);
            Controls.Add(pictureBox4);
            Controls.Add(buttonLogearte);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonHeladera);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCrearProducto);
            Name = "FormAdministracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdministracion";
            Load += FormAdministracion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCrearProducto;
        private Button buttonEditar;
        private Button buttonHeladera;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonLogearte;
        private PictureBox pictureBox4;
        private Button buttonVender;
        private Label labelMontoVentasTotales;
        private Button button1;
        private Button buttonArchivo;
        private Label label1;
    }
}