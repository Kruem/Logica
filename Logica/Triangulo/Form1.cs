using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l1=0, l2=0, l3=0;

            if (string.IsNullOrEmpty(txtl1.Text))
            {

                MessageBox.Show("Debe completar lado 1");

                return;
            }
            if (string.IsNullOrEmpty(txtl2.Text))
            {

                MessageBox.Show("Debe completar lado 2");

                return;
            }
            if (string.IsNullOrEmpty(txtl3.Text))
            {

                MessageBox.Show("Debe completar lado 3");

                return;
            }


            l1 = Convert.ToDouble(txtl1.Text);
            l2 = Convert.ToDouble(txtl2.Text);
            l3 = Convert.ToDouble(txtl3.Text);

            

            if ((l1 == l2 && l2 == l3)  )
            {
                txtsolucion.Text = "son iguales";
            }
            else
            {
                if (l1 == l2 || l1 != l3 || l2 == l3 || l1 != l2)
                {
                    txtsolucion.Text = "tiene dos lados";
                }
                else
                {
                    if (l1!=l2 && l2!=l3 && l1!=l3 )
                    {
                        txtsolucion.Text = "son diferentes";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
