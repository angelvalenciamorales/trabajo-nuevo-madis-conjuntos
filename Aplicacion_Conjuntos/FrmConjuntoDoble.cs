using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Conjuntos
{
    public partial class FrmConjuntoDoble : Form
    {
        private HashSet<string> conjuntoA = new HashSet<string>();
        private HashSet<string> conjuntoB = new HashSet<string>();
        private HashSet<string> unionAB = new HashSet<string>();
        private HashSet<string> interseccionAB = new HashSet<string>();
        private HashSet<string> diferenciaAB = new HashSet<string>();
        private HashSet<string> diferenciaBA = new HashSet<string>();
        private HashSet<string> diferenciaSimetrica = new HashSet<string>();

        ConjuntoDoble conjunto;

        public FrmConjuntoDoble()
        {
            InitializeComponent();
        }

        public void obtenerElementosConjuntoA()
        {
            for (int i=0; i< this.txtConjuntoA.Lines.Count(); i++)
            {
                this.conjuntoA.Add(this.txtConjuntoA.Lines[i]);
            }
        }

        public void obtenerElementosConjuntoB()
        {
            for (int i = 0; i < this.txtConjuntoB.Lines.Count(); i++)
            {
                this.conjuntoB.Add(this.txtConjuntoB.Lines[i]);
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            obtenerElementosConjuntoA();
            obtenerElementosConjuntoB();

            this.txtConjuntoA.Enabled = false;
            this.txtConjuntoB.Enabled = false;

            conjunto = new ConjuntoDoble(this.conjuntoA,this.conjuntoB);
            unionAB = conjunto.operarUnion();
            interseccionAB = conjunto.operarInterseccion();
            diferenciaAB = conjunto.operarDiferenciaAB();
            
            diferenciaSimetrica = conjunto.operarDiferenciaSimetrica();
            mostrarResultados();
            this.btnOperar.Enabled = false;
        }

        public void mostrarResultados()
        {
            if (unionAB.Count == 0)
            {
                this.txtUnionAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in unionAB)
                {
                    this.txtUnionAB.Text += (elemento + ",");
                }
            }

            if (interseccionAB.Count == 0)
            {
             

                
                this.txtInterseccionAB.Text = "Conjunto Vacio";
            }
            else 
            {
                foreach (String elemento in interseccionAB)
                {
                    
                    
                        
                    this.txtInterseccionAB.Text += (elemento + ",");

                    
                    // HashSet<string> interseccionABb = new HashSet<string>(conjuntoA);
                    //interseccionABb.IntersectWith(conjuntoB);
                }
            }

            if (diferenciaAB.Count == 0)
            {
                this.txtDiferenciaAB.Text = "Conjunto Vacio";
            }
            else
            {
                foreach (string elemento in diferenciaAB)
                {
                    
                    this.txtDiferenciaAB.Text += (elemento + ", ");
                }
            }

           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            this.txtConjuntoA.Clear();
            this.txtConjuntoB.Clear();
            this.txtUnionAB.Clear();
            this.txtInterseccionAB.Clear();
            this.txtDiferenciaAB.Clear();
           
            this.txtConjuntoA.Enabled = true;
            this.txtConjuntoB.Enabled = true;
            this.btnOperar.Enabled = true;
            this.conjuntoA.Clear();
            this.conjuntoB.Clear();
            this.unionAB.Clear();
            this.interseccionAB.Clear();
            this.diferenciaAB.Clear();
            this.txtConjuntoA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}