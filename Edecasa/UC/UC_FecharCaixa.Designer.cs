namespace Edecasa
{
    partial class UC_FecharCaixa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewFecharcaixa = new System.Windows.Forms.DataGridView();
            this.txttitulo = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.txtfiltrar = new System.Windows.Forms.Label();
            this.btntodospedidos = new System.Windows.Forms.Button();
            this.btnvalorestotais = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbfiltrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFecharcaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewFecharcaixa
            // 
            this.DataGridViewFecharcaixa.AllowUserToAddRows = false;
            this.DataGridViewFecharcaixa.AllowUserToDeleteRows = false;
            this.DataGridViewFecharcaixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewFecharcaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewFecharcaixa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewFecharcaixa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewFecharcaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewFecharcaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFecharcaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewFecharcaixa.ColumnHeadersHeight = 30;
            this.DataGridViewFecharcaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewFecharcaixa.EnableHeadersVisualStyles = false;
            this.DataGridViewFecharcaixa.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewFecharcaixa.Location = new System.Drawing.Point(22, 244);
            this.DataGridViewFecharcaixa.Name = "DataGridViewFecharcaixa";
            this.DataGridViewFecharcaixa.ReadOnly = true;
            this.DataGridViewFecharcaixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFecharcaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewFecharcaixa.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewFecharcaixa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewFecharcaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewFecharcaixa.Size = new System.Drawing.Size(857, 390);
            this.DataGridViewFecharcaixa.TabIndex = 180;
            this.DataGridViewFecharcaixa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFecharcaixa_CellDoubleClick);
            // 
            // txttitulo
            // 
            this.txttitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttitulo.AutoSize = true;
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.White;
            this.txttitulo.Location = new System.Drawing.Point(233, 39);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(425, 73);
            this.txttitulo.TabIndex = 184;
            this.txttitulo.Text = "Fechar Caixa";
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbusca.ForeColor = System.Drawing.Color.White;
            this.tbbusca.Location = new System.Drawing.Point(257, 197);
            this.tbbusca.MaxLength = 20;
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(245, 38);
            this.tbbusca.TabIndex = 2;
            this.tbbusca.TextChanged += new System.EventHandler(this.tbbusca_TextChanged);
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiltrar.AutoSize = true;
            this.txtfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrar.ForeColor = System.Drawing.Color.White;
            this.txtfiltrar.Location = new System.Drawing.Point(18, 173);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(80, 20);
            this.txtfiltrar.TabIndex = 183;
            this.txtfiltrar.Text = "Filtrar por:";
            // 
            // btntodospedidos
            // 
            this.btntodospedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntodospedidos.BackColor = System.Drawing.Color.White;
            this.btntodospedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntodospedidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btntodospedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntodospedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntodospedidos.ForeColor = System.Drawing.Color.Black;
            this.btntodospedidos.Location = new System.Drawing.Point(22, 640);
            this.btntodospedidos.Name = "btntodospedidos";
            this.btntodospedidos.Size = new System.Drawing.Size(158, 40);
            this.btntodospedidos.TabIndex = 3;
            this.btntodospedidos.Text = "Todos Pedidos";
            this.btntodospedidos.UseVisualStyleBackColor = false;
            this.btntodospedidos.Click += new System.EventHandler(this.btntodospedidos_Click);
            // 
            // btnvalorestotais
            // 
            this.btnvalorestotais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnvalorestotais.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnvalorestotais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalorestotais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnvalorestotais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvalorestotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalorestotais.ForeColor = System.Drawing.Color.White;
            this.btnvalorestotais.Location = new System.Drawing.Point(186, 640);
            this.btnvalorestotais.Name = "btnvalorestotais";
            this.btnvalorestotais.Size = new System.Drawing.Size(158, 40);
            this.btnvalorestotais.TabIndex = 4;
            this.btnvalorestotais.Text = "Valores Totais";
            this.btnvalorestotais.UseVisualStyleBackColor = false;
            this.btnvalorestotais.Click += new System.EventHandler(this.btnvalorestotais_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbfiltrar
            // 
            this.cbfiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbfiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.cbfiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfiltrar.ForeColor = System.Drawing.Color.White;
            this.cbfiltrar.FormattingEnabled = true;
            this.cbfiltrar.Items.AddRange(new object[] {
            "ID",
            "DATA",
            "NOME",
            "TELEFONE",
            "PAGAMENTO",
            "RUA",
            "BAIRRO",
            "NUMERO",
            "VALOR"});
            this.cbfiltrar.Location = new System.Drawing.Point(22, 197);
            this.cbfiltrar.Name = "cbfiltrar";
            this.cbfiltrar.Size = new System.Drawing.Size(229, 39);
            this.cbfiltrar.TabIndex = 1;
            this.cbfiltrar.Tag = "";
            // 
            // UC_FecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.cbfiltrar);
            this.Controls.Add(this.DataGridViewFecharcaixa);
            this.Controls.Add(this.btnvalorestotais);
            this.Controls.Add(this.btntodospedidos);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.txtfiltrar);
            this.Name = "UC_FecharCaixa";
            this.Size = new System.Drawing.Size(899, 694);
            this.Load += new System.EventHandler(this.UC_FecharCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFecharcaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewFecharcaixa;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.TextBox tbbusca;
        private System.Windows.Forms.Label txtfiltrar;
        private System.Windows.Forms.Button btntodospedidos;
        private System.Windows.Forms.Button btnvalorestotais;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbfiltrar;
    }
}
