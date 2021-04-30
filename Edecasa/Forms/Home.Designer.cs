namespace Edecasa
{
    partial class Home
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.panelesquerda = new System.Windows.Forms.Panel();
            this.btnajustes = new System.Windows.Forms.Button();
            this.tbpedido = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.Label();
            this.DataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.txtvalor = new System.Windows.Forms.Label();
            this.txtrs = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.panelsidehome = new System.Windows.Forms.Panel();
            this.btnfecharcaixa = new System.Windows.Forms.Button();
            this.btnoutros = new System.Windows.Forms.Button();
            this.btnbebidas = new System.Windows.Forms.Button();
            this.btnpizzas = new System.Windows.Forms.Button();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.imhhome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paneltitulo.SuspendLayout();
            this.panelesquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPedido)).BeginInit();
            this.panelprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imhhome)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.paneltitulo.Controls.Add(this.btnhome);
            this.paneltitulo.Controls.Add(this.btnfechar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1370, 66);
            this.paneltitulo.TabIndex = 0;
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(41, 6);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(181, 54);
            this.btnhome.TabIndex = 9;
            this.btnhome.Text = "  EdeCasa";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(1284, 0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(86, 69);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // panelesquerda
            // 
            this.panelesquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panelesquerda.Controls.Add(this.btnajustes);
            this.panelesquerda.Controls.Add(this.tbpedido);
            this.panelesquerda.Controls.Add(this.btnlimpar);
            this.panelesquerda.Controls.Add(this.txttitulo);
            this.panelesquerda.Controls.Add(this.DataGridViewPedido);
            this.panelesquerda.Controls.Add(this.txtvalor);
            this.panelesquerda.Controls.Add(this.txtrs);
            this.panelesquerda.Controls.Add(this.txttotal);
            this.panelesquerda.Controls.Add(this.hora);
            this.panelesquerda.Controls.Add(this.data);
            this.panelesquerda.Controls.Add(this.btnfinalizar);
            this.panelesquerda.Controls.Add(this.panelsidehome);
            this.panelesquerda.Controls.Add(this.btnfecharcaixa);
            this.panelesquerda.Controls.Add(this.btnoutros);
            this.panelesquerda.Controls.Add(this.btnbebidas);
            this.panelesquerda.Controls.Add(this.btnpizzas);
            this.panelesquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelesquerda.Location = new System.Drawing.Point(0, 66);
            this.panelesquerda.Name = "panelesquerda";
            this.panelesquerda.Size = new System.Drawing.Size(471, 694);
            this.panelesquerda.TabIndex = 1;
            // 
            // btnajustes
            // 
            this.btnajustes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnajustes.BackColor = System.Drawing.Color.DarkCyan;
            this.btnajustes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnajustes.BackgroundImage")));
            this.btnajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnajustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajustes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajustes.ForeColor = System.Drawing.Color.White;
            this.btnajustes.Location = new System.Drawing.Point(380, 618);
            this.btnajustes.Name = "btnajustes";
            this.btnajustes.Size = new System.Drawing.Size(62, 44);
            this.btnajustes.TabIndex = 127;
            this.btnajustes.UseVisualStyleBackColor = false;
            this.btnajustes.Click += new System.EventHandler(this.btnajustes_Click);
            // 
            // tbpedido
            // 
            this.tbpedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbpedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpedido.ForeColor = System.Drawing.Color.White;
            this.tbpedido.Location = new System.Drawing.Point(150, 6);
            this.tbpedido.MaxLength = 20;
            this.tbpedido.Name = "tbpedido";
            this.tbpedido.Size = new System.Drawing.Size(188, 38);
            this.tbpedido.TabIndex = 126;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlimpar.BackColor = System.Drawing.Color.Brown;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.White;
            this.btnlimpar.Location = new System.Drawing.Point(334, 322);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(108, 40);
            this.btnlimpar.TabIndex = 125;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.AutoSize = true;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txttitulo.Location = new System.Drawing.Point(22, 9);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(112, 31);
            this.txttitulo.TabIndex = 124;
            this.txttitulo.Text = "Sacola:";
            // 
            // DataGridViewPedido
            // 
            this.DataGridViewPedido.AllowUserToAddRows = false;
            this.DataGridViewPedido.AllowUserToDeleteRows = false;
            this.DataGridViewPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPedido.ColumnHeadersHeight = 30;
            this.DataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewPedido.EnableHeadersVisualStyles = false;
            this.DataGridViewPedido.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewPedido.Location = new System.Drawing.Point(23, 47);
            this.DataGridViewPedido.Name = "DataGridViewPedido";
            this.DataGridViewPedido.ReadOnly = true;
            this.DataGridViewPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPedido.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewPedido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPedido.Size = new System.Drawing.Size(419, 269);
            this.DataGridViewPedido.TabIndex = 107;
            this.DataGridViewPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPedido_CellDoubleClick);
            // 
            // txtvalor
            // 
            this.txtvalor.AutoSize = true;
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.ForeColor = System.Drawing.Color.White;
            this.txtvalor.Location = new System.Drawing.Point(105, 331);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(20, 24);
            this.txtvalor.TabIndex = 19;
            this.txtvalor.Text = "0";
            // 
            // txtrs
            // 
            this.txtrs.AutoSize = true;
            this.txtrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrs.ForeColor = System.Drawing.Color.White;
            this.txtrs.Location = new System.Drawing.Point(79, 331);
            this.txtrs.Name = "txtrs";
            this.txtrs.Size = new System.Drawing.Size(33, 24);
            this.txtrs.TabIndex = 18;
            this.txtrs.Text = "R$";
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.White;
            this.txttotal.Location = new System.Drawing.Point(24, 330);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(62, 24);
            this.txttotal.TabIndex = 17;
            this.txttotal.Text = "Total:";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(24, 663);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(93, 24);
            this.hora.TabIndex = 16;
            this.hora.Text = "Aguarde..";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(24, 632);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(93, 24);
            this.data.TabIndex = 15;
            this.data.Text = "Aguarde..";
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
            this.btnfinalizar.Location = new System.Drawing.Point(220, 322);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(108, 40);
            this.btnfinalizar.TabIndex = 1;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // panelsidehome
            // 
            this.panelsidehome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panelsidehome.Location = new System.Drawing.Point(23, 377);
            this.panelsidehome.Name = "panelsidehome";
            this.panelsidehome.Size = new System.Drawing.Size(6, 54);
            this.panelsidehome.TabIndex = 12;
            // 
            // btnfecharcaixa
            // 
            this.btnfecharcaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfecharcaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfecharcaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharcaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfecharcaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnfecharcaixa.Image")));
            this.btnfecharcaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfecharcaixa.Location = new System.Drawing.Point(28, 557);
            this.btnfecharcaixa.Name = "btnfecharcaixa";
            this.btnfecharcaixa.Size = new System.Drawing.Size(414, 54);
            this.btnfecharcaixa.TabIndex = 5;
            this.btnfecharcaixa.Text = "Fechar Caixa";
            this.btnfecharcaixa.UseVisualStyleBackColor = true;
            this.btnfecharcaixa.Click += new System.EventHandler(this.btnfecharcaixa_Click);
            // 
            // btnoutros
            // 
            this.btnoutros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoutros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnoutros.Image = ((System.Drawing.Image)(resources.GetObject("btnoutros.Image")));
            this.btnoutros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnoutros.Location = new System.Drawing.Point(28, 497);
            this.btnoutros.Name = "btnoutros";
            this.btnoutros.Size = new System.Drawing.Size(414, 54);
            this.btnoutros.TabIndex = 4;
            this.btnoutros.Text = "Outros";
            this.btnoutros.UseVisualStyleBackColor = true;
            this.btnoutros.Click += new System.EventHandler(this.btnoutros_Click);
            // 
            // btnbebidas
            // 
            this.btnbebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbebidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbebidas.Image = ((System.Drawing.Image)(resources.GetObject("btnbebidas.Image")));
            this.btnbebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbebidas.Location = new System.Drawing.Point(28, 437);
            this.btnbebidas.Name = "btnbebidas";
            this.btnbebidas.Size = new System.Drawing.Size(414, 54);
            this.btnbebidas.TabIndex = 3;
            this.btnbebidas.Text = "Bebidas";
            this.btnbebidas.UseVisualStyleBackColor = true;
            this.btnbebidas.Click += new System.EventHandler(this.btnbebidas_Click);
            // 
            // btnpizzas
            // 
            this.btnpizzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpizzas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpizzas.Image = ((System.Drawing.Image)(resources.GetObject("btnpizzas.Image")));
            this.btnpizzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpizzas.Location = new System.Drawing.Point(28, 377);
            this.btnpizzas.Name = "btnpizzas";
            this.btnpizzas.Size = new System.Drawing.Size(414, 54);
            this.btnpizzas.TabIndex = 2;
            this.btnpizzas.Text = "Pizzas";
            this.btnpizzas.UseVisualStyleBackColor = true;
            this.btnpizzas.Click += new System.EventHandler(this.btnpizzas_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panelprincipal.Controls.Add(this.imhhome);
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(471, 66);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(899, 694);
            this.panelprincipal.TabIndex = 3;
            // 
            // imhhome
            // 
            this.imhhome.Image = ((System.Drawing.Image)(resources.GetObject("imhhome.Image")));
            this.imhhome.Location = new System.Drawing.Point(141, 143);
            this.imhhome.Name = "imhhome";
            this.imhhome.Size = new System.Drawing.Size(643, 352);
            this.imhhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imhhome.TabIndex = 0;
            this.imhhome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 760);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panelesquerda);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.paneltitulo.ResumeLayout(false);
            this.panelesquerda.ResumeLayout(false);
            this.panelesquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPedido)).EndInit();
            this.panelprincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imhhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panelesquerda;
        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.Button btnfecharcaixa;
        private System.Windows.Forms.Button btnoutros;
        private System.Windows.Forms.Button btnbebidas;
        private System.Windows.Forms.Button btnpizzas;
        private System.Windows.Forms.Panel panelsidehome;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtvalor;
        private System.Windows.Forms.Label txtrs;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.DataGridView DataGridViewPedido;
        private System.Windows.Forms.PictureBox imhhome;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox tbpedido;
        private System.Windows.Forms.Button btnajustes;
    }
}

