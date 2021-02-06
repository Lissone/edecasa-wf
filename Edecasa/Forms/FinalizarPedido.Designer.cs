namespace Edecasa
{
    partial class FinalizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizarPedido));
            this.tbhora = new System.Windows.Forms.MaskedTextBox();
            this.tbdata = new System.Windows.Forms.MaskedTextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.txthora = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.Label();
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
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.tbtaxa = new System.Windows.Forms.TextBox();
            this.txttaxa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbhora
            // 
            this.tbhora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhora.ForeColor = System.Drawing.Color.White;
            this.tbhora.Location = new System.Drawing.Point(182, 128);
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
            this.tbdata.Location = new System.Drawing.Point(41, 128);
            this.tbdata.Mask = "00/00/0000";
            this.tbdata.Name = "tbdata";
            this.tbdata.Size = new System.Drawing.Size(135, 31);
            this.tbdata.TabIndex = 1;
            this.tbdata.ValidatingType = typeof(System.DateTime);
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnome.ForeColor = System.Drawing.Color.White;
            this.tbnome.Location = new System.Drawing.Point(393, 128);
            this.tbnome.MaxLength = 60;
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(182, 31);
            this.tbnome.TabIndex = 4;
            // 
            // txthora
            // 
            this.txthora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txthora.AutoSize = true;
            this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.ForeColor = System.Drawing.Color.White;
            this.txthora.Location = new System.Drawing.Point(178, 104);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(48, 20);
            this.txthora.TabIndex = 140;
            this.txthora.Text = "Hora:";
            // 
            // txtnome
            // 
            this.txtnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnome.AutoSize = true;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(389, 104);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(55, 20);
            this.txtnome.TabIndex = 139;
            this.txtnome.Text = "Nome:";
            // 
            // txtdata
            // 
            this.txtdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdata.AutoSize = true;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.ForeColor = System.Drawing.Color.White;
            this.txtdata.Location = new System.Drawing.Point(37, 104);
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
            this.tbrua.Location = new System.Drawing.Point(41, 195);
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
            this.txtrua.Location = new System.Drawing.Point(37, 171);
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
            this.tbbairro.Location = new System.Drawing.Point(286, 195);
            this.tbbairro.MaxLength = 60;
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(212, 31);
            this.tbbairro.TabIndex = 6;
            // 
            // txtbairro
            // 
            this.txtbairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbairro.AutoSize = true;
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.ForeColor = System.Drawing.Color.White;
            this.txtbairro.Location = new System.Drawing.Point(286, 171);
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
            this.chbpredio.Location = new System.Drawing.Point(560, 109);
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
            this.txtpredio.Location = new System.Drawing.Point(499, 104);
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
            this.tbnumero.Location = new System.Drawing.Point(504, 195);
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
            this.txtnumero.Location = new System.Drawing.Point(500, 171);
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
            this.tbtelefone.Location = new System.Drawing.Point(263, 128);
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
            this.txttelefone.Location = new System.Drawing.Point(259, 104);
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
            this.cbpagamento.Location = new System.Drawing.Point(41, 262);
            this.cbpagamento.Name = "cbpagamento";
            this.cbpagamento.Size = new System.Drawing.Size(129, 33);
            this.cbpagamento.TabIndex = 8;
            this.cbpagamento.Tag = "";
            // 
            // txtpagamento
            // 
            this.txtpagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpagamento.AutoSize = true;
            this.txtpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagamento.ForeColor = System.Drawing.Color.White;
            this.txtpagamento.Location = new System.Drawing.Point(37, 237);
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(95, 20);
            this.txtpagamento.TabIndex = 154;
            this.txtpagamento.Text = "Pagamento:";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfinalizar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnfinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfinalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Location = new System.Drawing.Point(388, 254);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(187, 40);
            this.btnfinalizar.TabIndex = 11;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txttitulo.Location = new System.Drawing.Point(145, 32);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(322, 46);
            this.txttitulo.TabIndex = 157;
            this.txttitulo.Text = "Finalizar Pedido";
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
            // tbvalor
            // 
            this.tbvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbvalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbvalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvalor.ForeColor = System.Drawing.Color.White;
            this.tbvalor.Location = new System.Drawing.Point(176, 261);
            this.tbvalor.MaxLength = 8;
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(100, 31);
            this.tbvalor.TabIndex = 9;
            this.tbvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbvalor_KeyPress);
            // 
            // txtvalor
            // 
            this.txtvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtvalor.AutoSize = true;
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.ForeColor = System.Drawing.Color.White;
            this.txtvalor.Location = new System.Drawing.Point(176, 237);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(50, 20);
            this.txtvalor.TabIndex = 163;
            this.txtvalor.Text = "Valor:";
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
            this.btnfechar.TabIndex = 12;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // tbtaxa
            // 
            this.tbtaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbtaxa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbtaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtaxa.ForeColor = System.Drawing.Color.White;
            this.tbtaxa.Location = new System.Drawing.Point(282, 261);
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
            this.txttaxa.Location = new System.Drawing.Point(282, 237);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(47, 20);
            this.txttaxa.TabIndex = 165;
            this.txttaxa.Text = "Taxa:";
            // 
            // FinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(619, 332);
            this.Controls.Add(this.tbtaxa);
            this.Controls.Add(this.txttaxa);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.btnfinalizar);
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
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinalizarPedido";
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
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label txthora;
        private System.Windows.Forms.Label txtnome;
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
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.Label txtvalor;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox tbtaxa;
        private System.Windows.Forms.Label txttaxa;
    }
}