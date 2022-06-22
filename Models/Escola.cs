using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscola.Models
{
    internal class Escola
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Razao { get; set; }

        public string Cnpj { get; set; }

        public string Inscricao_est { get; set; }

        public string Tipo { get; set; }

        public DateTime? Data_criacao { get; set; }

        public string Responsavel { get; set; }

        public string Telefone_res { get; set; }

        public string Email { get; set; }

        public string Telefone_esc { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        /*
                 id_esc int primary key auto_increment,
nome_fantasia_esc varchar (300) not null,
razao_social_esc varchar (300) not null,
cnpj_esc varchar (300) not null,
insc_estadual_esc varchar (300) not null,
tipo_esc varchar (300) not null,
data_criacao_esc date not null,
responsavel_esc varchar (300) not null,
responsavel_telefone_esc varchar (300) not null,
telefone_esc varchar (300) not null,
email_esc varchar (300) not null,
rua_esc varchar (300),
bairro_esc varchar (300),
numero_esc int,
cep_esc varchar (300),
complemento_esc varchar (300),
cidade_esc varchar (300),
estado_esc varchar (300)
                 */

        public string RdTipo { get; set; }
        public void SetRdTipo(bool rdTipo)
        {
            this.RdTipo = rdTipo == true ? "Publica" : "Privada";
        }
    }
}
