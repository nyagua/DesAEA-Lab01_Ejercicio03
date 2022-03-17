using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            int num, num2, suma;
            num = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            suma = num + num2;
            restSuma.Text = suma.ToString();

        }

        private void LimpiarSum_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            restSuma.Clear();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            int num, num2, resta;
            num = Convert.ToInt32(txtNumX.Text);
            num2 = Convert.ToInt32(txtNumY.Text);
            resta = num - num2;
            restResta.Text = resta.ToString();
        }

        private void LimpiarRest_Click(object sender, EventArgs e)
        {
            txtNumX.Clear();
            txtNumY.Clear();
            restResta.Clear();
        }

        private void Multpl_Click(object sender, EventArgs e)
        {
            int num, num2, multpl;
            num = Convert.ToInt32(txtNumF.Text);
            num2 = Convert.ToInt32(txtNumH.Text);
            multpl = num * num2;
            restMult.Text = multpl.ToString();
        }

        private void LimpiarMult_Click(object sender, EventArgs e)
        {
            txtNumF.Clear();
            txtNumH.Clear();
            restMult.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int num, num2, div;
            num = Convert.ToInt32(txtNumT.Text);
            num2 = Convert.ToInt32(txtNumP.Text);
            div = num / num2;
            restDiv.Text = div.ToString();
        }

        private void LimpiarDiv_Click(object sender, EventArgs e)
        {
            txtNumT.Clear();
            txtNumP.Clear();
            restDiv.Clear();
        }

        private void convFarenheit_Click(object sender, EventArgs e)
        {
            int celcius, convert;
            celcius = Convert.ToInt32(txtCelc.Text);
            convert = ((celcius * 9)/5)+32;
            txtFaren.Text = convert.ToString();
        }

        private void LimpFarenheit_Click(object sender, EventArgs e)
        {
            txtCelc.Clear();
            txtFaren.Clear();
        }

        private void ConvCelc_Click(object sender, EventArgs e)
        {
            int farenheit, convert;
            farenheit = Convert.ToInt32(txtF.Text);
            convert = (5 * (farenheit - 32)) / 9;
            txtC.Text = convert.ToString();
        }

        private void LimpCelc_Click(object sender, EventArgs e)
        {
            txtF.Clear();
            txtC.Clear();
        }
    }
}
