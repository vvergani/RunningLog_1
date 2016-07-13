using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace RunningLog.Menu
{
    public class MasterPageItem: INotifyPropertyChanged
    {
        public string Title { get; set; }

        public string Command { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        private Xamarin.Forms.Color backgroundColor;
        public Xamarin.Forms.Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }
            set
            {
                backgroundColor = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BackgroundColor"));
                }
            }
        }

        private Xamarin.Forms.Color textColor;
        public Xamarin.Forms.Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TextColor"));
                }
            }
        }

        private bool selected = false;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                if (selected == true)
                {
                    TextColor = Xamarin.Forms.Color.FromHex((string)Application.Current.Resources["MasterPageItemTextColorSelected"]);
                    BackgroundColor = Xamarin.Forms.Color.FromHex((string)Application.Current.Resources["MasterPageItemBackgroundColorSelected"]);
                }
                else
                {
                    TextColor = Xamarin.Forms.Color.FromHex((string)Application.Current.Resources["MasterPageItemTextColor"]);
                    BackgroundColor = Xamarin.Forms.Color.FromHex((string)Application.Current.Resources["MasterPageItemBackgroundColor"]);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
