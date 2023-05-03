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
            labelNombre = new Label();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            raza = new DataGridViewTextBoxColumn();
            labelDinero = new Label();
            groupCerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupCerdo
            // 
            groupCerdo.BackColor = Color.FromArgb(255, 128, 128);
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
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Goldenrod;
            labelNombre.Location = new Point(73, 31);
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
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.BackColor = Color.Goldenrod;
            labelDinero.Location = new Point(197, 31);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(38, 15);
            labelDinero.TabIndex = 2;
            labelDinero.Text = "label1";
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
    }
}