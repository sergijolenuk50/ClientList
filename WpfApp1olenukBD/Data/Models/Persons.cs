using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1olenukBD
{
    public class Persons 
    {
        //: INotifyPropertyChanged
        //Newperson newperson = new Newperson();
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Mail} - {PhoneNumber}";
        }
        //public Persons()
        //{

        //    InitializeComponent();
        //}

        //private string name;
        //private string mail;
        //private string phone_number;
        ////[PrimaryKey, AutoIncrement]

        ////private void InitializeComponent()
        ////{
        ////    throw new NotImplementedException();
        ////}


        //// public event PropertyChangedEventHandler? PropertyChanged;

        //public string Name
        //{
        //    get { return name; }
        //    set {  name = value;
        //        //OnPropertyChanged();
        //    }
        //} 
        //public string Mail 
        //{
        //    get { return mail; }
        //    set { mail = value; }
        //}
        //public string PhoneNumber
        //{
        //    get { return phone_number; }
        //    set { phone_number = value; }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged([CallerMemberName] string propName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        //}
    }
}
