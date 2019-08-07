using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dragonsofthecaribbean
{
    public partial class DragonOptionPage : ContentPage
    {
        public DragonOptionPage()
        {
            //InitializeComponent();

        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        public void OnDragonChoiceChange(object sender, ValueChangedEventArgs args)
        {
            Console.WriteLine($"{sender}");
        }
    }
}
