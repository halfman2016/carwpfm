using carm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace carm.Win
{
    /// <summary>
    /// Admin.xaml 的交互逻辑
    /// </summary>
    public partial class Admin : Window
    {
        private IEnumerable<Orgs> orgs;
        
        public Admin()
        {
            InitializeComponent();

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            foreach (Window win in Application.Current.Windows)
            {
                if (win.GetType().Name == "Login") win.Show();

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = Common.username;
            Orgs org= Common.cardb.Orgs.Single(b => b.Idorgs == Common.orgid);
            
        }
    }
}
