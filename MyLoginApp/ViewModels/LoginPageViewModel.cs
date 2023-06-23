using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginApp.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _userName;
        [ObservableProperty]
        public string _password;
        [ICommand]
        public async void Login()
        {

        }
    }
}
