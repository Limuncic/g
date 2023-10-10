using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Determinantee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btClear_Click(object sender, EventArgs e)//za brisanje br.
        {
            tbX1.Clear();
            tbX2.Clear();
            tbX3.Clear();
            tbY1.Clear();
            tbY2.Clear();
            tbY3.Clear();
            tbZ1.Clear();
            tbZ2.Clear();
            tbZ3.Clear();
            tbJednakost1.Clear();
            tbJednakost2.Clear();
            tbJednakost3.Clear();
            tbDx.Clear();
            tbDy.Clear();
            tbDz.Clear();
            tbD.Clear();
        }
        private void btClick_Click(object sender, EventArgs e)
        {
            //Unosenje br.
            int.TryParse(tbx.Text, out int x);
            int.TryParse(tbz.Text, out int z);
            int.TryParse(tby.Text, out int y);

            int.TryParse(tbX1.Text, out int x1);
            int.TryParse(tbX2.Text, out int x2);
            int.TryParse(tbX3.Text, out int x3);

            int.TryParse(tbY1.Text, out int y1);
            int.TryParse(tbY2.Text, out int y2);
            int.TryParse(tbY3.Text, out int y3);

            int.TryParse(tbZ1.Text, out int z1);
            int.TryParse(tbZ2.Text, out int z2);
            int.TryParse(tbZ3.Text, out int z3);

            int.TryParse(tbJednakost1.Text, out int r1);
            int.TryParse(tbJednakost2.Text, out int r2);
            int.TryParse(tbJednakost3.Text, out int r3);

            int.TryParse(tbDx.Text, out int Dx);
            int.TryParse(tbDz.Text, out int Dz);
            int.TryParse(tbDy.Text, out int Dy);
            int.TryParse(tbD.Text, out int D);
            //Unosenje br.

            D = x1 * y2 * z3 + y1 * z2 * x3 + z1 * x2 * y3 - (x3 * y2 * z1 + y3 * z2 * x1 + z3 * x2 * y1);
            Dx = r1 * y2 * z3 + y1 * z2 * r3 + z1 * r2 * y3 - (r3 * y2 * z1 + y3 * z2 * r1 + z3 * r2 * y1);
            Dz = x1 * y2 * r3 + y1 * r2 * x3 + r1 * x2 * y3 - (x3 * y2 * r1 + y3 * r2 * x1 + r3 * x2 * y1);
            Dy = x1 * r2 * z3 + r1 * z2 * x3 + z1 * x2 * r3 - (x3 * r2 * z1 + r3 * z2 * x1 + z3 * x2 * r1);
            tbD.Text = D.ToString();
            tbDx.Text = Dx.ToString();
            tbDy.Text = Dy.ToString();
            tbDz.Text = Dz.ToString();

            tbx.Text = (Dx / D).ToString();
            tby.Text = (Dy / D).ToString();
            tbz.Text = (Dz / D).ToString();




        }

        
    }
}
