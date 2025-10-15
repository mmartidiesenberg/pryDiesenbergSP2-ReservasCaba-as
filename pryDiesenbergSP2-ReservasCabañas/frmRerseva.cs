using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergSP2_ReservasCabañas
{
    public partial class frmRerseva : Form
    {
        // constantes para los cálculos
        private const float tipoa = 20;
        public const float tipob = 34;
        const float cocina = 1;
        const float heladera = 1.5f;
        const float televisor = 2;
        const float porpersona = 1;
        public frmRerseva()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0) // Tipo A
            {
                cmbPersonas.Items.Add(1);
                cmbPersonas.Items.Add(2);
                cmbPersonas.Items.Add(3);
                cmbPersonas.Items.Add(4);
            }
            else // Tipo B
            {
                cmbPersonas.Items.Add(1);
                cmbPersonas.Items.Add(2);
                cmbPersonas.Items.Add(3);
                cmbPersonas.Items.Add(4);
                cmbPersonas.Items.Add(5);
                cmbPersonas.Items.Add(6);
                cmbPersonas.Items.Add(7);
                cmbPersonas.Items.Add(8);
            }

            cmbPersonas.SelectedIndex = 0;
        }

        private void frmRerseva_Load(object sender, EventArgs e)
        {
            {
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("Tipo A");
                cmbTipo.Items.Add("Tipo B");

                cmbTipo.SelectedIndex = 0;
      
                txtDias.Text = "1";
            
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
     
                btnEfectivo.Checked = true;
                txtNombre.Text = "";
                txtNumerosTelefono.Text = "";
    
                cmbTarjetas.Items.Clear();
                cmbTarjetas.Items.Add("Card Red");
                cmbTarjetas.Items.Add("Card Green");
                cmbTarjetas.Items.Add("Card Blue");
           
                btnAceptar.Enabled = false;
            }
        }

        private void btnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            {
   
                cmbTarjetas.Enabled = false;
                cmbTarjetas.SelectedIndex = -1;
            }
        }

        private void btnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            {

                cmbTarjetas.Enabled = true;
                cmbTarjetas.SelectedIndex = 0;
            }
        }

        private void txtDias_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            {
       
                if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtNumerosTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            {
       
                if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtNumerosTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void txtNumerosTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            {
            
                if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombre.Text != "" && txtNumerosTelefono.Text != "")
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                float PrecioBase;
                float Opcionales;
                float Recargo;
                int Dias;
                float Total;

                Dias = int.Parse(txtDias.Text);

                if (cmbTipo.SelectedIndex == 0)
                {
                    PrecioBase = tipoa;
                }
                else
                {
                    PrecioBase = tipob;
                }

                PrecioBase = PrecioBase + (porpersona * int.Parse(cmbPersonas.Text));

                Opcionales = 0;
                if (chkCocina.Checked == true)
                {
                    Opcionales = Opcionales + cocina;
                }
                if (chkHeladera.Checked == true)
                {
                    Opcionales = Opcionales + heladera;
                }
                if (chkTelevisor.Checked == true)
                {
                    Opcionales = Opcionales + televisor;
                }

                Total = (PrecioBase + Opcionales) * Dias;

                if (btnTarjeta.Checked == true)
                {
                    if (cmbTarjetas.SelectedIndex == 0)
                    {
                        Recargo = Total * 10 / 100;
                    }
                    else
                    {
                        Recargo = Total * 20 / 100;
                    }
                    Total = Total + Recargo;
                }

                MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarUI();
            }
            void LimpiarUI()
            { 
                cmbTipo.SelectedIndex = 0;
                txtDias.Text = "1";
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
            
                btnEfectivo.Checked = true;
                txtNombre.Text = "";
                txtNumerosTelefono.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
