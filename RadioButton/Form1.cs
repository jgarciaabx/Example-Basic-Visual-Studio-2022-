using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        String tamañoPerro = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void txtTitulo_Click(object sender, EventArgs e)

        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tamañoPerro = "Grande";
            txtTamaño.Text = tamañoPerro;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tamañoPerro = "Mediano";
            txtTamaño.Text = tamañoPerro;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tamañoPerro = "Chico";
            txtTamaño.Text = tamañoPerro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // txtTamaño.Text = tamañoPerro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtName.Text + "\nSexo: " + txtSex.Text + "\nTamaño: " + txtTamaño.Text , "Datos Ingresados :)");
        }
    }
}
