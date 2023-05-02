namespace PrimerParcial
{
    partial class FrmLogin
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
            labelPrincipal = new Label();
            labelCorreo = new Label();
            Carniceria = new GroupBox();
            labelInformacionError = new Label();
            pictureMostrar = new PictureBox();
            pictureOcultar = new PictureBox();
            textBoxCorreo = new TextBox();
            textBoxContraseña = new TextBox();
            labelContraseña = new Label();
            buttonIngresar = new Button();
            Usuario = new ListBox();
            Carniceria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOcultar).BeginInit();
            SuspendLayout();
            // 
            // labelPrincipal
            // 
            labelPrincipal.BackColor = SystemColors.HotTrack;
            labelPrincipal.ForeColor = SystemColors.ButtonHighlight;
            labelPrincipal.Location = new Point(84, 19);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(99, 17);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "LOGIN ";
            labelPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCorreo
            // 
            labelCorreo.BackColor = SystemColors.ActiveCaption;
            labelCorreo.FlatStyle = FlatStyle.System;
            labelCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelCorreo.Location = new Point(32, 45);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(102, 16);
            labelCorreo.TabIndex = 1;
            labelCorreo.Text = "Correo Eletrónico ";
            labelCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Carniceria
            // 
            Carniceria.BackColor = SystemColors.InactiveCaption;
            Carniceria.Controls.Add(labelInformacionError);
            Carniceria.Controls.Add(pictureMostrar);
            Carniceria.Controls.Add(pictureOcultar);
            Carniceria.Controls.Add(textBoxCorreo);
            Carniceria.Controls.Add(textBoxContraseña);
            Carniceria.Controls.Add(labelContraseña);
            Carniceria.Controls.Add(buttonIngresar);
            Carniceria.Controls.Add(Usuario);
            Carniceria.Controls.Add(labelPrincipal);
            Carniceria.Controls.Add(labelCorreo);
            Carniceria.Location = new Point(95, 28);
            Carniceria.Name = "Carniceria";
            Carniceria.Size = new Size(252, 213);
            Carniceria.TabIndex = 2;
            Carniceria.TabStop = false;
            Carniceria.Text = "grupoCarniceria";
            // 
            // labelInformacionError
            // 
            labelInformacionError.BackColor = SystemColors.ActiveCaption;
            labelInformacionError.Cursor = Cursors.AppStarting;
            labelInformacionError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelInformacionError.Location = new Point(31, 155);
            labelInformacionError.Name = "labelInformacionError";
            labelInformacionError.Size = new Size(200, 15);
            labelInformacionError.TabIndex = 9;
            labelInformacionError.Text = "...";
            // 
            // pictureMostrar
            // 
            pictureMostrar.Image = Properties.Resources.OjoAbiertoContraseña;
            pictureMostrar.Location = new Point(200, 115);
            pictureMostrar.Name = "pictureMostrar";
            pictureMostrar.Size = new Size(37, 25);
            pictureMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMostrar.TabIndex = 8;
            pictureMostrar.TabStop = false;
            pictureMostrar.Click += pictureBox2_Click;
            // 
            // pictureOcultar
            // 
            pictureOcultar.Image = Properties.Resources.OjoContraseña;
            pictureOcultar.Location = new Point(200, 115);
            pictureOcultar.Name = "pictureOcultar";
            pictureOcultar.Size = new Size(37, 25);
            pictureOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOcultar.TabIndex = 7;
            pictureOcultar.TabStop = false;
            pictureOcultar.Click += pictureBox1_Click;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Cursor = Cursors.IBeam;
            textBoxCorreo.Location = new Point(34, 64);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(149, 23);
            textBoxCorreo.TabIndex = 6;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Cursor = Cursors.IBeam;
            textBoxContraseña.Location = new Point(31, 117);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(151, 23);
            textBoxContraseña.TabIndex = 5;
            textBoxContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // labelContraseña
            // 
            labelContraseña.BackColor = SystemColors.ActiveCaption;
            labelContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelContraseña.Location = new Point(32, 96);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(80, 18);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña";
            labelContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.Orange;
            buttonIngresar.Cursor = Cursors.Hand;
            buttonIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonIngresar.ForeColor = Color.FromArgb(192, 0, 0);
            buttonIngresar.Location = new Point(171, 173);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(75, 23);
            buttonIngresar.TabIndex = 3;
            buttonIngresar.Text = "Ingresar...";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // Usuario
            // 
            Usuario.BackColor = SystemColors.ActiveCaption;
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Cursor = Cursors.Hand;
            Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Usuario.FormattingEnabled = true;
            Usuario.ItemHeight = 15;
            Usuario.Items.AddRange(new object[] { "Trabajador", "Clientes" });
            Usuario.Location = new Point(6, 173);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(77, 30);
            Usuario.TabIndex = 2;
            Usuario.SelectedIndexChanged += Usuario_SelectedIndexChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 311);
            Controls.Add(Carniceria);
            Name = "FrmLogin";
            Text = "Form1";
            TopMost = true;
            Carniceria.ResumeLayout(false);
            Carniceria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOcultar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelPrincipal;
        private Label labelCorreo;
        private GroupBox Carniceria;
        private ListBox Usuario;
        private Button buttonIngresar;
        private Label labelContraseña;
        private TextBox textBoxCorreo;
        private TextBox textBoxContraseña;
        private PictureBox pictureOcultar;
        private PictureBox pictureMostrar;
        private Label labelInformacionError;
    }
}