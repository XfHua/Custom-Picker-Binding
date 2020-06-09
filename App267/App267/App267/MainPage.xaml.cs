using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App267
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new testModel();
           
        }
    }

    public class testModel : INotifyPropertyChanged
    {

        public testModel() {

            this.Title = "testTitle";
            this.ItemsSource = new List<string>()
            {
                "1","2","3","4","5","6","7"
            };
        }

        string title { get; set; }
        public string Title
        {
            set
            {
                if (title != value)
                {
                    title = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return title;
            }
        }

        IList itemsSource { get; set; }
        public IList ItemsSource
        {
            set
            {
                if (itemsSource != value)
                {
                    itemsSource = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ItemsSource"));
                    }
                }
            }
            get
            {
                return itemsSource;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
