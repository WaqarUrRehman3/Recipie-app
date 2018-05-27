using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp2.Resources;

namespace PhoneApp2
{
    public partial class Aloo_Gajar_Kababs : PhoneApplicationPage
    {
        public Aloo_Gajar_Kababs()
        {
            InitializeComponent();
        }

        private void Naviagte_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}