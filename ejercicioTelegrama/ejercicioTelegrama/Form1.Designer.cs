namespace ejercicioTelegrama
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
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcularPrecio = new Button();
            label3 = new Label();
            chkOrdinario = new RadioButton();
            chkUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(78, 146);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(652, 147);
            txtTelegrama.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(131, 379);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(115, 23);
            txtPrecio.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 385);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Coste:";
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(572, 339);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(158, 63);
            btnCalcularPrecio.TabIndex = 5;
            btnCalcularPrecio.Text = "CALCULAR";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 104);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "TEXTO:";
            // 
            // chkOrdinario
            // 
            chkOrdinario.AutoSize = true;
            chkOrdinario.Location = new Point(156, 329);
            chkOrdinario.Name = "chkOrdinario";
            chkOrdinario.Size = new Size(80, 19);
            chkOrdinario.TabIndex = 8;
            chkOrdinario.TabStop = true;
            chkOrdinario.Text = "Ordinario?";
            chkOrdinario.UseVisualStyleBackColor = true;
            chkOrdinario.CheckedChanged += chkOrdinario_CheckedChanged;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(78, 329);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(72, 19);
            chkUrgente.TabIndex = 9;
            chkUrgente.TabStop = true;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkUrgente);
            Controls.Add(chkOrdinario);
            Controls.Add(label3);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Button btnCalcularPrecio;
        private Label label3;
        private RadioButton chkOrdinario;
        private RadioButton chkUrgente;
    }
}
