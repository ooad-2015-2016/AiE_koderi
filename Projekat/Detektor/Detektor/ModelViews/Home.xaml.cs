﻿using Detektor.ModelViews.ModelViews.ModelViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Detektor.ModelViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }

        private void UnesiKlijenta_Click(System.Object sender, RoutedEventArgs e)
        {

        }

        private void Odaberi_Click(System.Object sender, RoutedEventArgs e)
        {

        }

        private void Vrati_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Menu));
        }
    }
}
