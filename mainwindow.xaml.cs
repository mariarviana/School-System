using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CadastroEscola.Models;

namespace CadastroEscola.Views
{
    /// <summary>
    /// Lógica interna para CadastroEscola.xaml
    /// </summary>
    public partial class CadastroEscola : Window
    {
        private Escola _cadastro = new Escola();

        public CadastroEscola()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            _cadastro.Nome = txtbox_nome.Text;
            _cadastro.Razao = txtbox_razao.Text;
            _cadastro.Cnpj = txtbox_cnpj.Text;
            _cadastro.Inscricao_est = txtbox_inscriacaoestadual.Text;

            _cadastro.Tipo = "Pública";
            if ((bool)rd_prive.IsChecked)
                _cadastro.Tipo = "Privada";

            _cadastro.Data_criacao = dp_data.SelectedDate;
            _cadastro.Responsavel = txt_responsavel.Text;
            _cadastro.Telefone_res = txt_telefoneres.Text;
            _cadastro.Email = txt_email.Text;
            _cadastro.Telefone_esc = txt_telefone.Text;
            _cadastro.Rua = txt_rua.Text;
            _cadastro.Numero = txt_numero.Text;
            _cadastro.Bairro = txt_bairro.Text;
            _cadastro.Complemento = txt_complemento.Text;
            _cadastro.Cep = txt_cep.Text;
            _cadastro.Cidade = txt_cidade.Text;
            _cadastro.Estado = cb_estado.Text;



            try
            {
                var dao = new EscolaDAO();
                dao.Insert(_cadastro);

                MessageBox.Show("Registro de escola cadastrado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
