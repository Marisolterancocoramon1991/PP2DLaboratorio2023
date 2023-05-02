namespace PrimerParcial
{
    partial class FormBienvenidaMontoM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenidaMontoM));
            groupBienvenida = new GroupBox();
            labelBienvenido = new Label();
            groupBienvenida.SuspendLayout();
            SuspendLayout();
            // 
            // groupBienvenida
            // 
            groupBienvenida.BackColor = SystemColors.InactiveCaption;
            groupBienvenida.Controls.Add(labelBienvenido);
            groupBienvenida.Location = new Point(95, 28);
            groupBienvenida.Name = "groupBienvenida";
            groupBienvenida.Size = new Size(252, 213);
            groupBienvenida.TabIndex = 0;
            groupBienvenida.TabStop = false;
            groupBienvenida.Text = "grupo_Carniceria";
            // 
            // labelBienvenido
            // 
            labelBienvenido.BackColor = Color.DarkSalmon;
            labelBienvenido.Location = new Point(6, 19);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(240, 141);
            labelBienvenido.TabIndex = 0;
            labelBienvenido.Text = resources.GetString("labelBienvenido.Text");
            // 
            // FormBienvenidaMontoM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 311);
            Controls.Add(groupBienvenida);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Name = "FormBienvenidaMontoM";
            Text = "FormBienvenidaMontoM";
            Load += FormBienvenidaMontoM_Load;
            groupBienvenida.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBienvenida;
        private Label labelBienvenido;
    }
}