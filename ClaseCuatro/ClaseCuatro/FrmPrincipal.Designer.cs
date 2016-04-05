namespace ClaseCuatro
{
    partial class FrmPrincipal
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
            this.btnBotonA = new System.Windows.Forms.Button();
            this.btnBotonB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotonA
            // 
            this.btnBotonA.Location = new System.Drawing.Point(64, 51);
            this.btnBotonA.Name = "btnBotonA";
            this.btnBotonA.Size = new System.Drawing.Size(75, 23);
            this.btnBotonA.TabIndex = 0;
            this.btnBotonA.Text = "Boton A";
            this.btnBotonA.UseVisualStyleBackColor = true;
            // 
            // btnBotonB
            // 
            this.btnBotonB.Location = new System.Drawing.Point(64, 115);
            this.btnBotonB.Name = "btnBotonB";
            this.btnBotonB.Size = new System.Drawing.Size(75, 23);
            this.btnBotonB.TabIndex = 1;
            this.btnBotonB.Text = "Boton B";
            this.btnBotonB.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBotonB);
            this.Controls.Add(this.btnBotonA);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotonA;
        private System.Windows.Forms.Button btnBotonB;
    }
}

