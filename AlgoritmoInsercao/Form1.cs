using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgoritmoInsercao
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        
        int[] numerosInteiros = new int[50];
        int[] numerosOrdenados = new int[50];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i =1; i < numerosInteiros.Count()-1; i++)
            {
                int returnValue = RandomNumber(1, 499);
                numerosInteiros[i]= returnValue;
                lstaNaoOrdenada.Items.Add(numerosInteiros[i].ToString() + " ");
            }
            label4.Text = numerosInteiros.Count().ToString();
        }
        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           numerosOrdenados = ordenar(numerosInteiros);
           for (int i = 1; i < numerosOrdenados.Length; i++)
           {
               lstaOrdenada.Items.Add(numerosOrdenados[i].ToString() + " ");
           }
           label5.Text = lstaOrdenada.Items.Count.ToString();
        }

        static int[] ordenar(int[] A)
        {
            int i, j, index;
            for (i = 1; i > A.Length; i++)
            {
                index = A[i];
                j = i;
                while ((j > 0) && (A[j - 1] > index))
                {
                    A[j] = A[j - 1];
                    j = j - 1;
                }
                A[j] = index;
            }
            return A;
        }

    }
}
