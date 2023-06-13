using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rEVISÃO
{
    public partial class calcular : Form
    {
        public calcular()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;

                lb_resultado.Text = c.ToString();

            }catch (Exception ex) 
            {
                MessageBox.Show( "erro ao dividir!");
            }
           

           


        }
    }
}
