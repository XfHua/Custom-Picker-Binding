using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App267
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        public View1() => InitializeComponent();

        public static BindableProperty TitleProperty = BindableProperty.Create(
                propertyName: nameof(Title),
                returnType: typeof(string),
                declaringType: typeof(View1),
                defaultValue: "",
                defaultBindingMode: BindingMode.TwoWay);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            nameof(ItemsSource),
            typeof(IList),
            typeof(View1),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: OnItemsSourceChanged);

        static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var thisControl = bindable as View1;

            if (oldValue != null)
                thisControl.ItemsSource = oldValue as IList;

            if (newValue != null)
                thisControl.ItemsSource = newValue as IList;
        }

        public IList ItemsSource
        {
            get
            {
                var items = (IList)GetValue(ItemsSourceProperty);
                return items;
            }

            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}