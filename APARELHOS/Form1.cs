using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APARELHOS
{

   
    public partial class Form1 : Form
    {
        private Thread nj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aparelho_Click(object sender, EventArgs e)
        {
            this.Close();
            nj = new Thread(novoform1);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform1()
        {
            Application.Run(new Form2());
        }
   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform1);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform2()
        {
            Application.Run(new Form2());
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform3);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform3()
        {
            Application.Run(new Form3());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            this.Close();
            nj = new Thread(novoform4);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform4()
        {
            Application.Run(new Form3());
        }

        private void Aparelhos_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform5);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform5()
        {
            Application.Run(new Form4());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform8);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform8()
        {
            Application.Run(new Form4());
        }
    }
}
