using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkitMvvmHelloworld.Models;

namespace CommunityToolkitMvvmHelloworld.ViewModels
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
            ChangeTextMessageCommand = new
                RelayCommand(ChangeTextMessageMethod);
        }

        private void ChangeTextMessageMethod()
        {
            CurrentTextMessage.Content = "Message modified !";

        }

        private void ChangeTextProvider()
        {
            ChangeTextMessageMethod();
        }

        public ICommand ChangeTextMessageCommand { get; }
    }
}
