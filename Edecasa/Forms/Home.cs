using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Edecasa.Properties;
using Edecasa.Forms;

namespace Edecasa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        //variaveis globais
        public static string pizza = "0", pizzametade = "0", bebida = "0", outro = "0";//para o form quantidade saber o item / =0 n tem registro
        public static string registrar, datagora,refresh, linhas, pedido, limpar_array; //registrar adicionar valor na label de valor da home / refresh = dar um refresh na sacola
        public static double valoritem, total; //calcular sacola de todos os items
        public static string[] idpedido = new string[200];
        public static string[] nomepedido = new string[200];
        private void btnfechar_Click(object sender, EventArgs e)
        {         
            if(linhas == "0")
            {
                this.Close();
            }
            else
            {
                string query = "DELETE FROM PEDIDO";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void moveSidePanel(Control btn)
        {
            panelsidehome.Top = btn.Top;
            panelsidehome.Height = btn.Height;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AdicionarControlesParaPainel(uch);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            if(linhas == "0")//SE SACOLA ESTIVER VAZIA
            {
                MessageBox.Show("Sacola de pedidos vazia!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "DELETE FROM PEDIDO";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row != 0)
                {
                    limpar_array = "1";
                    txtvalor.Text = "0";
                    total = 0;
                    refresh = "1";
                    MessageBox.Show("Sacola de pedidos limpa!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnajustes_Click(object sender, EventArgs e)
        {
            Ajustes abrirform = new Ajustes();
            abrirform.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            tbpedido.Visible = false;//TEXTBOX ESCONDIDO PARA JUNTAR PEDIDOS DO ARRAY
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=BDEdecasa; User ID=leonardodias;Password= 080108; Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PEDIDO ORDER BY ID ASC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridViewPedido.DataSource = dt;
        }

        private void btnfecharcaixa_Click(object sender, EventArgs e)
        {
            //PASSA PAGAMENTO MOTOQUEIRO PARA VARIAVEL
            string query = "SELECT * FROM MOTOQUEIRO";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count != 0)
            {
                UC_FecharCaixa.motoqueirofixo = dtUsers.Rows[0]["VALOR"].ToString();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            moveSidePanel(btnfecharcaixa);
            UC_FecharCaixa uch = new UC_FecharCaixa();
            AdicionarControlesParaPainel(uch);
        }

        public void AdicionarControlesParaPainel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelprincipal.Controls.Clear();
            panelprincipal.Controls.Add(c);
        }

        private void btnoutros_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnoutros);
            UC_Outros uch = new UC_Outros();
            AdicionarControlesParaPainel(uch);
        }

        private void btnpizzas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnpizzas);
            UC_Pizzas uch = new UC_Pizzas();
            AdicionarControlesParaPainel(uch);
        }

        private void btnbebidas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnbebidas);
            UC_Bebidas uch = new UC_Bebidas();
            AdicionarControlesParaPainel(uch);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = "Data: " + DateTime.Now.ToShortDateString();
            hora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            //PEGAR A QUANTIDADE DE ITENS NA SACOLA
            linhas = DataGridViewPedido.Rows.Count.ToString();
            //registro de pizza
            if (registrar == "1")
            {
                total = total + valoritem;
                txtvalor.Text = total.ToString();
                registrar = "0";
            }     
            //para atualizar sacola
            if (refresh == "1")
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=BDEdecasa;Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PEDIDO ORDER BY ID ASC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridViewPedido.DataSource = dt;
                refresh = "0";
            }
            //LIMPAR VARIAVEL DE DESCRICAO DO PEDIDO
            if(limpar_array == "1")
            {
                for (int i = 0; i <= 199; i++)
                {
                    idpedido[i] = string.Empty;
                    nomepedido[i] = string.Empty;
                }
                tbpedido.Text = string.Empty;
                limpar_array = "0";
            }  
            else if(limpar_array == "2")//LIMPA APENAS A TEXTBOX, PARA CASO O FORM FINALIZARPEDIDO SEJA FECHADO
            {
                tbpedido.Text = string.Empty;
                limpar_array = "0";
            }
        }

        private void DataGridViewPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DELETAR ITEM SACOLA
            string id, nome,valor,quantidade;
            if (DataGridViewPedido.SelectedRows.Count > 0)
            {
                id = DataGridViewPedido.CurrentRow.Cells["ID"].Value.ToString();
                nome = DataGridViewPedido.CurrentRow.Cells["NOME"].Value.ToString();
                valor = DataGridViewPedido.CurrentRow.Cells["VALOR"].Value.ToString();
                quantidade = DataGridViewPedido.CurrentRow.Cells["QUANTIDADE"].Value.ToString();

                string query = "DELETE FROM PEDIDO WHERE NOME='" + nome + "'";
                SqlCommand deleteCommand = new SqlCommand(query);
                int row = objDBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    //APAGAR REGISTRO DA DESCRICAO DA COMPRA
                    idpedido[Convert.ToInt32(id)] = "";
                    nomepedido[Convert.ToInt32(id)] = "";
                    //RESETAR VALOR
                    total = total - (Convert.ToDouble(valor) * Convert.ToDouble(quantidade));
                    txtvalor.Text = total.ToString();
                    refresh = "1";
                    //RESETAR ARRAY CASO A SACOLA FIQUE VAZIA
                    if(linhas == "0")
                    {
                        for (int i = 0; i <= 199; i++)
                        {
                            idpedido[i] = "";
                            nomepedido[i] = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if(txtvalor.Text == "0")
            {
                MessageBox.Show("Por favor, selecione items na lista!", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //COLOCAR NOME DOS PEDIDOS NA DESCRICAO
                for(int i=0; i <= 199;i++)
                {
                    tbpedido.Text = tbpedido.Text + nomepedido[i];
                }
                pedido = tbpedido.Text;
                total = Convert.ToDouble(txtvalor.Text);
                FinalizarPedido abrirform = new FinalizarPedido();
                abrirform.ShowDialog();

            }           
        }
    }
}
