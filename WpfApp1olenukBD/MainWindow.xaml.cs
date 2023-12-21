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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLite;


namespace WpfApp1olenukBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persons> persons;
        public MainWindow()
        {
            InitializeComponent();
            persons = new List<Persons>();
            GetContacts();
        }
        private void new_persons_Click(object sender, RoutedEventArgs e)
        {
            Newperson newContactWindow = new Newperson();
            //NewContactWindow newContactWindow = new NewContactWindow();
            newContactWindow.ShowDialog();
            GetContacts();
            
        }
        void GetContacts()
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                connection.CreateTable<Persons>();
                persons = connection.Table<Persons>().ToList().OrderBy(c => c.Name).ToList();

            }


            if (persons != null)
            {
                list.ItemsSource = persons;
            }

        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persons? selectedContact = list.SelectedItem as Persons;

            if (selectedContact != null)
            {
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();

                GetContacts();
            }

        }
    }
}
