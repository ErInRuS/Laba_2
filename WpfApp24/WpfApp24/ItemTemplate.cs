using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp24
{
    internal class ItemTemplate : ListViewItem
    {
        private User user;
        public ItemTemplate(User user)
        {
            this.user = user;

        }
        public void Update()
        {

        }

    }
}
