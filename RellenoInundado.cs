using System;
using System.Collections;
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

        public void floodFill(int x,int y, PictureBox picCanvas, Bitmap canvas)
        {
            if(getPixelatedColorss(x,y,canvas))
            {
                fillPoint(x, y,picCanvas, canvas);
                floodFill(x,y+1,picCanvas, canvas);
                floodFill(x+1, y, picCanvas, canvas);
                floodFill(x-1, y, picCanvas, canvas);
                floodFill(x, y-1, picCanvas, canvas);
            }
        }
        public bool getPixelatedColorss(int x, int y, Bitmap canvas)
        {
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
            {
                MessageBox.Show("Coordenadas fuera de rango.");
                return false;
            }
            Color pixelColor=canvas.GetPixel(x,y);
            if(pixelColor.ToArgb()!=Color.Black.ToArgb() && pixelColor.ToArgb()!=mBrush.Color.ToArgb())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void fillPoint(int x,int y, PictureBox picCanvas, Bitmap canvas)
        {
            mGraph = Graphics.FromImage(canvas);
            mGraph.FillRectangle(mBrush, x, y, 1, 1);
        }
        public void fillShape(PictureBox picCanvas, Bitmap canvas)
        {
            floodFillIterative(picCanvas, canvas);
        }
        public void FillPoint(int x, int y, PictureBox picCanvas, Bitmap canvas)
        {
            mGraph = Graphics.FromImage(canvas);
            canvas.SetPixel(x, y, mBrush.Color);
            picCanvas.Image = canvas;
        }

        public void floodFillIterative(PictureBox picCanvas, Bitmap canvas)
        {
            Queue<Point> puntos = new Queue<Point>();
            puntos.Enqueue(startpoint);//Encolar el punto inicial
            Point puntoActual;//Crear un punto en blanco para iterar
            while(puntos.Count>0)
            {
                puntoActual = puntos.Dequeue();//Saca el punto actual
                if(puntoActual.X<0 || puntoActual.X>canvas.Width || puntoActual.Y<0 || puntoActual.Y>canvas.Height)
                {
                    return;
                }
                if(getPixelatedColorss(puntoActual.X,puntoActual.Y,canvas))//Si el punto no esta pintado ya
                {
                    FillPoint(puntoActual.X, puntoActual.Y, picCanvas, canvas);
                    puntos.Enqueue(new Point(puntoActual.X, puntoActual.Y + 1));//Norte
                    puntos.Enqueue(new Point(puntoActual.X + 1, puntoActual.Y));//Este
                    puntos.Enqueue(new Point(puntoActual.X, puntoActual.Y - 1));//Sur
                    puntos.Enqueue(new Point(puntoActual.X - 1, puntoActual.Y));//Oeste
                }
            }
        }
    }

}
