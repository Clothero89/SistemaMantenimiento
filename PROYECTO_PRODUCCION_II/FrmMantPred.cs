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
    public partial class FrmMantPred : Form
    {
        Connection cnt;
        Mantenimiento m = new Mantenimiento();

        public FrmMantPred()
        {
            InitializeComponent();
           this.dataGridView2.DataSource = m.cargarOrden();
        }

        public FrmMantPred(Connection cnt)
        {
            this.cnt = cnt;
            InitializeComponent();
            this.dataGridView2.DataSource = m.cargarOrden();
            m.CargarComboBoxs(this.cmbEmpleado, "VerEmpleados", "Nombre");
            m.CargarComboBoxs(this.cmbEquipo, "CargarEquipo", "Nombre");
            
        }

        private void FrmMantPred_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            float costo = float.Parse(this.costoInsp.Text) + float.Parse(this.costoAlter.Text);
            costo += m.obtenerCostoPieza(this.cmbPieza.SelectedItem.ToString());

            int id = m.obtenerIdEquipoMto(this.cmbFallo.SelectedItem.ToString(), 
                this.cmbEquipo.SelectedItem.ToString(), "Predictivo");

            m.RegistrarOrden(id, costo, this.fecha.Value.ToString("yyyy-MM-dd"), this.duracion.Text, "XDXDXD");
        }

        private void CargarPiezas(object sender, EventArgs e)
        {
            m.CargarPieza(this.cmbPieza, "CargarPiezaEquipo", "Equipo", this.cmbEquipo.SelectedItem.ToString());
        }

        private void CargarFallo(object sender, EventArgs e)
        {
            m.CargarFallo(this.cmbFallo, this.cmbPieza.SelectedItem.ToString());
        }

    }
}
