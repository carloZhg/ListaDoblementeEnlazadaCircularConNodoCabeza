using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoblementeEnlazadaCircularConNodoCabeza
{
    public partial class Form1 : Form
    {

        ListaDobleEnlazadaConNodoCabeza ldecc = new ListaDobleEnlazadaConNodoCabeza();

        public void MostrarCabeza()
        {
            NodoDoble p;
            listView1.Clear();
            p = ldecc.cabeza.Enlace;
            while (p != null)
            {
                listView1.Items.Add(p.Informacion.ToString());
                p = p.EnlaceDerecho;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ldecc.insertar(Convert.ToChar(txtElemento.Text.ToString()));
            ldecc.insertar(Int32.Parse(textBox1.Text));
            textBox2.Text = ldecc.cabeza.CantidadElementos.ToString();
            textBox1.Clear();
            textBox1.Focus();

      
            MostrarCabeza();
        }
    }
}
