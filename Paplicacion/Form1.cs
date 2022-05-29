using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paplicacion
{
    public partial class Form1 : Form
    {
        private String[] lineas;
        private String[] respuestas;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // asignacion de texto a los combo box y a los label

            radioButton2.Checked = true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // verificacion de respuestas 

            if (comboBox1.SelectedItem.ToString() == respuestas[0])
            {
                label8.Text = "correcto";
            }
            else
            {
                label8.Text = "incorrecto";
            }
            if (comboBox2.SelectedItem.ToString() == respuestas[1])
            {
                label9.Text = "correcto";
            }
            else
            {
                label9.Text = "incorrecto";
            }
            if (comboBox3.SelectedItem.ToString() == respuestas[2])
            {
                label10.Text = "correcto";
            }
            else
            {
                label10.Text = "incorrecto";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_poo.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas de poo.txt");
            this.asignacion(lineas, respuestas);
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_md.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas_de_matematicas_discretas.txt");
            this.asignacion(lineas, respuestas);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_cal.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas_de_calculo.txt");
            this.asignacion(lineas, respuestas);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_cont.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas_de_contabilidad.txt"); 
            this.asignacion(lineas, respuestas);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_fis.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas_de_fisica.txt");
            this.asignacion(lineas, respuestas);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            respuestas = File.ReadAllLines(@"C:\Users\holas\Documents\respuestas_de_adm.txt");
            lineas = File.ReadAllLines(@"C:\Users\holas\Documents\preguntas_de_administracion.txt");
            this.asignacion(lineas, respuestas);
        }
        private void Bsal_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void asignacion(string[]preguntas,string[]respuestas)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            label5.Text = lineas[0];
            label6.Text = lineas[5];
            label7.Text = lineas[10];
            comboBox1.Items.Add(lineas[1]);
            comboBox1.Items.Add(lineas[2]);
            comboBox1.Items.Add(lineas[3]);
            comboBox2.Items.Add(lineas[6]);
            comboBox2.Items.Add(lineas[7]);
            comboBox2.Items.Add(lineas[8]);
            comboBox3.Items.Add(lineas[11]);
            comboBox3.Items.Add(lineas[12]);
            comboBox3.Items.Add(lineas[13]);
        }
    }
}
