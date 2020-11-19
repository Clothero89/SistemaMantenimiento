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
    public partial class FrmMantCorrec : Form
    {
        Connection cnt;

        public FrmMantCorrec()
        {
            InitializeComponent();
        }

        public FrmMantCorrec(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
