namespace Edecasa
{
    partial class BebidaCadastrarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BebidaCadastrarEditar));
            this.txttitulo = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.MaskedTextBox();
            this.txtvalor = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.txttamanho = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.tbtamanho = new System.Windows.Forms.TextBox();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txttitulo.Location = new System.Drawing.Point(139, 20);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(302, 39);
            this.txttitulo.TabIndex = 123;
            this.txttitulo.Text = "Cadastrar Bebida";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncadastrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(29, 176);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(256, 41);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnatualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnatualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnatualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.ForeColor = System.Drawing.Color.White;
            this.btnatualizar.Location = new System.Drawing.Point(291, 176);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(261, 41);
            this.btnatualizar.TabIndex = 6;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.ForeColor = System.Drawing.Color.White;
            this.tbid.Location = new System.Drawing.Point(27, 123);
            this.tbid.Mask = "000";
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(44, 31);
            this.tbid.TabIndex = 1;
            // 
            // txtvalor
            // 
            this.txtvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtvalor.AutoSize = true;
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.ForeColor = System.Drawing.Color.White;
            this.txtvalor.Location = new System.Drawing.Point(477, 99);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(50, 20);
            this.txtvalor.TabIndex = 134;
            this.txtvalor.Text = "Valor:";
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnome.ForeColor = System.Drawing.Color.White;
            this.tbnome.Location = new System.Drawing.Point(77, 123);
            this.tbnome.MaxLength = 40;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(307, 31);
            this.tbnome.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnome.AutoSize = true;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(75, 99);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(131, 20);
            this.txtnome.TabIndex = 133;
            this.txtnome.Text = "Nome da Bebida:";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(25, 99);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(30, 20);
            this.txtid.TabIndex = 132;
            this.txtid.Text = "ID:";
            // 
            // txttamanho
            // 
            this.txttamanho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttamanho.AutoSize = true;
            this.txttamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttamanho.ForeColor = System.Drawing.Color.White;
            this.txttamanho.Location = new System.Drawing.Point(386, 99);
            this.txttamanho.Name = "txttamanho";
            this.txttamanho.Size = new System.Drawing.Size(80, 20);
            this.txttamanho.TabIndex = 131;
            this.txttamanho.Text = "Tamanho:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-6, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 4);
            this.panel1.TabIndex = 138;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(580, -6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 260);
            this.panel6.TabIndex = 137;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-3, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 260);
            this.panel2.TabIndex = 139;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-10, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 4);
            this.panel3.TabIndex = 140;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(551, 1);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(29, 28);
            this.btnfechar.TabIndex = 7;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click_1);
            // 
            // tbtamanho
            // 
            this.tbtamanho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbtamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbtamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtamanho.ForeColor = System.Drawing.Color.White;
            this.tbtamanho.Location = new System.Drawing.Point(390, 123);
            this.tbtamanho.MaxLength = 40;
            this.tbtamanho.Name = "tbtamanho";
            this.tbtamanho.Size = new System.Drawing.Size(85, 31);
            this.tbtamanho.TabIndex = 3;
            // 
            // tbvalor
            // 
            this.tbvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbvalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbvalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalor.ForeColor = System.Drawing.Color.White;
            this.tbvalor.Location = new System.Drawing.Point(481, 123);
            this.tbvalor.MaxLength = 6;
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(71, 31);
            this.tbvalor.TabIndex = 4;
            this.tbvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvalor_KeyPress);
            // 
            // BebidaCadastrarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(581, 250);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.tbtamanho);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttamanho);
            this.Controls.Add(this.txttitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BebidaCadastrarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebida - Cadastrar";
            this.Load += new System.EventHandler(this.BebidaCadastrarEditar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BebidaCadastrarEditar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.MaskedTextBox tbid;
        private System.Windows.Forms.Label txtvalor;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label txttamanho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox tbtamanho;
        private System.Windows.Forms.TextBox tbvalor;
    }
}