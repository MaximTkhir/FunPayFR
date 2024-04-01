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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunPayFR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FunPayMTEntities FunPayMT = new FunPayMTEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.Clients.ToList();
        }

        private void ReviewsButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.Reviews.ToList();
        }

        private void SellersButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.Sellers.ToList();
        }

        private void SupportEmailButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.SupportEmails.ToList();
        }

        private void SupportPhonesButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.SupportPhones.ToList();
        }

        private void SupportTeamButton_Click(object sender, RoutedEventArgs e)
        {
            DataFunPayTable.ItemsSource = FunPayMT.SupportTeam.ToList();
        }
    }
}
