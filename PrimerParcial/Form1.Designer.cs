namespace PrimerParcial
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            Usuario = new ListBox();
            pictureOcultar = new PictureBox();
            pictureMostrar = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMostrar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(84, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "LOGIN ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(32, 45);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 1;
            label2.Text = "Correo Eletrónico ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(pictureMostrar);
            groupBox1.Controls.Add(pictureOcultar);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(95, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 213);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(34, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(31, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(171, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ingresar...";
            button1.UseVisualStyleBackColor = false;
            // 
            // Usuario
            // 
            Usuario.BackColor = SystemColors.ActiveCaption;
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Cursor = Cursors.Hand;
            Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Usuario.FormattingEnabled = true;
            Usuario.ItemHeight = 15;
            Usuario.Items.AddRange(new object[] { "Vendedor ", "Cliente" });
            Usuario.Location = new Point(6, 173);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(77, 30);
            Usuario.TabIndex = 2;
            Usuario.SelectedIndexChanged += Usuario_SelectedIndexChanged;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 311);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ListBox Usuario;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureOcultar;
        private PictureBox pictureMostrar;
    }
}