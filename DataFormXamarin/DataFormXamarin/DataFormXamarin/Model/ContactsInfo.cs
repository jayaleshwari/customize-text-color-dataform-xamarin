using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataFormXamarin
{
    public class ContactsInfo : INotifyPropertyChanged
    {
        private string firstName;
        private string email;
        private string password;
        private string confirmPassword;
        private string address;

        public ContactsInfo()
        {

        }

        public string FullName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                this.RaiseOnPropertyChanged("FullName");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.RaiseOnPropertyChanged("Email");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                this.RaiseOnPropertyChanged("Password");
            }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if(confirmPassword != value)
                {
                    confirmPassword = value;
                    this.RaiseOnPropertyChanged("Password");
                }
            }
        }

        [DataType(DataType.MultilineText)]
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    this.RaiseOnPropertyChanged("Address");
                }
            }
        }


        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke method when property changed.
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
