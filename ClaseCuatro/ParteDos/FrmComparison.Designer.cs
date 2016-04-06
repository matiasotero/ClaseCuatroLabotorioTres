namespace ClaseCuatro
{
    partial class Comparison
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
            this.lstListado = new System.Windows.Forms.ListBox();
            this.rdoAscendente = new System.Windows.Forms.RadioButton();
            this.rdoDescendente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(28, 12);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(227, 160);
            this.lstListado.TabIndex = 0;
            // 
            // rdoAscendente
            // 
            this.rdoAscendente.AutoSize = true;
            this.rdoAscendente.Location = new System.Drawing.Point(167, 205);
            this.rdoAscendente.Name = "rdoAscendente";
            this.rdoAscendente.Size = new System.Drawing.Size(88, 17);
            this.rdoAscendente.TabIndex = 1;
            this.rdoAscendente.TabStop = true;
            this.rdoAscendente.Text = "Ascendente+";
            this.rdoAscendente.UseVisualStyleBackColor = true;
            this.rdoAscendente.CheckedChanged += new System.EventHandler(this.rdoAscendente_CheckedChanged);
            // 
            // rdoDescendente
            // 
            this.rdoDescendente.AutoSize = true;
            this.rdoDescendente.Location = new System.Drawing.Point(167, 229);
            this.rdoDescendente.Name = "rdoDescendente";
            this.rdoDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdoDescendente.TabIndex = 2;
            this.rdoDescendente.TabStop = true;
            this.rdoDescendente.Text = "Descendente";
            this.rdoDescendente.UseVisualStyleBackColor = true;
            this.rdoDescendente.CheckedChanged += new System.EventHandler(this.rdoDescendente_CheckedChanged);
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rdoDescendente);
            this.Controls.Add(this.rdoAscendente);
            this.Controls.Add(this.lstListado);
            this.Name = "Comparison";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.RadioButton rdoAscendente;
        private System.Windows.Forms.RadioButton rdoDescendente;
    }
}

