using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPGGameWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool inGame;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            inGame = false;
            MenuPanel.Visibility = Visibility.Collapsed;
            ClassPanel.Visibility = Visibility.Visible;
            GamePanel.Visibility = Visibility.Collapsed;
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            //fájlból való betöltés
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Archer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            inGame = false;
            MenuPanel.Visibility = Visibility.Visible;
            ClassPanel.Visibility = Visibility.Collapsed;
            GamePanel.Visibility = Visibility.Collapsed;

        }

        private void ShowGame()
        {
            inGame = true;
            MenuPanel.Visibility = Visibility.Collapsed;
            ClassPanel.Visibility = Visibility.Collapsed;
            GamePanel.Visibility = Visibility.Visible;
        }
    }
}