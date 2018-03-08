using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Clientes
{
    class Cliente
    {
        private String Nome, DataNascimento, EmailProfissional, EmailPessoal, Telefone, Tipo;

        //Seta o Nome
        public void setNome(String Nome)
        {
            this.Nome = Nome;
        }

        //Seta a Data de Nascimento
        public void setDataNascimento(String DataNascimento)
        {
            this.DataNascimento = DataNascimento;
        }

        //Seta o Email Profissional
        public void setEmailProfissional(String EmailProfissional)
        {
            this.EmailProfissional = EmailProfissional;
        }

        //Seta o Email Pessoal
        public void setEmailPessoal(String EmailPessoal)
        {
            this.EmailPessoal = EmailPessoal ;
        }

        //Seta o Telefone
        public void setTelefone(String Telefone)
        {
            this.Telefone = Telefone;
        }

        //Seta o Tipo do Telefone
        public void setTipo(String Tipo) {
            this.Tipo = Tipo;
        }

        //Inseri os dados no banco
        public void inserir()
        {
            String sql;
            sql = "Insert into tb_usuario values ('" +
                Nome + "', '" + DataNascimento + "', '" +
                EmailProfissional + "', '" + EmailPessoal + "')";

            DAO.gravar(sql);
        }

        //Metodo para adicionar os telefones no banco.
        public void insertTelefoneTipo(ArrayList array) {

            for(int i = 0; i < array.Count; i+=2)
            {
                String sql = "Insert into tb_telefone values ('" + array[i] + "', '" +
                    array[i+1] + "', '" + Nome + "')";
                DAO.gravar(sql);
            }
            
        }
    }
}
