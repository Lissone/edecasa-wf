namespace Edecasa
{
    partial class CadastrarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPedido));
            this.tbhora = new System.Windows.Forms.MaskedTextBox();
            this.tbdata = new System.Windows.Forms.MaskedTextBox();
            this.txthora = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.Label();
            this.tbrua = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.Label();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.Label();
            this.chbpredio = new System.Windows.Forms.CheckBox();
            this.txtpredio = new System.Windows.Forms.Label();
            this.tbnumero = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.Label();
            this.tbtelefone = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.Label();
            this.cbpagamento = new System.Windows.Forms.ComboBox();
            this.txtpagamento = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbtaxa = new System.Windows.Forms.TextBox();
            this.txttaxa = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.tbcomplemento = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbhora
            // 
            this.tbhora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhora.ForeColor = System.Drawing.Color.White;
            this.tbhora.Location = new System.Drawing.Point(157, 127);
            this.tbhora.Mask = "00:00";
            this.tbhora.Name = "tbhora";
            this.tbhora.Size = new System.Drawing.Size(75, 31);
            this.tbhora.TabIndex = 2;
            this.tbhora.ValidatingType = typeof(System.DateTime);
            // 
            // tbdata
            // 
            this.tbdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdata.ForeColor = System.Drawing.Color.White;
            this.tbdata.Location = new System.Drawing.Point(16, 127);
            this.tbdata.Mask = "00/00/0000";
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(135, 31);
            this.tbdata.TabIndex = 1;
            this.tbdata.ValidatingType = typeof(System.DateTime);
            // 
            // txthora
            // 
            this.txthora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthora.AutoSize = true;
            this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.ForeColor = System.Drawing.Color.White;
            this.txthora.Location = new System.Drawing.Point(153, 103);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(48, 20);
            this.txthora.TabIndex = 140;
            this.txthora.Text = "Hora:";
            // 
            // txtdata
            // 
            this.txtdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdata.AutoSize = true;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.Color.White;
            this.txtdata.Location = new System.Drawing.Point(12, 103);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(48, 20);
            this.txtdata.TabIndex = 138;
            this.txtdata.Text = "Data:";
            // 
            // tbrua
            // 
            this.tbrua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbrua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbrua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrua.ForeColor = System.Drawing.Color.White;
            this.tbrua.Location = new System.Drawing.Point(368, 126);
            this.tbrua.MaxLength = 60;
            this.tbrua.Name = "tbrua";
            this.tbrua.Size = new System.Drawing.Size(239, 31);
            this.tbrua.TabIndex = 5;
            // 
            // txtrua
            // 
            this.txtrua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtrua.AutoSize = true;
            this.txtrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrua.ForeColor = System.Drawing.Color.White;
            this.txtrua.Location = new System.Drawing.Point(364, 102);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(43, 20);
            this.txtrua.TabIndex = 142;
            this.txtrua.Text = "Rua:";
            // 
            // tbbairro
            // 
            this.tbbairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbairro.ForeColor = System.Drawing.Color.White;
            this.tbbairro.Location = new System.Drawing.Point(16, 195);
            this.tbbairro.MaxLength = 60;
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(243, 31);
            this.tbbairro.TabIndex = 6;
            // 
            // txtbairro
            // 
            this.txtbairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbairro.AutoSize = true;
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.ForeColor = System.Drawing.Color.White;
            this.txtbairro.Location = new System.Drawing.Point(16, 171);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(55, 20);
            this.txtbairro.TabIndex = 144;
            this.txtbairro.Text = "Bairro:";
            // 
            // chbpredio
            // 
            this.chbpredio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbpredio.AutoSize = true;
            this.chbpredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbpredio.ForeColor = System.Drawing.Color.White;
            this.chbpredio.Location = new System.Drawing.Point(588, 107);
            this.chbpredio.Name = "chbpredio";
            this.chbpredio.Size = new System.Drawing.Size(15, 14);
            this.chbpredio.TabIndex = 147;
            this.chbpredio.UseVisualStyleBackColor = true;
            this.chbpredio.CheckedChanged += new System.EventHandler(this.chbpredio_CheckedChanged);
            // 
            // txtpredio
            // 
            this.txtpredio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpredio.AutoSize = true;
            this.txtpredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpredio.ForeColor = System.Drawing.Color.White;
            this.txtpredio.Location = new System.Drawing.Point(527, 102);
            this.txtpredio.Name = "txtpredio";
            this.txtpredio.Size = new System.Drawing.Size(58, 20);
            this.txtpredio.TabIndex = 148;
            this.txtpredio.Text = "Prédio:";
            // 
            // tbnumero
            // 
            this.tbnumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumero.ForeColor = System.Drawing.Color.White;
            this.tbnumero.Location = new System.Drawing.Point(265, 195);
            this.tbnumero.MaxLength = 10;
            this.tbnumero.Name = "tbnumero";
            this.tbnumero.Size = new System.Drawing.Size(71, 31);
            this.tbnumero.TabIndex = 7;
            // 
            // txtnumero
            // 
            this.txtnumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnumero.AutoSize = true;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.ForeColor = System.Drawing.Color.White;
            this.txtnumero.Location = new System.Drawing.Point(261, 171);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(30, 20);
            this.txtnumero.TabIndex = 150;
            this.txtnumero.Text = "Nº:";
            // 
            // tbtelefone
            // 
            this.tbtelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtelefone.ForeColor = System.Drawing.Color.White;
            this.tbtelefone.Location = new System.Drawing.Point(238, 127);
            this.tbtelefone.Mask = "000000000";
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(124, 31);
            this.tbtelefone.TabIndex = 3;
            this.tbtelefone.TextChanged += new System.EventHandler(this.tbtelefone_TextChanged);
            // 
            // txttelefone
            // 
            this.txttelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttelefone.AutoSize = true;
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.ForeColor = System.Drawing.Color.White;
            this.txttelefone.Location = new System.Drawing.Point(234, 103);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(75, 20);
            this.txttelefone.TabIndex = 152;
            this.txttelefone.Text = "Telefone:";
            // 
            // cbpagamento
            // 
            this.cbpagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbpagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.cbpagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpagamento.ForeColor = System.Drawing.Color.White;
            this.cbpagamento.FormattingEnabled = true;
            this.cbpagamento.Items.AddRange(new object[] {
            ""});
            this.cbpagamento.Location = new System.Drawing.Point(22, 261);
            this.cbpagamento.Name = "cbpagamento";
            this.cbpagamento.Size = new System.Drawing.Size(179, 33);
            this.cbpagamento.TabIndex = 8;
            this.cbpagamento.Tag = "";
            // 
            // txtpagamento
            // 
            this.txtpagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpagamento.AutoSize = true;
            this.txtpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagamento.ForeColor = System.Drawing.Color.White;
            this.txtpagamento.Location = new System.Drawing.Point(18, 236);
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(95, 20);
            this.txtpagamento.TabIndex = 154;
            this.txtpagamento.Text = "Pagamento:";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnconfirmar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(238, 261);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(187, 40);
            this.btnconfirmar.TabIndex = 11;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txttitulo.Location = new System.Drawing.Point(145, 32);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(341, 46);
            this.txttitulo.TabIndex = 157;
            this.txttitulo.Text = "Cadastrar pedido";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(-5, -3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(630, 4);
            this.panel10.TabIndex = 159;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(618, -19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 370);
            this.panel6.TabIndex = 158;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-3, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 380);
            this.panel1.TabIndex = 160;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-5, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 4);
            this.panel2.TabIndex = 161;
            // 
            // tbtaxa
            // 
            this.tbtaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbtaxa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbtaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtaxa.ForeColor = System.Drawing.Color.White;
            this.tbtaxa.Location = new System.Drawing.Point(503, 195);
            this.tbtaxa.MaxLength = 8;
            this.tbtaxa.Name = "tbtaxa";
            this.tbtaxa.Size = new System.Drawing.Size(100, 31);
            this.tbtaxa.TabIndex = 10;
            this.tbtaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtaxa_KeyPress);
            // 
            // txttaxa
            // 
            this.txttaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttaxa.AutoSize = true;
            this.txttaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaxa.ForeColor = System.Drawing.Color.White;
            this.txttaxa.Location = new System.Drawing.Point(503, 171);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(47, 20);
            this.txttaxa.TabIndex = 165;
            this.txttaxa.Text = "Taxa:";
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(589, 1);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(29, 28);
            this.btnfechar.TabIndex = 166;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // tbcomplemento
            // 
            this.tbcomplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcomplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbcomplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcomplemento.ForeColor = System.Drawing.Color.White;
            this.tbcomplemento.Location = new System.Drawing.Point(342, 195);
            this.tbcomplemento.MaxLength = 60;
            this.tbcomplemento.Name = "tbcomplemento";
            this.tbcomplemento.Size = new System.Drawing.Size(155, 31);
            this.tbcomplemento.TabIndex = 167;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcomplemento.AutoSize = true;
            this.txtcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.ForeColor = System.Drawing.Color.White;
            this.txtcomplemento.Location = new System.Drawing.Point(342, 171);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(112, 20);
            this.txtcomplemento.TabIndex = 168;
            this.txtcomplemento.Text = "Complemento:";
            // 
            // CadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(619, 332);
            this.Controls.Add(this.tbcomplemento);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.tbtaxa);
            this.Controls.Add(this.txttaxa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.cbpagamento);
            this.Controls.Add(this.txtpagamento);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.tbnumero);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.chbpredio);
            this.Controls.Add(this.txtpredio);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.tbrua);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.tbhora);
            this.Controls.Add(this.tbdata);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Pedido";
            this.Load += new System.EventHandler(this.FinalizarPedido_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FinalizarPedido_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbhora;
        private System.Windows.Forms.MaskedTextBox tbdata;
        private System.Windows.Forms.Label txthora;
        private System.Windows.Forms.Label txtdata;
        private System.Windows.Forms.TextBox tbrua;
        private System.Windows.Forms.Label txtrua;
        private System.Windows.Forms.TextBox tbbairro;
        private System.Windows.Forms.Label txtbairro;
        private System.Windows.Forms.CheckBox chbpredio;
        private System.Windows.Forms.Label txtpredio;
        private System.Windows.Forms.TextBox tbnumero;
        private System.Windows.Forms.Label txtnumero;
        private System.Windows.Forms.MaskedTextBox tbtelefone;
        private System.Windows.Forms.Label txttelefone;
        private System.Windows.Forms.ComboBox cbpagamento;
        private System.Windows.Forms.Label txtpagamento;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbtaxa;
        private System.Windows.Forms.Label txttaxa;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox tbcomplemento;
        private System.Windows.Forms.Label txtcomplemento;
    }
}