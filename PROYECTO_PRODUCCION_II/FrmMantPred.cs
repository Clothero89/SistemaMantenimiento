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
            this.cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPieza.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFallo.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void FrmMantPred_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.validar();
            
        }

        private void validar()
        {
            if (this.costoAlter.Text.Equals("") || this.costoInsp.Text.Equals(""))
            {
                MessageBox.Show("Aún hay campos vacíos.", "Error al guardar");
            }
            else if (Convert.ToInt32(this.costoAlter.Text.ToString()) < 1 || 
                Convert.ToInt32(this.costoInsp.Text.ToString()) < 1)
            {
                MessageBox.Show("Ingrese un valor mayor que cero.", "Error al guardar");
            }
            else if (Convert.ToInt32(this.duracion.Text.ToString()) < 5)
            {
                MessageBox.Show("La duración no puede ser menor de 5 mins.", "Error al guardar");
            }
            else if (this.cmbEmpleado.Text.Equals(""))
            {
                MessageBox.Show("Porfavor seleccione al Empleado.", "Error al guardar");
            }
            else if (this.cmbEquipo.Text.Equals(""))
            {
                MessageBox.Show("Porfavor seleccione el Equipo.", "Error al guardar");
            }
            else if (this.cmbPieza.Text.Equals(""))
            {
                MessageBox.Show("Porfavor seleccione la Pieza.", "Error al guardar");
            }
            else if (this.cmbFallo.Text.Equals(""))
            {
                MessageBox.Show("Porfavor seleccione el Fallo.", "Error al guardar");
            }
            else
            {
                registrar();
                resetearCampos();
            }
        }

        private void registrar()
        {
            double cc = Math.Round(float.Parse(this.costoInsp.Text) / float.Parse(this.costoAlter.Text), 4);

            double tiempoFallo = 1.0000 / m.TiempoFallo(cmbPieza.SelectedItem.ToString());
            double cantidadFallo = m.CantidadFalloPieza(cmbPieza.SelectedItem.ToString());

            double f = Math.Round((cantidadFallo / tiempoFallo), 3);
            double a = Math.Round((-Math.Log(1 - Math.Exp(-tiempoFallo))), 3);
            double i = Math.Round(1 / (cc * f * a), 0);
            double equivalente = Math.Round(i / 12, 0);
            String desc = "";

            if (equivalente < 1)
            {
                 desc = $"Para esta pieza se requiere apróximadamente de {i} inspecciones al año";

            }

            else
            {
                desc = $"Para esta pieza se requieren apróximadamente {i} inspecciones al año, que equivale a {equivalente} por mes";

            }

            float costo = float.Parse(this.costoInsp.Text) + float.Parse(this.costoAlter.Text);
            costo += m.obtenerCostoPieza(this.cmbPieza.SelectedItem.ToString());
            int tiempo = Convert.ToInt32(this.duracion.Text.ToString());
            TimeSpan t = TimeSpan.FromMinutes(tiempo);
            String d = t.ToString("hh':'mm");

            int id = m.obtenerIdEquipoMto(this.cmbFallo.SelectedItem.ToString(), 
            this.cmbEquipo.SelectedItem.ToString(), "Predictivo");

            m.RegistrarOrden(id, costo, this.fecha.Value.ToString("yyyy-MM-dd"), d, desc);

            MessageBox.Show(desc);

        }

        private void CargarPiezas(object sender, EventArgs e)
        {
            m.CargarPieza(this.cmbPieza, "CargarPiezaEquipo", "Equipo", this.cmbEquipo.SelectedItem.ToString());
        }

        private void CargarFallo(object sender, EventArgs e)
        {
            m.CargarFallo(this.cmbFallo, this.cmbPieza.SelectedItem.ToString());
        }

        private void Validar(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(e);
        }

        private void Validar2(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(e);
        }

        private void validar3(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void resetearCampos()
        {
            this.cmbEmpleado.Items.Clear();
            this.cmbEquipo.Items.Clear();
            this.cmbPieza.Items.Clear();
            this.cmbFallo.Items.Clear();
            this.duracion.Text = "";
            this.costoAlter.Text = "";
            this.costoInsp.Text = "";
            m.CargarComboBoxs(this.cmbEmpleado, "VerEmpleados", "Nombre");
            m.CargarComboBoxs(this.cmbEquipo, "CargarEquipo", "Nombre");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetearCampos();
        }
    }
}
