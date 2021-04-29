using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Edecasa.Controllers;
using Edecasa.Models;

namespace Edecasa.Forms
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        //Fazer form de mexer
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Ajustes_Load(object sender, EventArgs e)
        {
            AtualizarCombobox();
            AtualizarTextbox();

            btnexcluir.Visible = true;
            tbpagamento.Visible = false;
            lblcancelar.Visible = false;
        }

        public void AtualizarCombobox()
        {
            var tpPagamentoController = new FormasPagamentoController();
            var tpsPagamento = tpPagamentoController.getAll();

            cbpagamento.DisplayMember = "Descricao";
            cbpagamento.DataSource = tpsPagamento;
        }
        public void AtualizarTextbox()
        {
            var motoqueiroController = new MotoqueiroController();
            var motoqueiro = motoqueiroController.get();

            if(motoqueiro == null)
            {
                btncadastrarmotoqueiro.Enabled = true;
                btnatualizarmotoqueiro.Enabled = false;
            }
            else
            {
                tbmotoqueiro.Text = motoqueiro.Valor.ToString();
                btncadastrarmotoqueiro.Enabled = false;
                btnatualizarmotoqueiro.Enabled = true;
            }
        }

        private void Ajustes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadastrarpagamento_Click(object sender, EventArgs e)
        {
            if (tbpagamento.Visible == false)
            {
                btnexcluir.Visible = false;
                tbpagamento.Visible = true;
                lblcancelar.Visible = true;
            }
            else
            {
                string pagamento = tbpagamento.Text;

                if (pagamento.Equals(""))
                {
                    MessageBox.Show("Por favor, ensira o nome do tipo de pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var tpPagamentoController = new FormasPagamentoController();
                FormasPagamento tpPagamento = new FormasPagamento
                {
                    Descricao = pagamento
                };

                var ret = tpPagamentoController.create(tpPagamento);

                if (ret == null)
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                btnexcluir.Visible = true;
                tbpagamento.Visible = false;
                lblcancelar.Visible = false;
                tbpagamento.Text = string.Empty;

                AtualizarCombobox();

                MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            var tpPagamento = cbpagamento.SelectedItem as FormasPagamento;

            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
                return;

            var tpPagamentoController = new FormasPagamentoController();
            bool ret = tpPagamentoController.delete(tpPagamento.Id);

            if (!ret)
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AtualizarCombobox();
            MessageBox.Show("Registro excluido com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void lblcancelar_Click(object sender, EventArgs e)
        {
            btnexcluir.Visible = true;
            tbpagamento.Visible = false;
            lblcancelar.Visible = false;
            tbpagamento.Text = string.Empty;
        }

        private void btncadastrarmotoqueiro_Click(object sender, EventArgs e)
        {
            string vlMotoqueiro = tbmotoqueiro.Text;

            if (vlMotoqueiro.Equals("") || vlMotoqueiro == "0")
            {
                MessageBox.Show("Por favor, ensira um valor válido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var motoqueiroController = new MotoqueiroController();
            Motoqueiro motoqueiro = new Motoqueiro
            {
                Valor = Convert.ToDouble(vlMotoqueiro)
            };

            var ret = motoqueiroController.create(motoqueiro);

            if (ret == null)
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btncadastrarmotoqueiro.Enabled = false;
            btnatualizarmotoqueiro.Enabled = true;

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnatualizarmotoqueiro_Click(object sender, EventArgs e)
        {
            string vlMotoqueiro = tbmotoqueiro.Text;

            if (vlMotoqueiro.Equals("") || vlMotoqueiro == "0")
            {
                MessageBox.Show("Por favor, ensira um valor válido", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja atualizar esse registro?", "Edição de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
                return;

            var motoqueiroController = new MotoqueiroController();
            bool ret = motoqueiroController.update(Convert.ToDouble(vlMotoqueiro));

            if (!ret)
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btncadastrarmotoqueiro.Enabled = false;
            btnatualizarmotoqueiro.Enabled = true;

            MessageBox.Show("Registro atualizado com sucesso!", "Edição de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbmotoqueiro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbmotoqueiro.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
