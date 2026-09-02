using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucion
{
    public partial class Form2 : Form
    {
        ListaSimple ls = new ListaSimple();
        Persona ps = new Persona();
        Grafo gf = new Grafo(6);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps.name = CajaNombre.Text;
            ps.age = int.Parse(CajaEdad.Text);
            ls.insertar(ps); 
            ListViewItem item = new ListViewItem();
            if (ls.primero == null)
            {
                MessageBox.Show("No hay nombres");
            }
            else
            {
                item = listView1.Items.Add(ls.primero.Per.ToString());
                item.SubItems.Add("\n");
            }
        }

        private void button_abrir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
