using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorRut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool rutverificado = false;
        bool rutNumero = true;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string[] rutVector;

            string rut = textBox1.Text.ToUpper();
            
            rutVector = rut.Split('.','-');
            rut = "";
            foreach (string text in rutVector)
            {
                rut += text;
            }

            for (int i = 0; i < (rut.Length-1); i++)
            {
                if (!Char.IsDigit(rut[i]))
                {
                    rutNumero = false;
                }
            }
            if (rutNumero)
            {
                

                if (rut.Length < 9)
                {
                    //se agrega 0 a menos digitos
                    while (rut.Length != 9)
                    {
                        rut = "0" + rut;
                    }
                }
                //operaion para validar
                double suma = 0;
                double divisionDec = 0;
                int divisionEnt = 0;
                double valorDec = 0;
                double resta11 = 0;
                int digito = 0;
                string digitok;
                //se añade una arreglo para el rut y las constantes
                int[] constantes = { 3, 2, 7, 6, 5, 4, 3, 2 };
                int[] rutarreglo;
                rutarreglo = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    rutarreglo[i] = Int32.Parse(rut[i].ToString());
                    suma = suma + (rutarreglo[i] * constantes[i]);
                }
                divisionDec = suma / 11;
                divisionEnt = (int)divisionDec;
                valorDec = divisionDec - divisionEnt;
                resta11 = 11 - (11 * (valorDec));
                //El problema se resuelve redondeando con 0 decimales para que llegue al nuemro entero mas cercano.
                digito = (int)Math.Round(resta11, 0);
                //Asignar valores para digitos verificadores 0 y k;
                if (digito == 10)
                {
                    digitok = "K";
                    label3.Text = digitok;
                }
                else
                    if (digito == 11)
                {
                    digito = 0;
                    label3.Text = digito.ToString();
                }
                else
                {
                    label3.Text = digito.ToString();
                }
                if (label3.Text == Convert.ToString(rut[8]))
                {
                    MessageBox.Show("El digito verificador está correcto", "Codigo correcto", MessageBoxButtons.OK);
                    rutverificado = true;
                }
                else
                {
                    MessageBox.Show("El digito verificador es incorrecto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rutverificado = false;
                }
            }
            else
            {
                MessageBox.Show("El rut debe contener solo digitos, excepto si termina en k", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string[] rutVector;

            string rut = textBox1.Text.ToUpper();

            rutVector = rut.Split('.', '-');
            rut = "";
            foreach (string text in rutVector)
            {
                rut += text;
            }
            for (int i = 0; i < rut.Length; i++)
            {
                if (!Char.IsDigit(rut[i]))
                {
                    rutNumero = false;
                    labelValidador.Text = "El texto solo debe tener numeros";
                }
                else
                {
                    labelValidador.Text = "TEXTO PRUEBA";
                }
            }
            if (rut.Length < 9)
            {
                while (rut.Length != 9)
                {
                    rut = "0" + rut;
                }
            }
            double suma = 0;
            double divisionDec = 0;
            int divisionEnt = 0;
            double valorDec = 0;
            double resta11 = 0;
            int digito = 0;
            string digitok;
            int[] constantes = { 3, 2, 7, 6, 5, 4, 3, 2 };
            int[] rutarreglo;
            rutarreglo = new int[8];
            for (int i = 0; i < 8; i++)
            {
                rutarreglo[i] = Int32.Parse(rut[i].ToString());
                suma = suma + (rutarreglo[i] * constantes[i]);
            }
            divisionDec = suma / 11;
            divisionEnt = (int)divisionDec;
            valorDec = divisionDec - divisionEnt;
            resta11 = 11 - (11 * (valorDec));
            digito = (int)Math.Round(resta11, 0);
            if (digito == 10)
            {
                digitok = "K";
            }
            else
                if (digito == 11)
            {
                digito = 0;
            }
            else
            {
                label3.Text = digito.ToString();
            }
            if (label3.Text == Convert.ToString(rut[8]))
            {
                labelValidador.Text = "Rut correcto";
                rutverificado = true;
            }
            else
            {
                labelValidador.Text = "Rut incorrecto";
                rutverificado = false;
            }
        }
    }
}
