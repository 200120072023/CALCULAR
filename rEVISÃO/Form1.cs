namespace rEVISÃO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_DIVISÃO_Click(object sender, EventArgs e)
        {
            calcular dv = new calcular();
            dv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (radioButton1.Checked) 
            {
              sexo = radioButton1.Text; 
              
            }
            else if(radioButton2.Checked)
            { 
             sexo = radioButton2.Text;
            }
            MessageBox.Show(sexo);
        }
    }
}