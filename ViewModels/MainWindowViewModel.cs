using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MicrosoftToolkitMvvmHelloworld.Models;

namespace MicrosoftToolkitMvvmHelloworld.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        private TextMessage currentTextMessage;
        public TextMessage CurrentTextMessage
        {
            get
            {
                return currentTextMessage;
            }

            set
            {
                currentTextMessage = value;
                OnPropertyChanged("CurrentTextMessage");
            }
        }

        public MainWindowViewModel()
        {
            currentTextMessage = new TextMessage();
            ChangeTextMessageCommand = new RelayCommand(ChangeTextMessageMethod);
        }

        private void ChangeTextMessageMethod()
        {
            CurrentTextMessage.Content = "Message modified !";

        }

        public ICommand ChangeTextMessageCommand { get; }
    }
}
