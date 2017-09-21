using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    static class ConversordeMedidas
    {
        public static string GParaKg(double g)
        {
            double kg = g / 1000;
            return string.Format("{0} g é {1} kg", g, kg);
        }
        public static string KgparaG(double kg)
        {
            double g = kg * 1000;
            return string.Format("{0} kg são {1} g", kg, g);
        }
        public static string KgparaT(double kg)
        {
            double t = kg / 1000;
            return string.Format("{0} kg é {1} t", kg, t);
        }
        public static string TparaKg(double t)
        {
            double kg = t * 1000;
            return string.Format("{0} t são {1} kg", t, kg);
        }
        public static string KgparaLBS(double kg)
        {
            double lbs = kg * 2.20;
            return string.Format("{0} kg são {1} lbs", kg, lbs);
        }
        public static string LBSparaKG(double lbs)
        {
            double kg = lbs / 2.20;
            return string.Format("{0} lbs é {1} kg", kg, lbs);

        }
        public static string TcparaTf(double c)
        {
            double tf = (9 * c + 160) / 5;
            return string.Format("{0} °C são {1} °F", c, tf);
        }
        public static string TfparaTc(double f)
        {
            double tc = (5 * f - 160) / 9;
            return string.Format("{0} °F são {1} °C", f, tc);
        }
        public static string TfparaTk(double f)
        {
            double tk = (f - 32) / 1.8000 + 273.15;
            return string.Format("{0} °F são {1} K", f, tk);

        }
        public static string TkparaTf(double k)
        {
            double tf = (k - 273.15) * 1.8000 + 32.00;
            return string.Format("{0} K são {1} °F", k, tf);
        }
        public static string TkparaTc(double k)
        {
            double tc = k - 273.15;
            return string.Format("{0} K são {1} °C", k, tc);
        }
        public static string TcparaTk(double c)
        {
            double tk = c + 273.15;
            return string.Format("{0} °C são {1} K", c, tk);
        }
        public static string MparaKm(double m)
        {
            double km = m / 1000;
            return string.Format("{0}m são {1} km", m, km);
        }
        public static string KmparaM(double km)
        {
            double m = km * 1000;
            return string.Format("{0}km são {1}m", km, m);
        }
        public static string KmparaMilha(double km)
        {
            double milha = km / 1.60934;
            return string.Format("{0}km são {1 }mile(s)", km, milha);
        }
        public static string MilhaparaKm(double milha)
        {
            double km = milha * 1.60934;
            return string.Format("{0}mile(s) são {1}km", milha, km);
        }
        public static string MparaPes(double m)
        {
            double pes = m / 0.3048;
            return string.Format("{0}m são {1}pé(s)", m, pes);
        }
        public static string PesparaM(double pes)
        {
            double m = pes * 0.3048;
            return string.Format("{0}pé(s) são {1}m", pes, m);
        }
        public static string MparaPol(double m)
        {
            double polegada = m / 0.0254;
            return string.Format("{0}m são {1} polegada(s)", m, polegada);

        }
        public static string PolparaM(double polegada)
        {
            double m = polegada * 0.0254;
            return string.Format("{0}polegada(s) são {1} m", polegada, m);
        }
        public static string PolparaPes(double polegada)
        {
            double pes = polegada * 0.0833333;
            return string.Format("{0}polegada(s) são {1} pes", polegada, pes);
        }
        public static string PesparaPol(double pes)
        {
            double polegada = pes / 0.0833333;
            return string.Format("{0}pé(s) são {1} polegada(s)", pes, polegada);
        }







    }
}
