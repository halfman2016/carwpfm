using carm;
using carm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private carmangerContext context;
        private IEnumerable<Forceins> Forceins;


        public MainWindow()
        {
            InitializeComponent();
            context = new carmangerContext();


        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window win in Application.Current.Windows)
            {
                if(win.GetType().Name=="Login") win.Show();
                                    
            }
        }

        public class Carlist
        {
            public string name { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}