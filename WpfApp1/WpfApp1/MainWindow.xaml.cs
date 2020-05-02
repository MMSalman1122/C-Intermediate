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
            //sender. you cant see any properties about button
           var button= (Button)sender;
            // button. now we have accses to all properties
            var button2 = sender as Button;
            if (button2 != null)
            {
               MessageBox.Show(button2.ActualHeight.ToString());
            }
            MessageBox.Show("Hellow World");
        }
    }
}
