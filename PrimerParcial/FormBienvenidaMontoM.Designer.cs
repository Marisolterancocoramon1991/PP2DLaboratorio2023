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
            button1 = new Button();
            textBoxAgregarMonto = new TextBox();
            label1 = new Label();
            labelBienvenido = new Label();
            groupBienvenida.SuspendLayout();
            SuspendLayout();
            // 
            // groupBienvenida
            // 
            groupBienvenida.BackColor = SystemColors.InactiveCaption;
            groupBienvenida.Controls.Add(button1);
            groupBienvenida.Controls.Add(textBoxAgregarMonto);
            groupBienvenida.Controls.Add(label1);
            groupBienvenida.Controls.Add(labelBienvenido);
            groupBienvenida.Location = new Point(-1, 1);
            groupBienvenida.Name = "groupBienvenida";
            groupBienvenida.Size = new Size(374, 231);
            groupBienvenida.TabIndex = 0;
            groupBienvenida.TabStop = false;
            groupBienvenida.Text = "grupo_Carniceria";
            groupBienvenida.Enter += groupBienvenida_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(222, 197);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 3;
            button1.Text = "agregar saldo ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxAgregarMonto
            // 
            textBoxAgregarMonto.Location = new Point(222, 168);
            textBoxAgregarMonto.Name = "textBoxAgregarMonto";
            textBoxAgregarMonto.Size = new Size(100, 23);
            textBoxAgregarMonto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 171);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir monto a pagar";
            // 
            // labelBienvenido
            // 
            labelBienvenido.BackColor = Color.DarkSalmon;
            labelBienvenido.Location = new Point(6, 19);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(353, 146);
            labelBienvenido.TabIndex = 0;
            labelBienvenido.Text = resources.GetString("labelBienvenido.Text");
            // 
            // FormBienvenidaMontoM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 230);
            Controls.Add(groupBienvenida);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Name = "FormBienvenidaMontoM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBienvenidaMontoM";
            Load += FormBienvenidaMontoM_Load;
            groupBienvenida.ResumeLayout(false);
            groupBienvenida.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBienvenida;
        private Label labelBienvenido;
        private Label label1;
        private Button button1;
        private TextBox textBoxAgregarMonto;
    }
}