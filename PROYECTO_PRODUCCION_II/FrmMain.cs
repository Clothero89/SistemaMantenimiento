using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PRODUCCION_II
{
    public partial class FrmMain : Form
    {
        Connection cnt;
        public FrmMain()
        {
            InitializeComponent();
            buttons = this.Height - btnMantPred.Height;
        }

        int buttons;

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            /*btnMantPred.Height = this.Height - buttons;
            btnMantPrev.Height = this.Height - buttons;
            btnOrdenMant.Height = this.Height - buttons;
            btnMantCorre.Height = this.Height - buttons;*/
        }

        public FrmMain(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMantPrev_Click(object sender, EventArgs e)
        {
            FrmMantPrev frm = new FrmMantPrev(cnt);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btmMantCorre_Click(object sender, EventArgs e)
        {
            FrmMantCorrec frm = new FrmMantCorrec(cnt);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMantPred_Click(object sender, EventArgs e)
        {
            FrmMantPred frm = new FrmMantPred(cnt);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOrdenMant_Click(object sender, EventArgs e)
        {
            FrmOrdenMant frm = new FrmOrdenMant(cnt);
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
