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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void menuLineas_Click(object sender, EventArgs e)
        {
            FrmLineas flineas=new FrmLineas();
            flineas.MdiParent = this;
            flineas.Show();
        }

        private void menuCircunferencia_Click(object sender, EventArgs e)
        {
            FrmCircunferencia fCirc = new FrmCircunferencia();
            fCirc.MdiParent = this;
            fCirc.Show();
        }

        private void menuRelleno_Click(object sender, EventArgs e)
        {
            FrmRelleno fFill = new FrmRelleno();
            fFill.MdiParent = this;
            fFill.Show();
        }
    }
}
