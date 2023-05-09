namespace PrimerParcial
{
    partial class FormHeladera
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
            pictureBoxNevera = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonBuscador = new Button();
            buttonLogearse = new Button();
            buttonRegresar = new Button();
            textBoxBuscador = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNevera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxNevera
            // 
            pictureBoxNevera.Image = Properties.Resources.Heladera;
            pictureBoxNevera.Location = new Point(23, 182);
            pictureBoxNevera.Name = "pictureBoxNevera";
            pictureBoxNevera.Size = new Size(173, 126);
            pictureBoxNevera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNevera.TabIndex = 0;
            pictureBoxNevera.TabStop = false;
            pictureBoxNevera.MouseHover += pictureBoxNevera_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(23, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(492, 150);
            dataGridView1.TabIndex = 1;
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
            Column5.HeaderText = "Cantidad";
            Column5.Name = "Column5";
            // 
            // buttonBuscador
            // 
            buttonBuscador.Cursor = Cursors.Hand;
            buttonBuscador.Location = new Point(261, 240);
            buttonBuscador.Name = "buttonBuscador";
            buttonBuscador.Size = new Size(75, 23);
            buttonBuscador.TabIndex = 2;
            buttonBuscador.Text = "Buscador";
            buttonBuscador.UseVisualStyleBackColor = true;
            buttonBuscador.Click += buttonBuscador_Click;
            // 
            // buttonLogearse
            // 
            buttonLogearse.BackColor = Color.Goldenrod;
            buttonLogearse.Cursor = Cursors.Hand;
            buttonLogearse.Location = new Point(416, 291);
            buttonLogearse.Name = "buttonLogearse";
            buttonLogearse.Size = new Size(112, 23);
            buttonLogearse.TabIndex = 3;
            buttonLogearse.Text = "Logearse";
            buttonLogearse.UseVisualStyleBackColor = false;
            buttonLogearse.Click += buttonLogearse_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.PaleGreen;
            buttonRegresar.Cursor = Cursors.Hand;
            buttonRegresar.Location = new Point(398, 252);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(117, 23);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "buttonRegresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.Cursor = Cursors.IBeam;
            textBoxBuscador.Location = new Point(202, 211);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(194, 23);
            textBoxBuscador.TabIndex = 5;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(548, 339);
            Controls.Add(textBoxBuscador);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonLogearse);
            Controls.Add(buttonBuscador);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxNevera);
            Name = "FormHeladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heladera";
            Load += FormHeladera_Load;
            MouseHover += FormHeladera_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pictureBoxNevera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxNevera;
        private DataGridView dataGridView1;
        private Button buttonBuscador;
        private Button buttonLogearse;
        private Button buttonRegresar;
        private TextBox textBoxBuscador;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}