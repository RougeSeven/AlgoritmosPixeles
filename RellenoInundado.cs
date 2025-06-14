using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosPixeles
{
    internal class RellenoInundado
    {
        Graphics mGraph;
        SolidBrush mBrush;
        Point startpoint;
        
        public RellenoInundado()
        {
            mBrush = new SolidBrush(Color.LightCoral);
            startpoint = new Point();
        }

        public void getStartPoint(Point mouseClick)
        {
            startpoint = mouseClick;
        }

        public void floodFill(int x,int y, PictureBox picCanvas)
        {
            if(getPixelatedColorss(x,y,picCanvas))
            {
                fillPoint(x, y,picCanvas);
                floodFill(x,y+1,picCanvas);
                floodFill(x+1, y, picCanvas);
                floodFill(x-1, y, picCanvas);
                floodFill(x, y-1, picCanvas);
            }
        }
        public bool getPixelatedColorss(int x, int y, PictureBox picCanvas)
        {
            Bitmap nBits = new Bitmap(picCanvas.Image);
            if (x < 0 || y < 0 || x >= nBits.Width || y >= nBits.Height)
            {
                MessageBox.Show("Coordenadas fuera de rango.");
                return false;
            }
            Color pixelColor=nBits.GetPixel(x,y);
            MessageBox.Show("Punto:"+pixelColor.ToString());
            if(pixelColor!=Color.Black)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void fillPoint(int x,int y, PictureBox picCanvas)
        {
            mGraph=picCanvas.CreateGraphics();
            mGraph.FillRectangle(mBrush, x, y, 1, 1);
        }
        public void fillShape(PictureBox picCanvas)
        {
            Color fondo = picCanvas.BackColor;
            MessageBox.Show("Fondo: " + fondo.ToString());
            floodFill(startpoint.X, startpoint.Y, picCanvas);
        }
    }

}
