using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp24
{
    internal class User
    {
        public User(string name, string numer)
        {
            Name = name;
            Numer = numer;
        }

        public string Name { get; set; }
        public string Numer { get; set; }


    }
}
