using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolkitMvvmHelloworld.Models
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
