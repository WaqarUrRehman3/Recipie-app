using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp2
{
    public partial class Firey_Chicken_wings_in_hot_sauce : PhoneApplicationPage
    {
        public Firey_Chicken_wings_in_hot_sauce()
        {
            InitializeComponent();
            
        }

        private void Naviagte_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}