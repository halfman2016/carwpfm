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
using WpfApp1;

namespace carm
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private  carmangerContext context;
        public Login()
        {
            InitializeComponent();
            context = new carmangerContext();

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var usr = txtUsr.Text;
            var pwd = txtPwd.Password;
            try
            {
                //var context = new carmangerContext();
                var res = context.Sysusers.Where(s => s.Username == usr && s.Password == pwd);
                if (res.Count() == 0)
                {
                    MessageBox.Show("找不到合法用户！");
                }
                else
                {
                    MainWindow main = new MainWindow();
                    this.Hide();
                    main.Show();
                }
            }
            catch (Exception)
            {


                MessageBox.Show("找不到服务器！");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                object ss=new object();
                RoutedEventArgs ee=new RoutedEventArgs();
                Button_Click(ss, ee);
            }
        }
    }
}
