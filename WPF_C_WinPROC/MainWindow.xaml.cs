using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPF_C_WinPROC
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(ExitButton))
            {
                Environment.Exit(1);
            }
            else if (sender.Equals(DisplayButton))
            {
                if (HelloButton.IsChecked == true)
                {
                    const string message = "Hello";
                    const string caption = "Message";
                    MessageBox.Show(message, caption, MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else if (GoodbyeButton.IsChecked == true)
                {
                    const string message = "Goodbye";
                    const string caption = "Message";
                    MessageBox.Show(message, caption, MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
            else if (sender.Equals(UserInputButton))
            {
                const string message = "Hello user!";
                const string caption = "Hello!";
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Exclamation,
                    MessageBoxResult.OK);
            }


        }

        private void AppExit_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(AppExit))
            {
                Environment.Exit(1);
            }
            //throw new NotImplementedException();
        }

        private void MenuItem_File_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem_Help_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
