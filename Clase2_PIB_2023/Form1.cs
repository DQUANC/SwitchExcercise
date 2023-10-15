using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_PIB_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calificacion = textBox1.Text.ToUpper();

            switch (calificacion)
            {
                case "A":
                    label3.Text = "Excelente";
                    break;
                case "B":
                    label3.Text = "Buena";
                    break;
                case "C":
                    label3.Text = "Regular";
                    break;
                case "D":
                    label3.Text = "Suficiente";
                    break;
                case "E":
                    label3.Text = "Suficiente";
                    break;
                case "F":
                    label3.Text = "Insuficiente";
                    break;
                default:
                    label3.Text = "Calificacion no valida";
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numeroRomano = textBox2.Text.ToUpper();

            switch (numeroRomano)
            {
                case "I":
                    label5.Text = "I es igual a: 1";
                    break;
                case "II":
                    label5.Text = "II es igual a: 2";
                    break;
                case "III":
                    label5.Text = "III es igual a: 3";
                    break;
                case "IV":
                    label5.Text = "IV es igual a: 4";
                    break;
                case "V":
                    label5.Text = "V es igual a: 5";
                    break;
                case "VI":
                    label5.Text = "VI es igual a: 6";
                    break;
                case "VII":
                    label5.Text = "VII es igual a: 7";
                    break;
                case "VIII":
                    label5.Text = "VIII es igual a: 8";
                    break;
                case "IX":
                    label5.Text = "IX es igual a: 9";
                    break;
                case "X":
                    label5.Text = "X es igual a: 10";
                    break;
                default:
                    label5.Text = "No detecto ese numero en el rango solicitado";
                    break;

            }
        }
    }
}
