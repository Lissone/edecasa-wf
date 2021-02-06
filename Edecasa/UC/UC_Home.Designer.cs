namespace Edecasa
{
    partial class UC_Home
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.imhhome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imhhome)).BeginInit();
            this.SuspendLayout();
            // 
            // imhhome
            // 
            this.imhhome.Image = ((System.Drawing.Image)(resources.GetObject("imhhome.Image")));
            this.imhhome.Location = new System.Drawing.Point(141, 143);
            this.imhhome.Name = "imhhome";
            this.imhhome.Size = new System.Drawing.Size(643, 352);
            this.imhhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imhhome.TabIndex = 1;
            this.imhhome.TabStop = false;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.imhhome);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(899, 694);
            ((System.ComponentModel.ISupportInitialize)(this.imhhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imhhome;
    }
}
