﻿using System;
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
    public partial class FrmOrdenMant : Form
    {
        Connection cnt;

        public FrmOrdenMant(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
        }
    }
}