using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TransScopeApp.Models;
using TransScopeApp.MyModels;

namespace TransScopeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DadosModel db = new DadosModel();

                DadosModel mydb = new DadosModel();

                db.Pessoa.Add(new Pessoa
                {
                    nome = "MARIA SQL"
                });
                db.SaveChanges();

                db.Pessoa.Add(new Pessoa
                {
                    nome = "MARIA MYSQL"
                });
                db.SaveChanges();

                var o = db.Pessoa.FirstOrDefault(); 

                db.Pessoa.Add(new Pessoa
                {
                    nome = o.nome
                });
                mydb.SaveChanges();


                scope.Complete();
            }
        }
    }
}
