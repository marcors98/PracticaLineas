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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            for (float i = 0; i <= 360; i++)
            {
                plnLinea.Points.Add(new Point(Math.Cos(i) * 50 + 100, Math.Sin(i) * 50 + 100));
            }

            plnLinea2.Points.Add(new Point(500.0, 450.0));
            plnLinea2.Points.Add(new Point(650.0, 450.0));
            plnLinea2.Points.Add(new Point(650.0, 300.0));
            plnLinea2.Points.Add(new Point(500.0, 300.0));
            plnLinea2.Points.Add(new Point(500.0, 450.0));


            plnLinea3.Points.Add(new Point(450.0, 300.0));
            plnLinea3.Points.Add(new Point(575.0, 200.0));
            plnLinea3.Points.Add(new Point(700.0, 300.0));
            plnLinea3.Points.Add(new Point(450.0, 300.0));

            plnLinea4.Points.Add(new Point(625.0, 320.0));
            plnLinea4.Points.Add(new Point(625.0, 370.0));
            plnLinea4.Points.Add(new Point(575.0, 370.0));
            plnLinea4.Points.Add(new Point(575.0, 320.0));
            plnLinea4.Points.Add(new Point(625.0, 320.0));

            plnLinea5.Points.Add(new Point(600.0, 320.0));
            plnLinea5.Points.Add(new Point(600.0, 370.0));

            plnLinea6.Points.Add(new Point(575.0, 345.0));
            plnLinea6.Points.Add(new Point(625.0, 345.0));

            plnLinea7.Points.Add(new Point(515.0, 450.0));
            plnLinea7.Points.Add(new Point(545.0, 450.0));
            plnLinea7.Points.Add(new Point(545.0, 400.0));
            plnLinea7.Points.Add(new Point(515.0, 400.0));
            plnLinea7.Points.Add(new Point(515.0, 450.0));

            plnLinea8.Points.Add(new Point(250.0, 450.0));
            plnLinea8.Points.Add(new Point(250.0, 300.0));

            plnLinea9.Points.Add(new Point(300.0, 450.0));
            plnLinea9.Points.Add(new Point(300.0, 300.0));

            plnLinea10.Points.Add(new Point(200.0, 300.0));
            plnLinea10.Points.Add(new Point(350.0, 300.0));
            plnLinea10.Points.Add(new Point(350.0, 150.0));
            plnLinea10.Points.Add(new Point(200.0, 150.0));
            plnLinea10.Points.Add(new Point(200.0, 300.0));

            plnLinea11.Points.Add(new Point(0.0, 500.0));
            plnLinea11.Points.Add(new Point(800.0, 500.0));

        }

    }
}
