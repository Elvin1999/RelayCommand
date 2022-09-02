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
using WpfApp3.Commands;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RelayCommand MessageCommand { get; set; }
        public RelayCommand SendCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            int age = 20;
            MessageCommand = new RelayCommand(Display, param =>
              {
                  return age >= 10;
              });


            SendCommand = new RelayCommand(Send);
        }


        public void Display(object obj = null)
        {
            MessageBox.Show("hello from Display Relay Command");
        }

        public void Send(object obj = null)
        {
            MessageBox.Show("hello from SEND Relay Command");
        }
    }
}
