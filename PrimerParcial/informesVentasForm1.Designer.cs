namespace PrimerParcial
{
    partial class informesVentasForm1
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
            btnVentasJASON = new Button();
            btnVentasXML = new Button();
            btnCSVDeVentas = new Button();
            textBox1 = new TextBox();
            buttonRegresa = new Button();
            SuspendLayout();
            // 
            // btnVentasJASON
            // 
            btnVentasJASON.Image = Properties.Resources.JSONNuevo;
            btnVentasJASON.Location = new Point(51, 57);
            btnVentasJASON.Name = "btnVentasJASON";
            btnVentasJASON.Size = new Size(101, 103);
            btnVentasJASON.TabIndex = 0;
            btnVentasJASON.UseVisualStyleBackColor = true;
            btnVentasJASON.Click += btnVentasJASON_Click;
            // 
            // btnVentasXML
            // 
            btnVentasXML.Image = Properties.Resources.XMLNuevo;
            btnVentasXML.Location = new Point(331, 57);
            btnVentasXML.Name = "btnVentasXML";
            btnVentasXML.Size = new Size(101, 103);
            btnVentasXML.TabIndex = 1;
            btnVentasXML.UseVisualStyleBackColor = true;
            btnVentasXML.Click += btnVentasXML_Click;
            // 
            // btnCSVDeVentas
            // 
            btnCSVDeVentas.Image = Properties.Resources.CSVIMAGEN2;
            btnCSVDeVentas.Location = new Point(197, 57);
            btnCSVDeVentas.Name = "btnCSVDeVentas";
            btnCSVDeVentas.Size = new Size(101, 103);
            btnCSVDeVentas.TabIndex = 2;
            btnCSVDeVentas.UseVisualStyleBackColor = true;
            btnCSVDeVentas.Click += btnCSVDeVentas_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuHighlight;
            textBox1.Cursor = Cursors.AppStarting;
            textBox1.Location = new Point(38, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "imprimir la lista de venta en estos archivos con sus respectivos formatos";
            // 
            // buttonRegresa
            // 
            buttonRegresa.BackColor = Color.Lime;
            buttonRegresa.Location = new Point(331, 181);
            buttonRegresa.Name = "buttonRegresa";
            buttonRegresa.Size = new Size(115, 22);
            buttonRegresa.TabIndex = 4;
            buttonRegresa.Text = "Regresar";
            buttonRegresa.UseVisualStyleBackColor = false;
            buttonRegresa.Click += buttonRegresa_Click;
            // 
            // informesVentasForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(470, 228);
            Controls.Add(buttonRegresa);
            Controls.Add(textBox1);
            Controls.Add(btnCSVDeVentas);
            Controls.Add(btnVentasXML);
            Controls.Add(btnVentasJASON);
            Name = "informesVentasForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "informesVentasForm1";
            Load += informesVentasForm1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVentasJASON;
        private Button btnVentasXML;
        private Button btnCSVDeVentas;
        private TextBox textBox1;
        private Button buttonRegresa;
    }
}