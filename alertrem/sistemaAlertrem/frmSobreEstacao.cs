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
    public partial class frmSobreEstacao : Form
    {
        public frmSobreEstacao()
        {
            InitializeComponent();
        }

        private void btnAdicionarSegundoEndereco_Click(object sender, EventArgs e)
        {
            gpbEndereco2.Visible = true;
            btnRemoverEndereco2.Visible = true;
            btnAdicionarTerceiroEndereco.Visible = true;
        }

        private void btnAdicionarTerceiroEndereco_Click(object sender, EventArgs e)
        {
            gpbEndereco3.Visible = true;
            btnRemoverEndereco3.Visible = true;
        }
    }
}
