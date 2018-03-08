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
    public partial class Form_Detalhes : Form
    {
        private String Nome;

        public Form_Detalhes()
        {
            InitializeComponent();
        }

        private void Form_Detalhes_Load(object sender, EventArgs e)
        {
            //Inicia o combo o valor do primeiro item.
            cbTipo.SelectedIndex = 0;

            textNome.Text = Nome;

            buscarDados();
            configurarDataGrid();
            buscarDadosTelefone();
        }

        public void setNome(String Nome)
        {
            this.Nome = Nome;
        }

        //Remover Email Profissional
        private void butRemovPR_Click(object sender, EventArgs e)
        {
            String sql;
            sql = "update tb_usuario set emailprofissional = '--' where Nome = '" + textNome.Text + "'";
            DAO.remover(sql);
        }

        //Remover Email Pessoal
        private void butRemovPE_Click(object sender, EventArgs e)
        {
            String sql;
            sql = "update tb_usuario set emailpessoal = '--' where Nome = '" + textNome.Text + "'";
            DAO.remover(sql);
        }

        //Remover Contato
        private void button1_Click(object sender, EventArgs e)
        {
            String sql;
            sql = "Delete from tb_telefone where fk_nome = '" + textNome.Text + "'";
            DAO.remover(sql);
            sql = "Delete from tb_usuario where nome = '" + textNome.Text + "'";
            DAO.remover(sql);
        }

        private void buscarDados()
        {
            String sql;
            sql = "Select datanascimento, emailprofissional, emailpessoal from tb_usuario";

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
                dtpNascimento.Text = leitor.GetValue(0).ToString();
                textEmailProfissional.Text = leitor.GetValue(1).ToString();
                textEmailPessoal.Text = leitor.GetValue(2).ToString();

            }
            //Fecho conexão 
            comm.Connection.Close();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarDadosTelefone()
        {
            String sql;
            sql = "Select telefone, tipo from tb_telefone where fk_nome = '" + textNome.Text + "'";

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
                dgvTelefones.Rows.Add(linhaDados);

            }
            //Fecho conexão 
            comm.Connection.Close();
        }

        private void configurarDataGrid()
        {
            //Redimencionar a altura dos cabeçalhos das colunas.
            dgvTelefones.AutoResizeColumnHeadersHeight();

            //Redimensionar todas as alturas das linhas para ajustar o conteúdo de todas as células não-cabeçalho.
            dgvTelefones.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders);
            dgvTelefones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Declara a contagem de Colunas.
            dgvTelefones.ColumnCount = 4;
            dgvTelefones.ColumnHeadersVisible = true;

            //Define o nome das colunas.
            dgvTelefones.Columns[0].Name = "Telefone";
            dgvTelefones.Columns[1].Name = "Tipo";

            buscarDados();
        }

        //Remover telefone
        private void butRemoverTelefone_Click(object sender, EventArgs e)
        {
            String a = dgvTelefones.CurrentRow.Cells[0].Value.ToString();
            String sql;
            sql = "delete tb_telefone where telefone = '" + a + "'";
            DAO.remover(sql);

            buscarDados();
            configurarDataGrid();
            buscarDadosTelefone();
        }
    }
}
