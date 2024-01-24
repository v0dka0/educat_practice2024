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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackBut_Click(object sender, RoutedEventArgs e)
        {
            if (MainF.CanGoBack) MainF.GoBack();
        }

        private void MainF_Navigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            this.Title = $"Melnikov_520 - {page.Title}";

            if (page is Pages.AuthPage)
                BackBut.Visibility = Visibility.Hidden;
            else
                BackBut.Visibility = Visibility.Visible;
        }
    }
}
