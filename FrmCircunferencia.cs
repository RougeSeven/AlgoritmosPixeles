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
    public partial class FrmCircunferencia : Form
    {
        private DiscreteCircle dCircle=new DiscreteCircle();
        private RellenoInundado fFill=new RellenoInundado();
        public FrmCircunferencia()
        {
            InitializeComponent();
        }

        private void FrmCircunferencia_Load(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx,txtPy,txtRadius,picCanvas);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            dCircle.readData(txtPx,txtPy,txtRadius);
            dCircle.calculateOctant(picCanvas);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dCircle.initializeData(txtPx, txtPy, txtRadius, picCanvas);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            //Aqui iria el relleno
        }
    }
}
