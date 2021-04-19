using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Edecasa.Classes;

namespace Edecasa
{
    public partial class CadastrarPedido : Form
    {
        public CadastrarPedido()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        Validation validation = new Validation();
        // FUNÇÃO PARA FAZER FORM SE MEXER
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static string data,hora,telefone,nome,rua,bairro,numero,pagamento,valor,taxa,validacao;
        private void FinalizarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja fechar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Home.limpar_array = "2";//LIMPAR APENAS TEXTBOX DE PEDIDO
                Application.OpenForms["FinalizarPedido"].Close();
            }
        }

        private void FinalizarPedido_Load(object sender, EventArgs e)
        {
            //inclusao de dados
            tbdata.Text = DateTime.Now.ToShortDateString();
            tbhora.Text = DateTime.Now.ToLongTimeString();
            tbvalor.Text = Home.total.ToString();
            //desativacao
            tbdata.Enabled = false;
            tbhora.Enabled = false;
            //INSERIR FORMAS DE PAGAMENTO NA COMBOBOX
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True");
            cn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.CommandText = "SELECT DESCRICAO FROM FORMA_PAGAMENTO ORDER BY DESCRICAO ASC";
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbpagamento.DisplayMember = "DESCRICAO";
            cbpagamento.DataSource = dt;
        }

        private void chbpredio_CheckedChanged(object sender, EventArgs e)
        {
            if(chbpredio.Checked)
            {
                tbrua.Text = "AV GUARULHOS";
                tbbairro.Text = "VILA VICENTINA";
            }
            else
            {
                tbrua.Text = "";
                tbbairro.Text = "";
            }
        }

        private void tbvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbvalor.Text.Contains(","))
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

        private void tbtelefone_TextChanged(object sender, EventArgs e)
        {
            string telefone = tbtelefone.Text;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
            con.Open();
            SqlCommand sda = new SqlCommand("SELECT * FROM TODOSPEDIDOS WHERE TELEFONE='" + telefone + "'", con);
            SqlDataReader da = sda.ExecuteReader();
            if (da.Read())
            {
                chbpredio.Enabled = false;
                rua = da.GetValue(7).ToString();
                bairro = da.GetValue(8).ToString();
                numero = da.GetValue(9).ToString();
                taxa = da.GetValue(10).ToString();
                nome = da.GetValue(3).ToString();
                telefone = da.GetValue(4).ToString();

            if (rua == "AV GUARULHOS" && bairro == "VILA VICENTINA")
                {
                    chbpredio.Checked = true;
                }

                tbrua.Text = rua;
                tbbairro.Text = bairro;
                tbnumero.Text = numero;
                tbtaxa.Text = taxa;
                tbnome.Text = nome;
                tbtelefone.Text = telefone;
            }
            objDBAccess.closeConn();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            data = tbdata.Text;
            hora = tbhora.Text;
            telefone = tbtelefone.Text;
            nome = tbnome.Text;
            rua = tbrua.Text;
            bairro = tbbairro.Text;
            numero = tbnumero.Text;
            pagamento = cbpagamento.Text;
            valor = tbvalor.Text;
            taxa = tbtaxa.Text;

            validation.FinalizarPedidoValidation();

            if(validacao == "1")
            {
                SqlCommand InsertCommand = new SqlCommand("INSERT INTO FECHARCAIXA(DATA,HORA,NOME,TELEFONE,VALOR,PAGAMENTO,RUA,BAIRRO,NUMERO,TAXA,DESCRICAO) VALUES(@data, @hora, @nome, @telefone, @valor, @pagamento, @rua, @bairro, @numero, @taxa, @descricao)");
                InsertCommand.Parameters.AddWithValue("@data", data);
                InsertCommand.Parameters.AddWithValue("@nome", nome);
                InsertCommand.Parameters.AddWithValue("@hora", hora);
                InsertCommand.Parameters.AddWithValue("@telefone", telefone);
                InsertCommand.Parameters.AddWithValue("@rua", rua);
                InsertCommand.Parameters.AddWithValue("@bairro", bairro);
                InsertCommand.Parameters.AddWithValue("@numero", numero);
                InsertCommand.Parameters.AddWithValue("@pagamento", pagamento);
                InsertCommand.Parameters.AddWithValue("@valor", valor);
                InsertCommand.Parameters.AddWithValue("@taxa", taxa);
                InsertCommand.Parameters.AddWithValue("@descricao", Home.pedido);

                int row = objDBAccess.executeQuery(InsertCommand);
                if (row == 1)
                {
                    string query = "DELETE FROM PEDIDO";
                    SqlCommand deleteCommand = new SqlCommand(query);
                    int row2 = objDBAccess.executeQuery(deleteCommand);
                    if (row2 != 0)
                    {
                        //LIMPAR VARIAVEL DE DESCRICAO DO PEDIDO
                        Home.limpar_array = "1";
                        //Refresh na sacola da Home
                        Home.refresh = true;
                        //ZERAR VALOR 
                        Home.total = 0;
                        Home.valoritem = 0;
                        Home.registrar = "1";
                        MessageBox.Show("Registro salvo com sucesso!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms["FinalizarPedido"].Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }
    }
}
