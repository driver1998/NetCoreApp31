using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NetCoreApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string username;
        public string UserName 
        {
            get => username; 
            set
            {
                if (value != username)
                {
                    username = value;
                    RaisePropertyChanged();
                }
            } 
        }
        private string message;
        public string Message
        {
            get => message;
            set
            {
                if (value != message)
                {
                    message = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void SayHello()
        {
            Message = $"Hello, {username}";
        }

        private void RaisePropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
