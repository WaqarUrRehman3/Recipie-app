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
using System.Diagnostics;
using System.Resources;
using System.Windows.Markup;




namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private void Sticky_Chicken_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sticky_Chicken_Wings.Xaml", UriKind.Relative));

        }

        private void open_page_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sticky_Chicken.Xaml", UriKind.Relative));
        }

        private void Aloo_Gajar_Kababs_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Aloo_Gajar_Kababs.Xaml", UriKind.Relative));
        }

        private void Cheese_Tomato_Flan_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cheese_Tomato_Flan.Xaml", UriKind.Relative));
        }

        private void Chicken_Roll_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Chicken_Roll.Xaml", UriKind.Relative));
        }

        private void Creamy_Mince_Cutlets_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Creamy_Mince_Cutlets.Xaml", UriKind.Relative));
        }

        private void Dal_Mix_Pakora_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dal_Mix_Pakora.Xaml", UriKind.Relative));
        }

        private void Firey_Chicken_wings_in_hot_sauce_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Firey_Chicken_wings_in_hot_sauce.Xaml", UriKind.Relative));
        }
    }
}