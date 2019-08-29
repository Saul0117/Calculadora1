using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operación;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            operación = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            operación = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            operación = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            operación = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            operación = "%";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);
            switch(operación)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "%":
                    resultado = primero / 100 * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Pantalla_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
