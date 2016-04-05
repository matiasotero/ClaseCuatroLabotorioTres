using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseCuatro
{
    public partial class FrmB : Form
    {
        public FrmB()
        {
            InitializeComponent();
            this.Load += this.FrmB_Load;
        }

        private void FrmB_Load(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = (FrmPrincipal)this.Owner;
            frmPrincipal.FuncionX = this.MostrarSaludo;
        }

        private void MostrarSaludo(string saludo)
        {
            this.lblSaludo.Text = saludo;
        }
    }
}
