namespace Edecasa
{
    partial class UC_Pizzas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewPizzas = new System.Windows.Forms.DataGridView();
            this.tbbusca = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.cbfiltrar = new System.Windows.Forms.ComboBox();
            this.txtfiltrar = new System.Windows.Forms.Label();
            this.chbmeia = new System.Windows.Forms.CheckBox();
            this.txttitulo = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPizzas
            // 
            this.DataGridViewPizzas.AllowUserToAddRows = false;
            this.DataGridViewPizzas.AllowUserToDeleteRows = false;
            this.DataGridViewPizzas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewPizzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPizzas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewPizzas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewPizzas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewPizzas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPizzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewPizzas.ColumnHeadersHeight = 30;
            this.DataGridViewPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewPizzas.EnableHeadersVisualStyles = false;
            this.DataGridViewPizzas.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewPizzas.Location = new System.Drawing.Point(199, 197);
            this.DataGridViewPizzas.Name = "DataGridViewPizzas";
            this.DataGridViewPizzas.ReadOnly = true;
            this.DataGridViewPizzas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPizzas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewPizzas.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewPizzas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewPizzas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPizzas.Size = new System.Drawing.Size(461, 472);
            this.DataGridViewPizzas.TabIndex = 106;
            this.DataGridViewPizzas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPizzas_CellDoubleClick);
            // 
            // tbbusca
            // 
            this.tbbusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tbbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbusca.ForeColor = System.Drawing.Color.White;
            this.tbbusca.Location = new System.Drawing.Point(434, 153);
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
            this.btnexcluir.Location = new System.Drawing.Point(666, 537);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(148, 40);
            this.btnexcluir.TabIndex = 7;
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
            this.btncadastrar.Location = new System.Drawing.Point(666, 629);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(148, 40);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar Pizza";
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
            this.cbfiltrar.Location = new System.Drawing.Point(199, 150);
            this.cbfiltrar.Name = "cbfiltrar";
            this.cbfiltrar.Size = new System.Drawing.Size(229, 39);
            this.cbfiltrar.TabIndex = 1;
            this.cbfiltrar.Tag = "";
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiltrar.AutoSize = true;
            this.txtfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltrar.ForeColor = System.Drawing.Color.White;
            this.txtfiltrar.Location = new System.Drawing.Point(195, 126);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(80, 20);
            this.txtfiltrar.TabIndex = 159;
            this.txtfiltrar.Text = "Filtrar por:";
            // 
            // chbmeia
            // 
            this.chbmeia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbmeia.AutoSize = true;
            this.chbmeia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbmeia.ForeColor = System.Drawing.Color.White;
            this.chbmeia.Location = new System.Drawing.Point(666, 150);
            this.chbmeia.Name = "chbmeia";
            this.chbmeia.Size = new System.Drawing.Size(45, 20);
            this.chbmeia.TabIndex = 4;
            this.chbmeia.Text = "1/2";
            this.chbmeia.UseVisualStyleBackColor = true;
            // 
            // txttitulo
            // 
            this.txttitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttitulo.AutoSize = true;
            this.txttitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.Color.White;
            this.txttitulo.Location = new System.Drawing.Point(333, 24);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(227, 73);
            this.txttitulo.TabIndex = 163;
            this.txttitulo.Text = "Pizzas";
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
            this.btneditar.Location = new System.Drawing.Point(666, 583);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(148, 40);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Pizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.chbmeia);
            this.Controls.Add(this.tbbusca);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.cbfiltrar);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.DataGridViewPizzas);
            this.Name = "UC_Pizzas";
            this.Size = new System.Drawing.Size(899, 694);
            this.Load += new System.EventHandler(this.UC_Pizzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPizzas;
        private System.Windows.Forms.TextBox tbbusca;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ComboBox cbfiltrar;
        private System.Windows.Forms.Label txtfiltrar;
        private System.Windows.Forms.CheckBox chbmeia;
        private System.Windows.Forms.Label txttitulo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Timer timer1;
    }
}
