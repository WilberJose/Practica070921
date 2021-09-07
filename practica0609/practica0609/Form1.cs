using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Evento load(), Inicia cuando se ejecita la aplicacion
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Programacion computacional I");
        }
        //evento(), se ejecuta cuando damos click al objeto

        private void button1_Click(object sender, EventArgs e)
        {
            //declarar un arreglo numero
            int[] nums = new int[] { 8, 9, 4, 6, 7, 10, 8 };

            //lenar el ListBox utilizando Linq

            var num = from n in nums select n; //usamos sintaxis linq para leer arreglos
            foreach (int i in num)
                listBox1.Items.Add(i); //llenar listbox
        }
    }
}
