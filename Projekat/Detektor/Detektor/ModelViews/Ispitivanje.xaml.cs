using Detektor.ModelViews;
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

namespace Amna.ModelViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Ispitivanje : Page
    {
        public Ispitivanje()
        {
            this.InitializeComponent();
        }

       

        private void Vrati1_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }

        private void Modifikuj_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodajPitanje));
        }

        private void Nastavi1_Click(System.Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiOdgovor));

        }
    }
}
