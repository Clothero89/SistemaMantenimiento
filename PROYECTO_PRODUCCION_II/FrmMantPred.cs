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
    public partial class FrmMantPred : Form
    {
        Connection cnt;

        public FrmMantPred()
        {
            InitializeComponent();
        }

        public FrmMantPred(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
        }

        private void FrmMantPred_Load(object sender, EventArgs e)
        {

        }
    }
}
