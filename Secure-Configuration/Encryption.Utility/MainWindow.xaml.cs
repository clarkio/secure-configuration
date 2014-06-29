using Samples.AspNet.ProtectedConfiguration;
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

namespace Encryption.Utility
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

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            EncryptionUtility.EncryptConnectionStringsSection(InputFileTextBox.Text);
        }

        private void CreateKey_Click(object sender, RoutedEventArgs e)
        {
            TripleDESProtectedConfigurationProvider provider = new TripleDESProtectedConfigurationProvider();
            provider.CreateKey(@"..\..\Keys\keys.txt");
        }
    }
}
