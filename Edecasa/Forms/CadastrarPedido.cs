using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Edecasa.Controllers;
using Edecasa.Models;

namespace Edecasa
{
    public partial class CadastrarPedido : Form
    {
        private static bool existsCliente = false;
        private static int clienteId = 0;
        public CadastrarPedido()
        {
            InitializeComponent();
        }

        //Fazer form de mexer
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FinalizarPedido_Load(object sender, EventArgs e)
        {
            //data e hora atual
            tbdata.Text = DateTime.Now.ToShortDateString();
            tbhora.Text = DateTime.Now.ToLongTimeString();
            tbdata.Enabled = false;
            tbhora.Enabled = false;

            loadFormasPagamentoComboBox();
        }

        private void loadFormasPagamentoComboBox()
        {
            var tpPagamentoController = new FormasPagamentoController();
            var tpsPagamento = tpPagamentoController.getAll();

            cbpagamento.DisplayMember = "Descricao";
            cbpagamento.DataSource = tpsPagamento;
        }

        private void FinalizarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja fechar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void chbpredio_CheckedChanged(object sender, EventArgs e)
        {
            if(chbpredio.Checked)
            {
                tbrua.Text = "AV GUARULHOS";
                tbbairro.Text = "VILA VICENTINA";
                tbnumero.Text = "609";
            }
            else
            {
                tbrua.Text = "";
                tbbairro.Text = "";
                tbnumero.Text = "";
            }
        }

        private void tbtelefone_TextChanged(object sender, EventArgs e)
        {
            string telefone = tbtelefone.Text;

            if (telefone.Length < 7)
                return;

            var clienteController = new ClienteController();
            Cliente cliente = clienteController.getByTelefone(telefone);

            if (cliente == null)
                return;

            if(cliente.Rua == "AV GUARULHOS" && cliente.Numero == "609")
                chbpredio.Checked = true;

            clienteId = cliente.Id;
            tbrua.Text = cliente.Rua;
            tbbairro.Text = cliente.Bairro;
            tbnumero.Text = cliente.Numero;
            tbcomplemento.Text = cliente.Complemento;
            existsCliente = true;
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            DateTime dtPedido = DateTime.Now;
            string telefone = tbtelefone.Text;
            string rua = tbrua.Text;
            string bairro = tbbairro.Text;
            string numero = tbnumero.Text;
            string complemento = tbcomplemento.Text;
            var tpPagamento = cbpagamento.SelectedItem as FormasPagamento;
            float taxa = Convert.ToSingle(tbtaxa.Text);
            
            if(!existsCliente)
            {
                var clienteController = new ClienteController();
                Cliente cliente = new Cliente
                {
                    Telefone = telefone,
                    Rua = rua,
                    Bairro = bairro,
                    Numero = numero,
                    Complemento = complemento
                };

                Cliente retCliente = clienteController.create(cliente);

                if (retCliente == null)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar o cliente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                clienteId = retCliente.Id;
            }

            var pedidoController = new PedidoController();
            Pedido pedido = new Pedido
            {
                Data = dtPedido,
                Taxa = taxa,
                TpPagamentoId = tpPagamento.Id,
                ClienteId = clienteId
            };

            Pedido retPedido = pedidoController.create(pedido);

            if (retPedido == null)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o pedido.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            Home.refresh = true; //Atualizar grid da home
            Home.pedidoId = retPedido.Id;
            this.Close();
        }

        private bool validation()
        {
            if (tbtelefone.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o telefone do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbrua.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a rua da entrega", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbbairro.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o bairro da entrega", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbnumero.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o número da residência", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbpagamento.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o tipo do pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbtaxa.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a taxa de entrega", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void tbtaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbtaxa.Text.Contains(","))
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
