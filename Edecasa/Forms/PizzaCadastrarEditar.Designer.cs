namespace Edecasa
{
    partial class PizzaCadastrarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaCadastrarEditar));
            this.txtid = new System.Windows.Forms.Label();
            this.txtbroto = new System.Windows.Forms.Label();
            this.tbnomepizza = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.Label();
            this.txtgrande = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.MaskedTextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.tbvalorbroto = new System.Windows.Forms.TextBox();
            this.tbvalorgrande = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(25, 95);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(30, 20);
            this.txtid.TabIndex = 96;
            this.txtid.Text = "ID:";
            // 
            // txtbroto
            // 
            this.txtbroto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbroto.AutoSize = true;
            this.txtbroto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbroto.ForeColor = System.Drawing.Color.White;
            this.txtbroto.Location = new System.Drawing.Point(368, 95);
            this.txtbroto.Name = "txtbroto";
            this.txtbroto.Size = new System.Drawing.Size(52, 20);
            this.txtbroto.TabIndex = 95;
            this.txtbroto.Text = "Broto:";
            // 
            // tbnomepizza
            // 
            this.tbnomepizza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnomepizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbnomepizza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnomepizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnomepizza.ForeColor = System.Drawing.Color.White;
            this.tbnomepizza.Location = new System.Drawing.Point(77, 119);
            this.tbnomepizza.MaxLength = 40;
            this.tbnomepizza.Name = "tbnomepizza";
            this.tbnomepizza.Size = new System.Drawing.Size(289, 31);
            this.tbnomepizza.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnome.AutoSize = true;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(75, 95);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(119, 20);
            this.txtnome.TabIndex = 98;
            this.txtnome.Text = "Nome da Pizza:";
            // 
            // txtgrande
            // 
            this.txtgrande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgrande.AutoSize = true;
            this.txtgrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrande.ForeColor = System.Drawing.Color.White;
            this.txtgrande.Location = new System.Drawing.Point(461, 95);
            this.txtgrande.Name = "txtgrande";
            this.txtgrande.Size = new System.Drawing.Size(67, 20);
            this.txtgrande.TabIndex = 100;
            this.txtgrande.Text = "Grande:";
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.ForeColor = System.Drawing.Color.White;
            this.tbid.Location = new System.Drawing.Point(27, 119);
            this.tbid.Mask = "000";
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(44, 31);
            this.tbid.TabIndex = 1;
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
            this.btncadastrar.Location = new System.Drawing.Point(27, 179);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(266, 41);
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
            this.btnatualizar.Location = new System.Drawing.Point(299, 179);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(253, 41);
            this.btnatualizar.TabIndex = 6;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txttitulo.Location = new System.Drawing.Point(146, 21);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(280, 39);
            this.txttitulo.TabIndex = 122;
            this.txttitulo.Text = "Cadastrar Pizza";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(1, -3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(582, 4);
            this.panel10.TabIndex = 124;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(581, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 252);
            this.panel6.TabIndex = 123;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 4);
            this.panel1.TabIndex = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 252);
            this.panel2.TabIndex = 126;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(552, 1);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(29, 28);
            this.btnfechar.TabIndex = 7;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // tbvalorbroto
            // 
            this.tbvalorbroto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbvalorbroto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbvalorbroto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbvalorbroto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalorbroto.ForeColor = System.Drawing.Color.White;
            this.tbvalorbroto.Location = new System.Drawing.Point(372, 119);
            this.tbvalorbroto.MaxLength = 6;
            this.tbvalorbroto.Name = "tbvalorbroto";
            this.tbvalorbroto.Size = new System.Drawing.Size(87, 31);
            this.tbvalorbroto.TabIndex = 3;
            this.tbvalorbroto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvalorbroto_KeyPress);
            // 
            // tbvalorgrande
            // 
            this.tbvalorgrande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbvalorgrande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbvalorgrande.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbvalorgrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalorgrande.ForeColor = System.Drawing.Color.White;
            this.tbvalorgrande.Location = new System.Drawing.Point(465, 119);
            this.tbvalorgrande.MaxLength = 6;
            this.tbvalorgrande.Name = "tbvalorgrande";
            this.tbvalorgrande.Size = new System.Drawing.Size(87, 31);
            this.tbvalorgrande.TabIndex = 4;
            this.tbvalorgrande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvalorgrande_KeyPress);
            // 
            // PizzaCadastrarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(582, 252);
            this.Controls.Add(this.tbvalorgrande);
            this.Controls.Add(this.tbvalorbroto);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.txtgrande);
            this.Controls.Add(this.tbnomepizza);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtbroto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaCadastrarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza - Cadastrar";
            this.Load += new System.EventHandler(this.PizzaCadastrarEditar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PizzaCadastrarEditar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label txtbroto;
        private System.Windows.Forms.TextBox tbnomepizza;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.Label txtgrande;
        private System.Windows.Forms.MaskedTextBox tbid;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox tbvalorbroto;
        private System.Windows.Forms.TextBox tbvalorgrande;
    }
}