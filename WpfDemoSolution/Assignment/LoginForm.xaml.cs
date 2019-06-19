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
using System.Windows.Shapes;

using System.Collections.ObjectModel;
namespace WpfDemoSolution.Assignment
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        private ObservableCollection<LoginFormClass> _list;
        public LoginForm()
        {
            InitializeComponent();
            _list = new ObservableCollection<LoginFormClass>();
           // _list.Add(new LoginFormClass("jon", 25, "black"));
            this.DataContext = _list;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            _list.Add(new LoginFormClass(username.Text, Convert.ToInt32(age.Text), color.Text));
            username.Text = "";
            age.Text = "";
            color.Text = "";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            username.Text = "";
            age.Text = "";
            color.Text = "";
        }

    }
}
