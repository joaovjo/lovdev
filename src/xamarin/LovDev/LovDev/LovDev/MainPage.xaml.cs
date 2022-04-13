using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace LovDev
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<UserProfile> _Profiles = new ObservableCollection<UserProfile>();
        public MainPage()
        {
            InitializeComponent();
            CardBinding();
            BindingContext = this;
        }

        public void CardBinding()
        {
            _Profiles.Add(new UserProfile() { Name = "João", Age = "25", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Maria", Age = "20", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "José", Age = "30", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Fernando", Age = "18", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Sofia", Age = "21", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Yuno", Age = "20", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Alex", Age = "25", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Thales", Age = "23", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Abner", Age = "32", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Marcos", Age = "27", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Paulo", Age = "40", Photo = "pic_1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Bruna", Age = "31", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Janaína", Age = "24", Photo = "pic_2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Luana", Age = "22", Photo = "pic_2.jpg" });

        }

        public ObservableCollection<UserProfile> Profile
        {
            get => _Profiles;
            set
            {
                _Profiles = value;
            }
        }

        public class UserProfile
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Photo { get; set; }
        }

    }
}
