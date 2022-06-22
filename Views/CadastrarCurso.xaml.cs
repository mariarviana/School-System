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
using MySql.Data.MySqlClient;


namespace CadastroEscola.Views
{
    /// <summary>
    /// Lógica interna para CadastrarEscola.xaml
    /// </summary>
    public partial class CadastrarEscola : Window
    {
        private Curso _cadastro = new Curso();
        public CadastrarEscola()
        {
            InitializeComponent();
        }

         private void Button_Click(object sender, RoutedEventArgs e)
        {
            _cadastro.Nome = txtNome.Text;
            _cadastro.Turno = cbTurno.Text;
            _cadastro.CargaHoraria = txtCargaHoraria.Text;
            _cadastro.Descricao = txtDescricao.Text;

            try
            {
                var dao = new CursoDAO();
                dao.Insert(_cadastro);

                MessageBox.Show("Registro de curso cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ListarCurso cha = new ListarCurso();
            cha.ShowDialog();
        }
    }
}
