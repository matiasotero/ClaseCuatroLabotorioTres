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
    public delegate void DelegadoString(string x);
    public partial class FrmPrincipal : Form
    {
        public DelegadoString FuncionX;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.Load += this.FrmPrincipal_Load;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.btnBotonA.Click += this.btnBotonA_Click;
            this.btnBotonB.Click += this.btnBotonB_Click;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBotonA_Click(object sender, EventArgs e)
        {
            FrmA frmA = new FrmA();
            frmA.MdiParent = this;
            frmA.Show();
        }

        private void btnBotonB_Click(object sender, EventArgs e)
        {
            FrmB frmB = new FrmB();
            frmB.Show(this);
        }
    }
}
