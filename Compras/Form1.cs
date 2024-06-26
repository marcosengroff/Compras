using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter (e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) )
                e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtVTotal.Text = Convert.ToString(Convert.ToDecimal(txtProduto.Text) * nudQTD.Value);

            lblForma.Visible = true;
            radVista.Visible = true;
            radParcelado.Visible = true;

        }

        private void radVista_CheckedChanged(object sender, EventArgs e)
        {
            txtFinal.Text = (Convert.ToDecimal(txtVTotal.Text)  * 0.9m).ToString();
            lblMensagem.Text = "Valor com desconto de 10%: ";
            lblMensagem.Visible = true;
            txtFinal.Visible = true;
        }

        private void radParcelado_CheckedChanged(object sender, EventArgs e)
        {
            txtFinal.Text = (Convert.ToDecimal(txtVTotal.Text) / 3).ToString();
            lblMensagem.Text = "Valor de cada parcela: ";
            lblMensagem.Visible = true;
            txtFinal.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            radVista.Checked = false;
            radParcelado.Checked = false;
            nudQTD.Value = 1;

            txtProduto.Clear();
            txtVTotal.Clear();
            txtFinal.Clear();

            lblForma.Visible = false;
            radVista.Visible = false;
            radParcelado.Visible = false;
            lblMensagem.Visible = false;
            txtFinal.Visible = false;

            txtProduto.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
