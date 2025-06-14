﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoritmosPixeles
{
    class BresenhamLines
    {
        private Point p_0;
        private Point p_f;
        private float diff_x;
        private float diff_y;
        private int k;
        private int p;
        private int const_add;
        private int const_sub;
        private float slope;
        private const int sf= 20;
        DataTable points;


        public BresenhamLines()
        {
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k = 0;
            p = 0;
            const_add = 0;
            const_sub = 0;
            createPointsTable();
        }

        public void createPointsTable()
        {
            points = new DataTable();
            points.Columns.Add("step", typeof(int));
            points.Columns.Add("valueX", typeof(int));
            points.Columns.Add("valueY", typeof(int));
        }

        public void readData(System.Windows.Forms.TextBox txtPx1, System.Windows.Forms.TextBox txtPy1, System.Windows.Forms.TextBox txtPx2, System.Windows.Forms.TextBox txtPy2)
        {
            try
            {
                p_0.X = Convert.ToInt32(txtPx1.Text);
                p_0.Y = Convert.ToInt32(txtPy1.Text);
                p_f.X = Convert.ToInt32(txtPx2.Text);
                p_f.Y = Convert.ToInt32(txtPy2.Text);
            }
            catch
            {
                MessageBox.Show("Entrada incorrecta, por favor solo enteros");
            }
        }

        public void initializeData(System.Windows.Forms.TextBox txtPx1, System.Windows.Forms.TextBox txtPy1, System.Windows.Forms.TextBox txtPx2, System.Windows.Forms.TextBox txtPy2, 
            PictureBox picCanvas, DataGridView pointsTable)
        {
            txtPx1.Text="";
            txtPx2.Text = "";
            txtPy1.Text = "";
            txtPy2.Text = "";
            picCanvas.Refresh();
            p_0 = new Point();
            p_f = new Point();
            diff_x = 0.0f;
            diff_y = 0.0f;
            slope = 0.0f;
            k= 0;
            p = 0;
            const_add = 0;
            const_sub = 0;
            points.Rows.Clear();
            pointsTable.DataSource = points;
        }
        public void calculate()
        {
            diff_x = (float)(Math.Abs(p_f.X - p_0.X));
            diff_y = (float)(Math.Abs(p_f.Y - p_0.Y));
            slope = diff_y / diff_x;
            if (diff_x > diff_y)
            {
                //Pendiente menor a 1
                k = Convert.ToInt32(diff_x);
                p = (2 * Convert.ToInt32(diff_y)) - Convert.ToInt32(diff_x);
                const_add = (2 * Convert.ToInt32(diff_y));
                const_sub = (2 * Convert.ToInt32(diff_y)) - (2 * Convert.ToInt32(diff_x));
            }
            else
            {
                k = Convert.ToInt32(diff_y);
                p = (2 * Convert.ToInt32(diff_x)) - Convert.ToInt32(diff_y);
                const_add = (2 * Convert.ToInt32(diff_x));
                const_sub = (2 * Convert.ToInt32(diff_x)) - (2 * Convert.ToInt32(diff_y));
            }
        }
        public void drawPoints(PictureBox picCanvas, DataGridView pointsTable)
        {
            Point point = new Point();
            Pen mPen;
            mPen = new Pen(Color.Black, 2);
            Graphics mGraph;
            mGraph=picCanvas.CreateGraphics();
            //Extremos
            mPen = new Pen(Color.Black, 3);
            mGraph.DrawLine(mPen, point, point);
            mGraph.DrawLine(mPen, point, point);
            int p_k = p;
            Point pointi = p_0;
            points.Rows.Add(0, pointi.X, pointi.Y);
            Point pointf=new Point();
            for (int i=0;i<k;i++)
            {
                if(p_k <0)
                {
                    p_k = p_k + (1 + (2 * const_add));
                    if(slope<1)
                    {
                        pointf.X = pointi.X+1;
                        pointf.Y = pointi.Y;
                    }
                    else
                    {
                        pointf.Y = pointi.Y + 1;
                        pointf.X = pointi.X;
                    }
                }
                else
                {
                    p_k = p_k + (1 +(2 * const_sub));
                    pointf.X = pointi.X + 1;
                    pointf.Y = pointi.Y + 1;

                }
                mGraph.DrawLine(mPen, pointi, pointf);
                //Agregando a la tabla
                points.Rows.Add(i+1,pointf.X,pointf.Y);
                pointi = pointf;
            }
            pointsTable.DataSource = points;
        }
        public void drawEnds(PictureBox picCanvas)
        {
            Pen mPen;
            Graphics mGraph;
            mPen = new Pen(Color.Red, 2);
            mGraph = picCanvas.CreateGraphics();
            int radius = 5;
            mGraph.DrawEllipse(mPen, (p_0.X - radius), (p_0.Y - radius), (2 * radius), (2 * radius));
            mGraph.DrawEllipse(mPen, (p_f.X - radius), (p_f.Y - radius), (2 * radius), (2 * radius));
        }
    }
}
