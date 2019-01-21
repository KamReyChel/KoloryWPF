using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using KoloryWPF.Properties;
using System.Windows;

namespace KoloryWPF
{
    public static class Ustawienia
    {
        public static Color CzytajKolor()
        {
            Settings ustawienia = Settings.Default;
            Color kolor = new Color()
            {
                A = 255,
                R = ustawienia.R,
                G = ustawienia.G,
                B = ustawienia.B
            };
            return kolor;
        }

        public static (double H, double W) CzytajOkno()
        {
            Settings ustawienia = Settings.Default;
            double H = ustawienia.H;
            double W = ustawienia.W;
            return (H, W);
        }

        public static void Zapisz(Color kolor, double H, double W)
        {
            Settings ustawienia = Settings.Default;

            ustawienia.R = kolor.R;
            ustawienia.G = kolor.G;
            ustawienia.B = kolor.B;

            ustawienia.H = H;
            ustawienia.W = W;

            ustawienia.Save();
        }
    }
}
