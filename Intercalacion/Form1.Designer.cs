namespace Intercalacion
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
            lblIntercalacion = new Label();
            btnIntercalar = new Button();
            txtArchivo1 = new TextBox();
            txtArchivo2 = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblIntercalacion
            // 
            lblIntercalacion.AutoSize = true;
            lblIntercalacion.Font = new Font("Arial", 24F);
            lblIntercalacion.Location = new Point(12, 9);
            lblIntercalacion.Name = "lblIntercalacion";
            lblIntercalacion.Size = new Size(194, 36);
            lblIntercalacion.TabIndex = 0;
            lblIntercalacion.Text = "Intercalacion";
            // 
            // btnIntercalar
            // 
            btnIntercalar.Font = new Font("Segoe UI", 14F);
            btnIntercalar.Location = new Point(28, 118);
            btnIntercalar.Name = "btnIntercalar";
            btnIntercalar.Size = new Size(154, 40);
            btnIntercalar.TabIndex = 1;
            btnIntercalar.Text = "Intercalar";
            btnIntercalar.UseVisualStyleBackColor = true;
            btnIntercalar.Click += btnIntercalar_Click;
            // 
            // txtArchivo1
            // 
            txtArchivo1.Location = new Point(212, 103);
            txtArchivo1.Name = "txtArchivo1";
            txtArchivo1.Size = new Size(210, 23);
            txtArchivo1.TabIndex = 2;
            // 
            // txtArchivo2
            // 
            txtArchivo2.Location = new Point(212, 180);
            txtArchivo2.Name = "txtArchivo2";
            txtArchivo2.Size = new Size(210, 23);
            txtArchivo2.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.ButtonHighlight;
            txtResultado.Location = new Point(466, 152);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(210, 23);
            txtResultado.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(212, 75);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Archivo 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(212, 152);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 6;
            label2.Text = "Archivo 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(466, 119);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 7;
            label3.Text = "Archivo resultante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtArchivo2);
            Controls.Add(txtArchivo1);
            Controls.Add(btnIntercalar);
            Controls.Add(lblIntercalacion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntercalacion;
        private Button btnIntercalar;
        private TextBox txtArchivo1;
        private TextBox txtArchivo2;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
