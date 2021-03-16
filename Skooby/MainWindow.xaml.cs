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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Skooby
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

        private void txt_email_LostFocus(object sender, RoutedEventArgs e)
        {
            if(txt_email.Text.Trim()!=string.Empty)
            {
                img_emailcheck.Visibility = Visibility.Visible;
                email_path.Stroke= Brushes.Green;
            }
        }

        private void txt_pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if(txt_pass.Password.Trim()!="admin")
            {

                Storyboard s = (Storyboard)TryFindResource("Animate");
                s.Begin();
                img_passcncel.Visibility = Visibility.Visible;
                img_passcheck.Visibility = Visibility.Hidden;
                pass_path.Stroke = Brushes.Red;
                txt_pass.Foreground= Brushes.Red;
            }
            else
            {
                img_passcncel.Visibility = Visibility.Hidden;
                img_passcheck.Visibility = Visibility.Visible;
                pass_path.Stroke = Brushes.Green;
            }
        }
    }
}
