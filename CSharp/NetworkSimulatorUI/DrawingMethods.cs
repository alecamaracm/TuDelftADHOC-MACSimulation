using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSimulatorUI
{
    public static class DrawingMethods
    {
        public static Pen axisPen = new Pen(Brushes.Black, 2);
        public static readonly int axisTickInterval = 50;
        public static readonly int axisTickSize = 10;

        public static Bitmap tick = new Bitmap(Environment.CurrentDirectory+"/Images/tick.png");
        public static Bitmap error = new Bitmap(Environment.CurrentDirectory + "/Images/error.png");

        public static void DrawAxis(Graphics g,PointF zeroCoordinateLocation)
        {
            g.ResetTransform();
            g.SetClip(new RectangleF(0,0,2500,1500));
            g.TranslateTransform(zeroCoordinateLocation.X,zeroCoordinateLocation.Y);

            g.DrawLine(axisPen, PointF.Empty, new PointF(0,g.Height()));
            g.DrawLine(axisPen, PointF.Empty, new PointF(g.Width(), 0));
            for (int i = 0; i < g.Width(); i+= axisTickInterval)
            {
                g.DrawLine(axisPen, Point.Empty, new PointF(0,-axisTickSize));
                g.DrawString(i.ToString(), Form1.DefaultFont, Brushes.Black, -g.MeasureString(i.ToString(), Form1.DefaultFont).Width/2, -g.MeasureString(i.ToString(), Form1.DefaultFont).Height / 2 - 22, StringFormat.GenericDefault);
                g.TranslateTransform(axisTickInterval, 0);
            }

            g.ResetTransform();
            g.TranslateTransform(zeroCoordinateLocation.X, zeroCoordinateLocation.Y);

            for (int i = 0; i < g.Height(); i += axisTickInterval)
            {
                g.DrawLine(axisPen, Point.Empty, new PointF(-axisTickSize, 0));
                g.DrawString(i.ToString(), Form1.DefaultFont, Brushes.Black, -g.MeasureString(i.ToString(), Form1.DefaultFont).Width - 15, -g.MeasureString(i.ToString(), Form1.DefaultFont).Height/2, StringFormat.GenericDefault);
                g.TranslateTransform(0, axisTickInterval);
            }

            g.DrawRectangle(Pens.Black, new Rectangle(0,0,10,10));
        }

        public static void DrawNode(KeyValuePair<int, BaseNode> node,int numberOfWaveReceptions, Graphics g, PointF zeroCoordinateLocation)
        {
            g.ResetTransform();
            g.TranslateTransform(zeroCoordinateLocation.X, zeroCoordinateLocation.Y);

            g.TranslateTransform(node.Value.location.X, node.Value.location.Y);
            if(numberOfWaveReceptions <= 0)
            {
                g.FillCircle(Brushes.Black, 0, 0, 5);
            }
            else if(numberOfWaveReceptions == 1)
            {
                g.FillCircle(Brushes.Green, 0, 0, 5);
            }
            else
            {
                g.FillCircle(Brushes.Red, 0, 0, 5);
            }
            
            g.DrawString(node.Value.id.ToString(), Form1.DefaultFont,Brushes.Black, -g.MeasureString(node.Value.id.ToString(), Form1.DefaultFont).Width / 2, -g.MeasureString(node.Value.id.ToString(), Form1.DefaultFont).Height +25, StringFormat.GenericDefault);

            if (node.Value.drawTickTimeLeft > 0)
            {
                g.DrawImage(tick, new Rectangle(10,-30,25,25));
            }else if(node.Value.drawErrorTimeLeft > 0)
            {
                g.DrawImage(error, new Rectangle(10, -30, 25, 25));
            }
        }

        public static void DrawWave(OngoingMessage message, Graphics g, PointF zeroCoordinateLocation)
        {
            g.ResetTransform();
            g.SetClip(new RectangleF(zeroCoordinateLocation.X,zeroCoordinateLocation.Y,2500,1500));
            g.TranslateTransform(zeroCoordinateLocation.X, zeroCoordinateLocation.Y);

            g.TranslateTransform(message.origin.X, message.origin.Y);
        //   if(message.frontTravelledDistance > 0) g.DrawCircle(Pens.Black, 0, 0, message.frontTravelledDistance);
         //  if(message.backTravelledDistance > 0) g.DrawCircle(Pens.Black, 0, 0, message.backTravelledDistance);

            for(int i = (int)message.frontTravelledDistance; i > message.backTravelledDistance; i-=12)
            {
                float percentDone = (i - message.backTravelledDistance)/(message.frontTravelledDistance - message.backTravelledDistance);
                percentDone = 1 - percentDone;

                g.DrawCircle(new Pen(Color.FromArgb(100,(int)(Math.Min(percentDone*255*1.2,255)),(int)((1-percentDone)*120),0),2), 0, 0, i);
            }

        }
    }
}
