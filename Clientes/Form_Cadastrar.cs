using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class Form_Cadastrar : Form
    {
        //Instânciando um objeto Cliente.
        private Cliente cliente = new Cliente();
        private ArrayList arrayDadosTelefone = new ArrayList();

        public Form_Cadastrar()
        {
            InitializeComponent();
            configurarDataGrid();
        }

        private void Form_Cadastrar_Load(object sender, EventArgs e)
        {   //Inicia o combo o valor do primeiro item.
            cbTipo.SelectedIndex = 0;

        }

        private void configurarDataGrid() {
            //Redimencionar a altura dos cabeçalhos das colunas.
            dgvTelefones.AutoResizeColumnHeadersHeight();

            //Redimensionar todas as alturas das linhas para ajustar o conteúdo de todas as células não-cabeçalho.
            dgvTelefones.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders);

            //Declara a contagem de Colunas.
            dgvTelefones.ColumnCount = 2;
            dgvTelefones.ColumnHeadersVisible = true;

            //Define o nome das colunas.
            dgvTelefones.Columns[0].Name = "Telefone";
            dgvTelefones.Columns[1].Name = "Tipo";
        }

        //Metodo para validar se o email é valido
        private Boolean valdiarEmail(String Email)
        {
            Boolean ValidEmail = false;
            int indexArr = Email.IndexOf("@");

            if(indexArr > 0)
            {
                if(Email.IndexOf("@", indexArr + 1) > 0)
                {
                    return ValidEmail;
                }

                int indexDot = Email.IndexOf(".", indexArr);
                if (indexDot + 1 < Email.Length) {
                    String indexDot2 = Email.Substring(indexDot + 1, 1);
                    if(indexDot2 != ".")
                    {
                        ValidEmail = true;
                    }
                }
            }

            return ValidEmail;
        }

        private Boolean validarTelefone(String Telefone)
        {
            Boolean resultado = true;
            if (Telefone == "        -")
            {
                return false;
            }
            else
            {
                return resultado;
            }
        }

        private void butAdicionar_Click(object sender, EventArgs e)
        {
            if (validarTelefone(maskedTextTelefone.Text))
            {
                //Exibi os numero adicionados.
                dgvTelefones.Rows.Add(maskedTextTelefone.Text, cbTipo.Text);

                //Adiconar os dados do telefone e tipo ao arraylisst.
                arrayDadosTelefone.Add(maskedTextTelefone.Text);
                arrayDadosTelefone.Add(cbTipo.Text);

            }
            else
            {
                cliente.setTelefone("--");
                cliente.setTipo("--");
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adicionando valores ao objeto Cliente.
            if(textNome.Text == "") {
                MessageBox.Show("Por Favor Preechar o Campo Nome!");
                textNome.Focus();
            }
            else
            {
                cliente.setNome(textNome.Text);
            }
            
            cliente.setDataNascimento(dtpNascimento.Text);

            if (valdiarEmail(textEmailProfissional.Text))
            {
                cliente.setEmailProfissional(textEmailProfissional.Text);
            }
                else
            {
                cliente.setEmailProfissional("--");
            }
            if (valdiarEmail(textEmailPessoal.Text))
            {
                cliente.setEmailPessoal(textEmailPessoal.Text);
            }
                else
            {
                cliente.setEmailPessoal("--");
            }

            cliente.inserir();
            cliente.insertTelefoneTipo(arrayDadosTelefone);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //Fecha a tela de cadastro.
            Close();
        }
    }
}
