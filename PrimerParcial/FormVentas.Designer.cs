namespace PrimerParcial
{
    partial class FormVentas
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
            button1 = new Button();
            button2 = new Button();
            buttonCarneVacuna = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBoxEleccion = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBoxEleccion.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(484, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 183);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCarneVacuna
            // 
            buttonCarneVacuna.Location = new Point(85, 183);
            buttonCarneVacuna.Name = "buttonCarneVacuna";
            buttonCarneVacuna.Size = new Size(75, 23);
            buttonCarneVacuna.TabIndex = 2;
            buttonCarneVacuna.Text = "Vacuno";
            buttonCarneVacuna.UseVisualStyleBackColor = true;
            buttonCarneVacuna.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vaca;
            pictureBox1.Location = new Point(42, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.gallina;
            pictureBox2.Location = new Point(245, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cerdo;
            pictureBox3.Location = new Point(442, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // groupBoxEleccion
            // 
            groupBoxEleccion.BackColor = Color.IndianRed;
            groupBoxEleccion.Controls.Add(pictureBox1);
            groupBoxEleccion.Controls.Add(buttonCarneVacuna);
            groupBoxEleccion.Controls.Add(pictureBox3);
            groupBoxEleccion.Controls.Add(button2);
            groupBoxEleccion.Controls.Add(pictureBox2);
            groupBoxEleccion.Controls.Add(button1);
            groupBoxEleccion.Location = new Point(-3, 2);
            groupBoxEleccion.Name = "groupBoxEleccion";
            groupBoxEleccion.Size = new Size(632, 275);
            groupBoxEleccion.TabIndex = 6;
            groupBoxEleccion.TabStop = false;
            groupBoxEleccion.Text = "Carniceria_Teran";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 274);
            Controls.Add(groupBoxEleccion);
            Name = "FormVentas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBoxEleccion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button buttonCarneVacuna;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBoxEleccion;
    }
}