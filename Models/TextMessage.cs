using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftToolkitMvvmHelloworld.Models
{
    public class TextMessage : ObservableObject
    {
        private string text = "Original text";
        public string Content
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
                OnPropertyChanged("Content");
            }
        }
    }
}
