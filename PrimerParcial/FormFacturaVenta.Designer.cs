namespace PrimerParcial
{
    partial class FormFacturaVenta
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupCarniceria = new GroupBox();
            button1 = new Button();
            labelTotal = new Label();
            ButtonRegresar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            labelID = new Label();
            labelFechaActual = new Label();
            labelNombre = new Label();
            labelDirecccion = new Label();
            groupCarniceria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupCarniceria
            // 
            groupCarniceria.BackColor = SystemColors.ScrollBar;
            groupCarniceria.Controls.Add(button1);
            groupCarniceria.Controls.Add(labelTotal);
            groupCarniceria.Controls.Add(ButtonRegresar);
            groupCarniceria.Controls.Add(dataGridView1);
            groupCarniceria.Controls.Add(labelID);
            groupCarniceria.Controls.Add(labelFechaActual);
            groupCarniceria.Controls.Add(labelNombre);
            groupCarniceria.Controls.Add(labelDirecccion);
            groupCarniceria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupCarniceria.Location = new Point(-7, 0);
            groupCarniceria.Name = "groupCarniceria";
            groupCarniceria.Size = new Size(596, 456);
            groupCarniceria.TabIndex = 0;
            groupCarniceria.TabStop = false;
            groupCarniceria.Text = "Carniceria_Teran";
            //groupCarniceria.Enter += groupCarniceria_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(119, 410);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 7;
            button1.Text = "Logearte";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Cursor = Cursors.Hand;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(288, 386);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(52, 21);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "label1";
            labelTotal.Click += labelTotal_Click;
            // 
            // ButtonRegresar
            // 
            ButtonRegresar.BackColor = SystemColors.Info;
            ButtonRegresar.Cursor = Cursors.Hand;
            ButtonRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRegresar.Location = new Point(19, 410);
            ButtonRegresar.Name = "ButtonRegresar";
            ButtonRegresar.Size = new Size(74, 28);
            ButtonRegresar.TabIndex = 5;
            ButtonRegresar.Text = "Regresar";
            ButtonRegresar.UseVisualStyleBackColor = false;
            ButtonRegresar.Click += ButtonRegresar_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.1F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.Location = new Point(30, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(560, 241);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio Por Unidad";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Unidades";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio Total";
            Column4.Name = "Column4";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(6, 91);
            labelID.Name = "labelID";
            labelID.Size = new Size(45, 19);
            labelID.TabIndex = 3;
            labelID.Text = "label4";
            // 
            // labelFechaActual
            // 
            labelFechaActual.AutoSize = true;
            labelFechaActual.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFechaActual.Location = new Point(6, 120);
            labelFechaActual.Name = "labelFechaActual";
            labelFechaActual.Size = new Size(45, 19);
            labelFechaActual.TabIndex = 2;
            labelFechaActual.Text = "label3";
            labelFechaActual.Click += label_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(6, 59);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(45, 19);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "label2";
            // 
            // labelDirecccion
            // 
            labelDirecccion.AutoSize = true;
            labelDirecccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDirecccion.Location = new Point(6, 30);
            labelDirecccion.Name = "labelDirecccion";
            labelDirecccion.Size = new Size(45, 19);
            labelDirecccion.TabIndex = 0;
            labelDirecccion.Text = "label1";
            labelDirecccion.Click += labelDirecccion_Click;
            // 
            // FormFacturaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(groupCarniceria);
            Name = "FormFacturaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFacturaVenta";
            groupCarniceria.ResumeLayout(false);
            groupCarniceria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupCarniceria;
        private Label labelID;
        private Label labelFechaActual;
        private Label labelNombre;
        private Label labelDirecccion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label labelTotal;
        private Button ButtonRegresar;
        private Button button1;
    }
}