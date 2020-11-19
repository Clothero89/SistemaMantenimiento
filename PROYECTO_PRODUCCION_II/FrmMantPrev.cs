using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PRODUCCION_II
{
    public partial class FrmMantPrev : Form
    {
        Connection cnt;

        SqlParameter campos;

        public FrmMantPrev(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
        }

        private void FrmMantPrev_Load(object sender, EventArgs e)
        {
            dgvMantenimientos.DataSource = cnt.CargarConsulta("SELECT * FROM Mantenimiento");

            cmbEmpleado.DataSource = cnt.CargarProcedimiento("VerEmpleados");
            cmbEmpleado.DisplayMember = "Primer_Nombre";
            cmbEmpleado.ValueMember = "ID_Empleado";

            cmbEquipo.DataSource = cnt.CargarConsulta("SELECT * FROM EQUIPO");
            cmbEquipo.DisplayMember = "Nombre";
            cmbEquipo.ValueMember = "ID_Equipo";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}