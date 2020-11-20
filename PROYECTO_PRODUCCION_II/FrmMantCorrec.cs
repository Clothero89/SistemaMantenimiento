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
        }

        public FrmMantCorrec(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
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
            float costo = 0;
            costo += m.obtenerCostoPieza(this.dgvMantenimientosCorr.SelectedRows.Count.ToString());

            int id = m.obtenerIdEquipoMto(this.cmbFallo.SelectedItem.ToString(), this.cmbEquipo.SelectedItem.ToString(), "Predictivo");

            m.RegistrarOrden(id, costo, this.Fecha.Value.ToString("yyyy-MM-dd"), this.txtDuracion.Text, "XDXDXD");
        }
    }
}
