using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFinal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtnota1.Text);
            double nota2 = double.Parse(txtnota2.Text);
            double nota3 = double.Parse(txtnota3.Text);
            double nota4 = double.Parse(txtnota4.Text);
            double nota5 = double.Parse(txtnota5.Text);

            double promedio = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

            if (promedio >=0 && promedio <=1)
            {
                MessageBox.Show("Reprueba la materia sin oportunidad de hacer recuperación.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="Promedio:"+promedio.ToString();               
            }
            if (promedio >=1.1 && promedio <= 2.9)
            {
                MessageBox.Show("Reprueba la materia y puede hacer recuperación.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="promedio:"+promedio.ToString();
            }
            if (promedio>=3 && promedio <=3.9)
            {
                MessageBox.Show("Aprueba la materia con plan de mejora.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="Promedio:"+promedio.ToString();
            }
            if (promedio >=4 && promedio <=4.5)
            {
                MessageBox.Show("Aprueba con buen rendimiento.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="Promedio:"+promedio.ToString();
            }
            if (promedio >= 4.6 && promedio <= 4.9)
            {
                MessageBox.Show("Aprueba la materia con un excelente rendimiento.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="Promedio:"+promedio.ToString();
            }
            if (promedio == 5)
            {
                MessageBox.Show("Graduado con honores.");
                lblpromedio.Visible = true;
                lblpromedio.Text ="Promedio:"+promedio.ToString();
            }
        }
    }
}
