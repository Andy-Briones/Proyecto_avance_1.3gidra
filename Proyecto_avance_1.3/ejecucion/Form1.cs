using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucion
{
    public partial class Form1 : Form
    {
        //public SoundPlayer audios = new SoundPlayer();
        Cola vidas = new Cola();
        Pila puntaje = new Pila();

        public Form1()
        {
            InitializeComponent();
            //audios.SoundLocation = "C:/Users/AMD/Desktop/C#/Proyecto_avance_1.3/song/pokemon.wav";
            //audios.PlayLooping();
            //imagenes no se muestran
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //se encolan las vidas para validación futura
            vidas.Encolar(CjVida3);
            vidas.Encolar(CjVida2);
            vidas.Encolar(CjVida1);
        }
        //aca empiezan todas las condiciones para validar la igualdad de las cartas(imagenes)
        private void boton_ver_Click(object sender, EventArgs e)
        {
            //se esconden las imagenes
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //validamos si en la cola quedan vidas o no
            if (vidas.frente != null)
            {
                //validar condiciones
                if (Caja1res.Text.ToLower() == "a" && Caja2res.Text.ToLower() == "b")//ab
                {
                    pictureBox1.Show();
                    pictureBox2.Show();
                    if (pictureBox1 == pictureBox2)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        //apila puntaje
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "b" && Caja2res.Text.ToLower() == "a")//ba
                {
                    pictureBox1.Show();
                    pictureBox2.Show();
                    if (pictureBox1 == pictureBox2)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "a" && Caja2res.Text.ToLower() == "c")//ac
                {
                    pictureBox1.Show();
                    pictureBox3.Show();
                    if (pictureBox1.AccessibleName == pictureBox3.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "c" && Caja2res.Text.ToLower() == "a")//ca
                {
                    pictureBox1.Show();
                    pictureBox3.Show();
                    if (pictureBox1.AccessibleName == pictureBox3.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "b" && Caja2res.Text.ToLower() == "c")//bc
                {
                    pictureBox2.Show();
                    pictureBox3.Show();
                    if (pictureBox2.AccessibleName == pictureBox3.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "c" && Caja2res.Text.ToLower() == "b")//cb
                {
                    pictureBox2.Show();
                    pictureBox3.Show();
                    if (pictureBox2.AccessibleName == pictureBox3.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "a" && Caja2res.Text.ToLower() == "d")//ad
                {
                    pictureBox1.Show();
                    pictureBox4.Show();
                    if (pictureBox1.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "d" && Caja2res.Text.ToLower() == "a")//da
                {
                    pictureBox1.Show();
                    pictureBox4.Show();
                    if (pictureBox1.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "b" && Caja2res.Text.ToLower() == "d")//bd
                {
                    pictureBox2.Show();
                    pictureBox4.Show();
                    if (pictureBox2.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "d" && Caja2res.Text.ToLower() == "b")//db
                {
                    pictureBox2.Show();
                    pictureBox4.Show();
                    if (pictureBox2.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "c" && Caja2res.Text.ToLower() == "d")//cd
                {
                    pictureBox3.Show();
                    pictureBox4.Show();
                    if (pictureBox3.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
                else if (Caja1res.Text.ToLower() == "d" && Caja2res.Text.ToLower() == "c")//dc
                {
                    pictureBox3.Show();
                    pictureBox4.Show();
                    if (pictureBox3.AccessibleName == pictureBox4.AccessibleName)
                    {
                        MessageBox.Show("Correcto, son iguales");
                        MessageBox.Show("Ganas 100 puntos");
                        puntaje.apilar2(100);
                    }
                    else
                    {
                        vidas.Descolar();
                        if (CjVida3.Visible == true)
                        {
                            CjVida3.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == true)
                        {
                            CjVida2.Hide();
                        }
                        else if (CjVida3.Visible == false && CjVida2.Visible == false && CjVida1.Visible == true)
                        {
                            CjVida1.Hide();
                        }
                        MessageBox.Show("Incorrecto, intenta otra vez");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya no te quedan más vidas"+"\n\tGame over"+"\n\tAgrega tu nombre para la clasificación");
                boton_Sal_Pant.Show();
            }
        }
        private void buttonpunt_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //En la listview se muestra el puntaje que ganas
            ListViewItem item = new ListViewItem();
            label_puntaje.Text = puntaje.punt.ToString();
            if (puntaje.cima == null)
            {
                MessageBox.Show("No hay puntajes");
            }
            else
            {
                item = listView1.Items.Add(puntaje.cima.Dato.ToString());
                item.SubItems.Add("\n");
            }
        }

        private void boton_Sal_Pant_Click(object sender, EventArgs e)
        {
            //abre el otro fromulario
            this.Hide();
            Form2 nombre = new Form2();
            nombre.Show();
        }
    }
}
