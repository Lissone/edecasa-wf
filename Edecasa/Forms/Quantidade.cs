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

namespace Edecasa
{
    public partial class Quantidade : Form
    {
        public Quantidade()
        {
            InitializeComponent();
        }
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        // FUNÇÃO PARA FAZER FORM SE MEXER
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        string id = UC_Pizzas.idpizza;
        private void Quantidade_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
                //LIMPAR CELULA DO VETOR QUE NAO FOI SELECIONADA
                if(Home.pizza == "1")
                {
                    Home.idpedido[Convert.ToInt32(UC_Pizzas.idpizza)] = "";
                    Home.nomepedido[Convert.ToInt32(UC_Pizzas.idpizza)] = "";
                    Home.pizza = "0";
                }
                else if(Home.bebida == "1")
                {
                    Home.idpedido[Convert.ToInt32(UC_Bebidas.idbebida)] = "";
                    Home.nomepedido[Convert.ToInt32(UC_Bebidas.idbebida)] = "";
                    Home.bebida = "0";
                }
                else if(Home.outro == "1")
                {
                    Home.idpedido[Convert.ToInt32(UC_Outros.iditem)] = "";
                    Home.nomepedido[Convert.ToInt32(UC_Outros.iditem)] = "";
                    Home.outro = "0";
                }
                this.Close();
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string quantidade = numquantidade.Value.ToString();
            if (quantidade.Equals("") | quantidade == "0")
            {
                MessageBox.Show("Por favor, ensira a quantidade do item", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Home.pizza == "1")
                {
                    if (UC_Pizzas.tamanho == "1")
                    {
                        //Registrar pizza BROTO na sacola
                        SqlCommand InsertCommand = new SqlCommand("INSERT INTO PEDIDO(ID,NOME,QUANTIDADE,VALOR) VALUES(@id, @nome, @quantidade, @valor)");
                        InsertCommand.Parameters.AddWithValue("@id", UC_Pizzas.idpizza);
                        InsertCommand.Parameters.AddWithValue("@nome", UC_Pizzas.nomepizza);
                        InsertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                        InsertCommand.Parameters.AddWithValue("@valor", UC_Pizzas.brotopizza);
                        int row = objDBAccess.executeQuery(InsertCommand);
                        if (row == 1)
                        {
                            Home.pizza = "0";
                            Home.registrar = "1";//para calcular o valor na home
                            Home.refresh = "1";//atualizar sacola
                            Home.valoritem = Convert.ToDouble(UC_Pizzas.brotopizza) * Convert.ToDouble(quantidade);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        //registrar pizza grande na sacola
                        SqlCommand InsertCommand = new SqlCommand("INSERT INTO PEDIDO(ID,NOME,QUANTIDADE,VALOR) VALUES(@id, @nome, @quantidade, @valor)");
                        InsertCommand.Parameters.AddWithValue("@id", UC_Pizzas.idpizza);
                        InsertCommand.Parameters.AddWithValue("@nome", UC_Pizzas.nomepizza);
                        InsertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                        InsertCommand.Parameters.AddWithValue("@valor", UC_Pizzas.grandepizza);
                        int row = objDBAccess.executeQuery(InsertCommand);
                        if (row == 1)
                        {
                            Home.pizza = "0";
                            Home.registrar = "1";//para calcular o valor na home
                            Home.refresh = "1";//atualizar sacola
                            Home.valoritem = Convert.ToDouble(UC_Pizzas.grandepizza) * Convert.ToDouble(quantidade);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (Home.bebida == "1")
                {
                    //registrar bebida na sacola
                    SqlCommand InsertCommand = new SqlCommand("INSERT INTO PEDIDO(ID,NOME,QUANTIDADE,VALOR) VALUES(@id, @nome, @quantidade, @valor)");
                    InsertCommand.Parameters.AddWithValue("@id", UC_Bebidas.idbebida);
                    InsertCommand.Parameters.AddWithValue("@nome", UC_Bebidas.nomebebida);
                    InsertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                    InsertCommand.Parameters.AddWithValue("@valor", UC_Bebidas.valorbebida);
                    int row = objDBAccess.executeQuery(InsertCommand);
                    if (row == 1)
                    {
                        Home.bebida = "0";
                        Home.registrar = "1";//para calcular o valor na home
                        Home.refresh = "1";//atualizar sacola
                        Home.valoritem = Convert.ToDouble(UC_Bebidas.valorbebida) * Convert.ToDouble(quantidade);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Home.outro == "1")
                {
                    SqlCommand InsertCommand = new SqlCommand("INSERT INTO PEDIDO(ID,NOME,QUANTIDADE,VALOR) VALUES(@id, @nome, @quantidade, @valor)");
                    InsertCommand.Parameters.AddWithValue("@id", UC_Outros.iditem);
                    InsertCommand.Parameters.AddWithValue("@nome", UC_Outros.nomeitem);
                    InsertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                    InsertCommand.Parameters.AddWithValue("@valor", UC_Outros.valoritem);
                    int row = objDBAccess.executeQuery(InsertCommand);
                    if (row == 1)
                    {
                        Home.outro = "0";
                        Home.registrar = "1";//para calcular o valor na home
                        Home.refresh = "1";//atualizar sacola
                        Home.valoritem = Convert.ToDouble(UC_Outros.valoritem) * Convert.ToDouble(quantidade);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
