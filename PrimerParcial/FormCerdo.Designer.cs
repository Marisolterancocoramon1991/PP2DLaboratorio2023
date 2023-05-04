namespace PrimerParcial
{
    partial class FormCerdo
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
            groupCerdo = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupCerdo
            // 
            groupCerdo.BackColor = Color.FromArgb(255, 128, 128);
            groupCerdo.Controls.Add(label3);
            groupCerdo.Controls.Add(label2);
            groupCerdo.Controls.Add(button3);
            groupCerdo.Controls.Add(button2);
            groupCerdo.Controls.Add(button1);
            groupCerdo.Controls.Add(label1);
            groupCerdo.Controls.Add(numericUpDown1);
            groupCerdo.Controls.Add(labelDinero);
            groupCerdo.Controls.Add(labelNombre);
            groupCerdo.Controls.Add(dataGridView1);
            groupCerdo.Location = new Point(-2, 3);
            groupCerdo.Name = "groupCerdo";
            groupCerdo.Size = new Size(578, 425);
            groupCerdo.TabIndex = 0;
            groupCerdo.TabStop = false;
            groupCerdo.Text = "Carniceria_Teran";
            groupCerdo.Enter += groupCerdo_Enter;
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
            button3.Location = new Point(139, 360);
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
            button2.Location = new Point(14, 360);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(497, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Compra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Location = new Point(369, 357);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 4;
            label1.Text = "Agregar producto por Kilos Kg";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.SteelBlue;
            numericUpDown1.Location = new Point(389, 375);
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, tipo, precio, raza });
            dataGridView1.Location = new Point(107, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 288);
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
            // FormCerdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 428);
            Controls.Add(groupCerdo);
            Name = "FormCerdo";
            Text = "Form2";
            groupCerdo.ResumeLayout(false);
            groupCerdo.PerformLayout();
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
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
    }
}