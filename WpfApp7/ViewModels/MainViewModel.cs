using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Cache;
using System.Net.Sockets;
using WpfApp7.Models;
namespace WpfApp7.Models
{
    internal class MainViewModels : NotificationObject
    {
        public MainViewModel()
        {
            this.People = Enumerable.Range(0, 100).Select(x => new Person()
            {
                FamilyName = "田中",
                FirstName = x + "太郎",
                Age = x,
                Gender = (x % 2 == 0) ? Gender.Male : Gender.Female,
                IsAuthenticated = x % 3 == 0,
            }).ToList();
        }

        private List<Person> _people;

        public List<Person> People
        {
            get { return this._people; }
            private set { SettingsProperty(ref this._people, value); }
        }
    }

}