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
        Mantenimiento m = new Mantenimiento();

        public FrmMantCorrec()
        {
            InitializeComponent();
            this.dgvMantenimientosCorr.DataSource = m.cargarOrden();
        }

        public FrmMantCorrec(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
            this.dgvMantenimientosCorr.DataSource = m.cargarOrden();
            m.CargarComboBoxs(this.cmbEmpleado, "VerEmpleados", "Nombre");
            m.CargarComboBoxs(this.cmbEquipo, "CargarEquipo", "Nombre");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMantCorrec_Load(object sender, EventArgs e)
        {

            /*cmbEmpleado.DataSource = cnt.CargarProcedimiento("VerEmpleados");
            cmbEmpleado.DisplayMember = "Primer_Nombre";
            cmbEmpleado.ValueMember = "ID_Empleado";

            cmbEquipo.DataSource = cnt.CargarConsulta("SELECT * FROM EQUIPO");
            cmbEquipo.DisplayMember = "Nombre";
            cmbEquipo.ValueMember = "ID_Equipo";*/
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //dgvMantenimientosCorr.DataSource = cnt.CargarConsulta("SELECT * FROM Mantenimiento");
        }


        private void btnVerPiezas_Click(object sender, EventArgs e)
        {
            //dgvMantenimientosCorr.DataSource = cnt.CargarConsulta("SELECT * FROM Mantenimiento");
            /*cmbEmpleado.DataSource = cnt.CargarProcedimiento("VerEmpleados");
            cmbEmpleado.DisplayMember = "Primer_Nombre";
            cmbEmpleado.ValueMember = "ID_Empleado";*/
        }
    }
}
