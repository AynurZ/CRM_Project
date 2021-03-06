﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
    public class Team : INotifyPropertyChanged
    {
        private uint id;
        private string name;

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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public virtual ICollection<TeamProjectMM> TeamProjectMMs
        {
            get
            {
                return TeamProjectMMs;
            }
            set
            {
                TeamProjectMMs = value;
                OnPropertyChanged("TeamProjectMMs");
            }
        }

        public virtual ICollection<TeamUserMM> TeamUserMMs
        {
            get
            {
                return TeamUserMMs;
            }
            set
            {
                TeamUserMMs = value;
                OnPropertyChanged("TeamUserMMs");
            }
        }

        public virtual ICollection<Team> Teams
        {
            get
            {
                return Teams;
            }
            set
            {
                Teams = value;
                OnPropertyChanged("Teams");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
