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

using RadioApp;

namespace RadioInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Radio _radio = new Radio();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Channel_Click(object sender, RoutedEventArgs e)
        {
            string channel = (sender as Button).Content.ToString();
            int channelInt = Int16.Parse(channel);

            _radio.Channel = channelInt;

            Channel_Display.Text = _radio.Play();
        }

        private void Swtich_Click(object sender, RoutedEventArgs e)
        {
            _radio.On = !_radio.On;
            
            if (_radio.On)
            {
                Status_Display.Text = "ON";
                Status_Display.Background = Brushes.Green;
            }
            else
            {
                Status_Display.Text = "OFF";
                Status_Display.Background = Brushes.Red;
            }
        }
    }
}
