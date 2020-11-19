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
    public partial class FrmLogIn : Form
    {
        Connection cnt;

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnAcced_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("ERROR CAMPOS VACIOS.");
            }
            else
            {
                cnt = new Connection(txtUser.Text, txtPass.Text);

                if (cnt.conector.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Connection established. ");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    FrmMain frm = new FrmMain(cnt);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA.");
                }
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
