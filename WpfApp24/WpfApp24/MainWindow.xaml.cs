using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace WpfApp24
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bSubmit.IsEnabled = false;
            ListUsers.Height = windowMain.Height;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(nameUser.Text,$"+{numberPhone.Text}");
            ListUsers.Items.Add(user);
            ListUsers.Items.Refresh();
        }

        private void numberPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool name = false;
            bool number = false;
            if (nameUser.Text.Length > 3)
            {
                name = true;
            } else
            {
                name = false;
            }
            if (long.TryParse(numberPhone.Text, out long num) & numberPhone.Text.Length == 11)
            {
                number = true;
            }
            else
            {
                number = false;
            }
            if (number & name)
            {
                bSubmit.IsEnabled = true;
            }
            else
            {
                bSubmit.IsEnabled = false;
            }
            //meta.Content = $"{long.MaxValue}\n{numberPhone.Text.Length}";
        }

        private void bRandom_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            string[] maleNames = { "Иван", "Петр", "Александр", "Дмитрий", "Андрей", "Михаил", "Сергей", "Николай", "Владимир", "Алексей", "Игорь", "Олег", "Артем", "Константин", "Григорий"};

            string[] maleSurnames = { "Иванов", "Петров", "Смирнов", "Кузнецов", "Соколов", "Попов", "Лебедев", "Козлов", "Новиков", "Морозов", "Павлов", "Волков", "Богданов", "Федоров", "Медведев"};

            int[] nums = new int[11];
            nums[0] = 7;
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = r.Next(0, 9);
            }
            numberPhone.Text = $"{String.Join("",nums)}";
            nameUser.Text = $"{maleNames[r.Next(maleNames.Length)]} {maleSurnames[r.Next(maleSurnames.Length)]}";
        }

        private void bReset_Click(object sender, RoutedEventArgs e)
        {
            numberPhone.Text = "";
            nameUser.Text = "";
        }

        private void windowMain_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            ListUsers.Height = windowMain.Height;
        }

        private void windowMain_StateChanged(object sender, EventArgs e)
        {
                ListUsers.Height = windowMain.Height;
            //if (windowMain.WindowState == WindowState.Maximized)
            //{
            //}
        }
    }
}
