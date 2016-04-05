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
    public partial class FrmA : Form
    {
        public FrmA()
        {
            InitializeComponent();
            this.Load += this.FrmA_Load;
        }

        private void FrmA_Load(object sender, EventArgs e)
        {
            this.btnSaludar.Click += this.btnSaludar_Click;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = (FrmPrincipal)this.MdiParent;
            if (frmPrincipal.FuncionX != null)
                frmPrincipal.FuncionX("Hola mundo");
        }
    }
}
