﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
    public class Note : INotifyPropertyChanged
    {
        private uint id;
        private string noteName;
        private uint idUser;

        public uint ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string NoteName
        {
            get
            {
                return noteName;
            }
            set
            {
                noteName = value;
                OnPropertyChanged("NoteName");
            }
        }

        [ForeignKey("idUser")]
        public virtual User User
        {
            get
            {
                return User;
            }
            set
            {
                User = value;
                OnPropertyChanged("User");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
