using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CadastroEscola.Database;
using CadastroEscola.Helpers;

namespace CadastroEscola.Models
{
    internal class EscolaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Escola cadastro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO escola VALUES " +
                "(null, @nome, @razao, @cnpj, @inscricao, @tipo, @data_cricao, @resp, @resp_tel, " +
                "@email, @telefone, @rua, @numero, @bairro, @complemento, @cep, @cidade, @estado);";

                comando.Parameters.AddWithValue("@nome", cadastro.Nome);
                comando.Parameters.AddWithValue("@razao", cadastro.Razao);
                comando.Parameters.AddWithValue("@cnpj", cadastro.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", cadastro.Inscricao_est);
                comando.Parameters.AddWithValue("@tipo", cadastro.Tipo);
                comando.Parameters.AddWithValue("@data_cricao", cadastro.Data_criacao?.ToString("yyyy-MM-dd"));

                comando.Parameters.AddWithValue("@resp", cadastro.Responsavel);
                comando.Parameters.AddWithValue("@resp_tel", cadastro.Telefone_res);
                comando.Parameters.AddWithValue("@email", cadastro.Email);
                comando.Parameters.AddWithValue("@telefone", cadastro.Telefone_esc);
                comando.Parameters.AddWithValue("@rua", cadastro.Rua);
                comando.Parameters.AddWithValue("@numero", cadastro.Numero);
                comando.Parameters.AddWithValue("@bairro", cadastro.Bairro);
                comando.Parameters.AddWithValue("@complemento", cadastro.Complemento);
                comando.Parameters.AddWithValue("@cep", cadastro.Cep);
                comando.Parameters.AddWithValue("@cidade", cadastro.Cidade);
                comando.Parameters.AddWithValue("@estado", cadastro.Estado);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Escola> List()
        {
            try
            {
                var lista = new List<Escola>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM escola_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var cadastro = new Escola();

                    cadastro.Id = reader.GetInt32("id_esc");
                    cadastro.Nome = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    cadastro.Razao = DAOHelper.GetString(reader, "razao_social_esc");
                    cadastro.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    cadastro.Inscricao_est = DAOHelper.GetString(reader, "insc_estadual_esc");
                    cadastro.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    cadastro.Data_criacao = DAOHelper.GetDateTime(reader, "cricao-esc");

                    cadastro.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    cadastro.Telefone_res = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    cadastro.Email = DAOHelper.GetString(reader, "email_esc");
                    cadastro.Telefone_esc = DAOHelper.GetString(reader, "telefone_esc");
                    cadastro.Numero = DAOHelper.GetString(reader, "numero_esc");
                    cadastro.Bairro = DAOHelper.GetString(reader, "bairro_esc");
                    cadastro.Complemento = DAOHelper.GetString(reader, "complemento_esc");
                    cadastro.Cep = DAOHelper.GetString(reader, "cep_esc");
                    cadastro.Cidade = DAOHelper.GetString(reader, "cidade_esc");
                    cadastro.Estado = DAOHelper.GetString(reader, "estado_esc");

                    lista.Add(cadastro);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
