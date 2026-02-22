namespace TraductorESP_EN
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxESP;
        private System.Windows.Forms.TextBox textBoxEN;
        private System.Windows.Forms.Button buttonTraducir;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxESP = new System.Windows.Forms.TextBox();
            this.textBoxEN = new System.Windows.Forms.TextBox();
            this.buttonTraducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxESP
            // 
            this.textBoxESP.Location = new System.Drawing.Point(16, 16);
            this.textBoxESP.Name = "textBoxESP";
            this.textBoxESP.Size = new System.Drawing.Size(200, 22);
            this.textBoxESP.TabIndex = 0;
            this.textBoxESP.Text = "ESP";
            this.textBoxESP.TextChanged += new System.EventHandler(this.textBoxESP_TextChanged);
            // 
            // textBoxEN
            // 
            this.textBoxEN.Location = new System.Drawing.Point(232, 16);
            this.textBoxEN.Name = "textBoxEN";
            this.textBoxEN.Size = new System.Drawing.Size(200, 22);
            this.textBoxEN.TabIndex = 1;
            this.textBoxEN.Text = "EN";
            this.textBoxEN.TextChanged += new System.EventHandler(this.textBoxEN_TextChanged);
            // 
            // buttonTraducir
            // 
            this.buttonTraducir.Location = new System.Drawing.Point(16, 56);
            this.buttonTraducir.Name = "buttonTraducir";
            this.buttonTraducir.Size = new System.Drawing.Size(100, 30);
            this.buttonTraducir.TabIndex = 2;
            this.buttonTraducir.Text = "Traducir";
            this.buttonTraducir.UseVisualStyleBackColor = true;
            this.buttonTraducir.Click += new System.EventHandler(this.buttonTraducir_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTraducir);
            this.Controls.Add(this.textBoxEN);
            this.Controls.Add(this.textBoxESP);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(456, 128);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
