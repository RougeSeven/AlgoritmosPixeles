using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosPixeles
{
    public partial class FrmRelleno : Form
    {
        private RellenoInundado mRelleno=new RellenoInundado();
        private mPlot mLinea=new mPlot();
        private String mode;
        private Bitmap canvas;
        public FrmRelleno()
        {
            InitializeComponent();
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            mode = "";
        }

        private void FrmRelleno_Load(object sender, EventArgs e)
        {
            mLinea.InitializeComponents(picCanvas);
            canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            mode = "";
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            if (mode=="draw")
            {
                mLinea.plotLines(picCanvas, ev.Location,canvas);
            }
            else
            {
                mRelleno.getStartPoint(ev.Location);
                mRelleno.fillShape(picCanvas);
            }
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            mode = "draw";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            mode = "fill";
        }
    }
}
