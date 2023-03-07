using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = auxiliar;

            MessageBox.Show("Troca de valores concluída", "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
