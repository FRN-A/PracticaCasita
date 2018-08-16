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

namespace PracitcaLineas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (float i=0; i<=360; i++)
            {
                plnSol.Points.Add(new Point(Math.Cos(i) * 60 + 200, Math.Sin(i) * 60 + 100));
            }
            

            plnCasa.Points.Add(new Point(450.0, 300.0));
            plnCasa.Points.Add(new Point(450.0, 600.0));
            plnCasa.Points.Add(new Point(750.0, 600.0));
            plnCasa.Points.Add(new Point(750.0, 300.0));
            plnCasa.Points.Add(new Point(450.0, 300.0));
            plnTecho.Points.Add(new Point(350.0, 300.0));
            plnTecho.Points.Add(new Point(850.0, 300.0));
            plnTecho.Points.Add(new Point(600.0, 150.0));
            plnTecho.Points.Add(new Point(350.0, 300.0));
            plnPuerta.Points.Add(new Point(550.0, 600.0));
            plnPuerta.Points.Add(new Point(650.0, 600.0));
            plnPuerta.Points.Add(new Point(650.0, 450.0));
            plnPuerta.Points.Add(new Point(550.0, 450.0));
            plnPuerta.Points.Add(new Point(550.0, 600.0));
            plnVentana.Points.Add(new Point(600.0, 425.0));
            plnVentana.Points.Add(new Point(720.0, 425.0));
            plnVentana.Points.Add(new Point(720.0, 325.0));
            plnVentana.Points.Add(new Point(600.0, 325.0));
            plnVentana.Points.Add(new Point(600.0, 425.0));
            plnVentana2.Points.Add(new Point(600.0, 375.0));
            plnVentana2.Points.Add(new Point(720.0, 375.0));
            plnVentana3.Points.Add(new Point(660.0, 325.0));
            plnVentana3.Points.Add(new Point(660.0, 425.0));

            plnArbol.Points.Add(new Point(950.0, 600.0));
            plnArbol.Points.Add(new Point(1040.0, 600.0));
            plnArbol.Points.Add(new Point(1040.0, 300.0));
            plnArbol.Points.Add(new Point(950.0, 300.0));
            plnArbol.Points.Add(new Point(950.0, 600.0));
            plnArbol2.Points.Add(new Point(950.0, 320.0));
            plnArbol2.Points.Add(new Point(870.0, 220.0));
            plnArbol2.Points.Add(new Point(995.0, 100.0));
            plnArbol2.Points.Add(new Point(870.0, 220.0));
        }
    }
}
