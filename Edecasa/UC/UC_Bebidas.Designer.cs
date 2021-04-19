namespace Edecasa
{
    partial class UC_Bebidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btneditar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.Label();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.cbfiltrar = new System.Windows.Forms.ComboBox();
            this.txtfiltrar = new System.Windows.Forms.Label();
            this.DataGridViewBebidas = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(675, 578);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(159, 40);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttitulo.AutoSize = true;
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.White;
            this.txttitulo.Location = new System.Drawing.Point(306, 20);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(272, 73);
            this.txttitulo.TabIndex = 173;
            this.txttitulo.Text = "Bebidas";
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbusca.ForeColor = System.Drawing.Color.White;
            this.tbbusca.Location = new System.Drawing.Point(443, 146);
            this.tbbusca.MaxLength = 20;
            this.tbbusca.Name = "tbbusca";
            this.tbbusca.Size = new System.Drawing.Size(226, 38);
            this.tbbusca.TabIndex = 2;
            this.tbbusca.TextChanged += new System.EventHandler(this.tbbusca_TextChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnexcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(675, 532);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(159, 40);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(675, 624);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(159, 40);
            this.btncadastrar.TabIndex = 3;
            this.btncadastrar.Text = "Cadastrar Bebida";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
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
            "Todos",
            "Id",
            "Descrição",
            "Valor"});
            this.cbfiltrar.Location = new System.Drawing.Point(208, 145);
            this.cbfiltrar.Name = "cbfiltrar";
            this.cbfiltrar.Size = new System.Drawing.Size(229, 39);
            this.cbfiltrar.TabIndex = 1;
            this.cbfiltrar.Tag = "";
            this.cbfiltrar.SelectedIndexChanged += new System.EventHandler(this.cbfiltrar_SelectedIndexChanged);
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiltrar.AutoSize = true;
            this.txtfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrar.ForeColor = System.Drawing.Color.White;
            this.txtfiltrar.Location = new System.Drawing.Point(204, 121);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(80, 20);
            this.txtfiltrar.TabIndex = 172;
            this.txtfiltrar.Text = "Filtrar por:";
            // 
            // DataGridViewBebidas
            // 
            this.DataGridViewBebidas.AllowUserToAddRows = false;
            this.DataGridViewBebidas.AllowUserToDeleteRows = false;
            this.DataGridViewBebidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewBebidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewBebidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewBebidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBebidas.ColumnHeadersHeight = 30;
            this.DataGridViewBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewBebidas.EnableHeadersVisualStyles = false;
            this.DataGridViewBebidas.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewBebidas.Location = new System.Drawing.Point(208, 192);
            this.DataGridViewBebidas.Name = "DataGridViewBebidas";
            this.DataGridViewBebidas.ReadOnly = true;
            this.DataGridViewBebidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBebidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBebidas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewBebidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewBebidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewBebidas.Size = new System.Drawing.Size(461, 472);
            this.DataGridViewBebidas.TabIndex = 171;
            this.DataGridViewBebidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewBebidas_CellDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.DataGridViewBebidas);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.cbfiltrar);
            this.Controls.Add(this.txtfiltrar);
            this.Name = "UC_Bebidas";
            this.Size = new System.Drawing.Size(899, 694);
            this.Load += new System.EventHandler(this.UC_Bebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.TextBox tbbusca;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ComboBox cbfiltrar;
        private System.Windows.Forms.Label txtfiltrar;
        private System.Windows.Forms.DataGridView DataGridViewBebidas;
        private System.Windows.Forms.Timer timer1;
    }
}
