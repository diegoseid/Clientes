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

namespace Clientes
{
    public partial class Form_Principal : Form
    {
        Cliente cliente = new Cliente();

        public Form_Principal()
        {
            InitializeComponent();
            configurarDataGrid();
         
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void menuCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Form_Cadastrar formCadastrar = new Form_Cadastrar();
            formCadastrar.Show();
        }

        private void configurarDataGrid()
        {
            //Redimencionar a altura dos cabeçalhos das colunas.
            dGVPrincipal.AutoResizeColumnHeadersHeight();

            //Redimensionar todas as alturas das linhas para ajustar o conteúdo de todas as células não-cabeçalho.
            dGVPrincipal.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders);
            dGVPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Declara a contagem de Colunas.
            dGVPrincipal.ColumnCount = 4;
            dGVPrincipal.ColumnHeadersVisible = true;

            //Define o nome das colunas.
           dGVPrincipal.Columns[0].Name = "Nome";
           dGVPrincipal.Columns[1].Name = "Telefone";
            dGVPrincipal.Columns[2].Name = "Tipo";
           dGVPrincipal.Columns[3].Name = "Email";

            buscarDados();
        }

        private void buscarDados()
        {
            String sql;
            sql = "Select distinct usu.Nome,  tel.telefone, tel.tipo," +
                " usu.emailpessoal from tb_usuario usu" +
                " join tb_telefone tel on usu.nome = tel.fk_nome order by nome asc";

            SqlCommand comm = new SqlCommand();
            comm.Connection = DAO.abrir();
            comm.CommandText = sql;
            SqlDataReader leitor = comm.ExecuteReader();

            int nColunas = leitor.FieldCount;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[nColunas];

            //percorre o DataRead
            while (leitor.Read())
            {
                //percorre cada uma das colunas
                for (int a = 0; a < nColunas; a++)
                {
                        linhaDados[a] = leitor.GetString(a).ToString();
                }

                //atribui a linha ao datagridview
                dGVPrincipal.Rows.Add(linhaDados);

            }
        //Fecho conexão 
        comm.Connection.Close();
        }

        public void dGVPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nome = dGVPrincipal["Nome", e.RowIndex].Value.ToString();
            Form_Detalhes formDetalhes = new Form_Detalhes();
            formDetalhes.setNome(Nome);
            formDetalhes.Show();
        }

        private void dGVPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
