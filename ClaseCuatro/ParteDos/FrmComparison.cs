using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison
{
    public partial class Comparison : Form
    {
        private List<Perro> _listaDePerros;
        private Comparison<Perro> _comparador;

        public Comparison()
        {
            InitializeComponent();
            this.Load += this.Comparison_Load;
        }

        private void Comparison_Load(object sender, EventArgs e)
        {
            this._listaDePerros = new List<Perro>();
            Perro perroUno = new Perro("Bobby", 3);
            Perro perroDos = new Perro("Camila", 7);
            Perro perroTres = new Perro("Canela", 4);
            Perro perroCuatro = new Perro("Pancho", 6);
            this._listaDePerros.Add(perroUno);
            this._listaDePerros.Add(perroDos);
            this._listaDePerros.Add(perroTres);
            this._listaDePerros.Add(perroCuatro);
            this.RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.lstListado.Items.Clear();
            foreach (Perro item in this._listaDePerros)
            {
                this.lstListado.Items.Add(item);
            }
        }

        private void OrdenarLista()
        {
            if (this.rdoAscendente.Checked)
                this._comparador += Perro.OrdenarPorNombreAscendente;
            else
                this._comparador += Perro.OrdenarPorNombreDescendente;
            this._listaDePerros.Sort(this._comparador);
            this.RefrescarLista();
        }

        private void rdoAscendente_CheckedChanged(object sender, EventArgs e)
        {
            this.OrdenarLista();
        }

        private void rdoDescendente_CheckedChanged(object sender, EventArgs e)
        {
            this.OrdenarLista();
        } 
    }
}
