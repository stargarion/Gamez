using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoSolution.Assignment
{
    public class LoginFormClass
    {
        string _userName;
        int _age;
        string _color;

        public LoginFormClass(string userName, int age, string color)
        {
            _userName = userName;
            _age = age;
            _color = color;
        }

        public string UserName
        {
            set
            {
                _userName = value;
            }
            get
            {
                return _userName;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}
