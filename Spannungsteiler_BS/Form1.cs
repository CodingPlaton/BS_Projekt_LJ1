using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spannungsteiler_BS
{
    
    public partial class Form1 : Form
    {
        private const int ABSTAND_YACHSE = 30;
        private const int ABSTAND_XACHSE = 30;
        private const int SCHRITT_ABSTAND_YACHSE = 40;
        private const int SCHRITT_ABSTAND_XACHSE = 10;
        private const int MAX_YWERT = 100000;
        private const int MAX_XWERT = 15;
        private const int UGESAMT = 15;
        private const int R2 = 10000;


        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Calculate_Click(object sender, EventArgs e)
        {
            drawCoordinateSystem();                               
            Invalidate();
            drawCurve();            
        }

        private void drawCoordinateSystem()
        {
            float yAbstand = pb_CoordinateSystem.Height - ABSTAND_YACHSE;
            float yAbstand2 = pb_CoordinateSystem.Height - 40;
            float xAbstand2 = 30;
            float xAbstand3 = 30;

            Graphics g;
            g = pb_CoordinateSystem.CreateGraphics();
            Pen penGraph = new Pen(Color.Black, 2);
            Font fontGraph = new Font("Arial", 10);
            SolidBrush brushGraph = new SolidBrush(Color.Black);

            // zeichne Y-Achse            
            g.DrawLine(penGraph, ABSTAND_YACHSE + 10, 40, ABSTAND_YACHSE + 10, yAbstand);
            // zeichen X-Achse
            g.DrawLine(penGraph, ABSTAND_YACHSE + 10, yAbstand, pb_CoordinateSystem.Width - 30, yAbstand);
            
            int t = 10;
            String t2 = "k";

            // Beschriftung Y-Achse
            for (int i = 10000; i <= MAX_YWERT; i = i + 10000)
            {
                g.DrawLine(penGraph, xAbstand3 + 10, yAbstand2 - 30, xAbstand3 + 5 , yAbstand2 - 30);
                g.DrawString((i / 1000).ToString() + t2, fontGraph, brushGraph, xAbstand3 - 30, yAbstand2 - 40);

                //t = t + 10;
                yAbstand2 = yAbstand2 - 30;
            }

            g.DrawString("R (Ohm)", fontGraph, brushGraph, ABSTAND_YACHSE - 15, yAbstand - 360);

            // Beschriftung X-Achse
            for (int i = 0; i < 16; i++)
            {
                g.DrawLine(penGraph, xAbstand2 + 10, yAbstand, xAbstand2 + 10, yAbstand + 4);
                g.DrawString(i.ToString(), fontGraph, brushGraph, xAbstand2 + 3, yAbstand + 4);

                xAbstand2 = xAbstand2 + 20;
            }

            g.DrawString("U2 (Volt)", fontGraph, brushGraph, xAbstand2 + 15, yAbstand + 5);

        }

        public void drawCurve()
        {
            Graphics g = pb_CoordinateSystem.CreateGraphics();

            Point[] curvePoints = berechneCurvePoints();
            
            Pen redPen = new Pen(Color.Red, 2);
            Pen greenPen = new Pen(Color.Green, 2);
                       
            g.DrawCurve(redPen, curvePoints);
        }

        public Point[] berechneCurvePoints()
        {
            int[] OhmWerte = {330, 680, 10000, 22000, 48000, 80000};
            List<float> UWerte = new List<float>();
            List<Point> ListPoints = new List<Point>();
            
            // Berechnung U-Werte (X-Achse)
            for (int i = 0; i < OhmWerte.Length; i++)
            {
                int R1 = OhmWerte[i];
                float U1 = UGESAMT * (1 - ((float)R2 / (R1 + R2)));

                UWerte.Add(U1);
            }

            // Umrechnung in Koordinatenpunkte der picture Box Y-Achse
            for (int i = 0; i < OhmWerte.Length; i++)
            {
                OhmWerte[i] = pb_CoordinateSystem.Height - 40 - ((360 * OhmWerte[i]) / MAX_YWERT);
            }

            // Umrechnung in Koordinatenpunkte der picture Box X-Achse
            for (int i = 0; i < UWerte.Count; i++)
            {
                UWerte[i] = ABSTAND_XACHSE + 5 + ((330 * UWerte[i]) / MAX_XWERT);
            }

            for (int i = 0; i < OhmWerte.Length; i++)
            {                
                ListPoints.Add(new Point((int)UWerte[i], OhmWerte[i]));
            }

            Point[] curvePoints = ListPoints.ToArray();
            return curvePoints;
        }
    }
}

