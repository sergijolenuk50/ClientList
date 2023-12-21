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
using System.Data;
using System.Data.Common;
using SQLite;

namespace WpfApp1olenukBD
{
    /// <summary>
    /// Interaction logic for Newperson.xaml
    /// </summary>
    public partial class Newperson : Window
    {
        public Newperson()
        {
            InitializeComponent();
        }
        //string Name = last_name;
        //string Mail;
        //int Phone_number;
        private void add_person_Click(object sender, RoutedEventArgs e)
        {
            Persons persons = new Persons
            {
                Name = last_name.Text,
                Mail = mail.Text,
                PhoneNumber = phone_number.Text,

            };

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Persons>();
                connection.Insert(persons);

            }

            Close();
        }
    }
}
