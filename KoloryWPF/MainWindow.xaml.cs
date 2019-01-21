using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoloryWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flaga = false;

        public MainWindow()
        {
            InitializeComponent();

            (OknoGlowne.Height, OknoGlowne.Width) = Ustawienia.CzytajOkno();

            Color kolor = Ustawienia.CzytajKolor();
            rectangle.Fill = new SolidColorBrush(kolor);
            
            
            SliderR.Value = kolor.R;
            SliderG.Value = kolor.G;
            SliderB.Value = kolor.B;
            flaga = true;
        }

        private Color KolorProst
        {
            get
            {
                return (rectangle.Fill as SolidColorBrush).Color;
            }
            set
            {
                (rectangle.Fill as SolidColorBrush).Color = value;
            }
        }



        private void SliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (flaga)
            {
                Color kolor = Color.FromRgb((byte)SliderR.Value, (byte)SliderG.Value, (byte)SliderB.Value);
                KolorProst = kolor;
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape) Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
            Ustawienia.Zapisz(KolorProst, OknoGlowne.ActualHeight, OknoGlowne.ActualWidth);
        }
    }
}
