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
    public partial class Sticky_Chicken_Wings : PhoneApplicationPage
    {
        public Sticky_Chicken_Wings()
        {
            InitializeComponent();
            
        }

        private void Naviagte_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}