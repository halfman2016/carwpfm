using carmins.Models;
using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;

namespace carmins.Pages
{
    class LoginViewModel:Screen
    {
        public carmangerContext carmangerContext= new carmangerContext();
        public string UserName { get; set; }
        public string Password { get; set; }
        private readonly IWindowManager _windowManager;


        public void Login()
        {
            ;
            try
            {
                var res = carmangerContext.Sysusers.Where(s => s.Username == UserName && s.Password == Password);
                if (res.Count() == 0)
                {
                    _windowManager.ShowMessageBox("找不到合法用户！");
                }
                else
                {
                   // MainWindow main = new MainWindow();
                   // this.Hide();
                    //main.Show();
                }
            }
            catch (Exception)
            {


                //MessageBox.Show("找不到服务器！");
                _windowManager.ShowMessageBox("找不到服务器");

            }

        }
        public bool CanLogin() => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password);
        public LoginViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }
    }
}
