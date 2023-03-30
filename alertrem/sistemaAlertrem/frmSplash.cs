using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAlertrem
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void btnLoading_Click(object sender, EventArgs e)
        {
            pgbLoading.Value = pgbLoading.Value + 10;
            lblPorcent.Text = pgbLoading.Value.ToString() + " %";
            lblLoading.Visible = true;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (pgbLoading.Value < 100)
            {
                pgbLoading.Value = pgbLoading.Value + 5;
                lblPorcent.Text = pgbLoading.Value.ToString() + " %";
                lblLoading.Visible = true;
            }
            else
            {
                tmrTime.Enabled = false;
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
