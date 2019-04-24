using SolidGoldApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SolidGoldApp.ViewModels
{
    public class NewUserViewModel : BaseViewModel
    {
        private PasswordValidation validator = new PasswordValidation();
        private string username;
        public string Username {
            get { return username;  }
            set
            {
                if (username.Equals(value))
                    return;
                username = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password {
            get { return password; }
            set
            {
                if (password.Equals(value))
                    return;
                password = value;
                OnPropertyChanged();
            }
        }
        
        private string reenteredPassword;
        public string ReenteredPassword
        {
            get { return reenteredPassword; }
            set
            {
                if (reenteredPassword == value)
                    return;
                reenteredPassword = value;
                OnPropertyChanged();
            }
        }

        public Command SubmitNewUserCommand { get; set; }

        public NewUserViewModel()
        {
            SubmitNewUserCommand = new Command(async () => await ExecuteSubmitNewUser());
        }

        private Task ExecuteSubmitNewUser()
        {
            var validationResult = validator.IsValid(password, reenteredPassword);

            return Task.CompletedTask;
        }


    }
}
