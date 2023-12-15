using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1olenukBD
{
    internal class Persons 
        //: INotifyPropertyChanged
    {
        //Newperson newperson = new Newperson();

        public Persons() {

           // InitializeComponent();
        }
        private string name;
        private string mail;
        private string phone_number;

        // public event PropertyChangedEventHandler? PropertyChanged;

        public string Name
        {
            get { return name; }
            set {  name = value;
                //OnPropertyChanged();
            }
        } 
        public string Mail 
        {
            get { return mail; }
            set { mail = value; }
        }
        public string PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged([CallerMemberName] string propName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}
    }
}
