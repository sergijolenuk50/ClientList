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
using SQLite;
//using WpfApp1olenukBD.Data.Models;

namespace WpfApp1olenukBD
{
    /// <summary>
    /// Interaction logic for ContactDetailsWindow.xaml
    /// </summary>
    public partial class ContactDetailsWindow : Window
    {
        Persons selectedContact;
        public ContactDetailsWindow(Persons selectedContact)
        {
            InitializeComponent();
            this.selectedContact = selectedContact;
            nameTextBox.Text = this.selectedContact.Name;
            emailTextBox.Text = this.selectedContact.Mail;
            phoneTextBox.Text = this.selectedContact.PhoneNumber;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            selectedContact.Name = nameTextBox.Text;
            selectedContact.Mail = emailTextBox.Text;
            selectedContact.PhoneNumber = phoneTextBox.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Persons>();
                conn.Update(selectedContact);
            }

            Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Persons>();
                conn.Delete(selectedContact);     
            }

            Close();
        }

    }
}
