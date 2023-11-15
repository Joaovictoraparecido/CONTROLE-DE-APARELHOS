using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APARELHOS
{
    public partial class Form4 : Form
    {

        Thread nj;
        public Form4()
        {
            InitializeComponent();
        }

     

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONTROLE_APARELHOSDataSet.CONTROLE'. Você pode movê-la ou removê-la conforme necessário.
            this.cONTROLETableAdapter.Fill(this.cONTROLE_APARELHOSDataSet.CONTROLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONTROLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONTROLE_APARELHOSDataSet);

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            cONTROLEBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cONTROLEBindingSource.RemoveCurrent();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform5);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform5()
        {
            Application.Run(new Form1());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.exemplo.com" pela URL do site que você deseja abrir
            string url = "https://www.linkedin.com/in/jo%C3%A3o-victor-aparecido-jesus-de-oliveira-5b1400208/";

            // Abre a URL no navegador padrão do sistema
            Process.Start(url);
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform9);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform9()
        {
            Application.Run(new Form5());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void SalvarDados_Click(object sender, EventArgs e)

        {
            this.Validate();
            this.cONTROLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONTROLE_APARELHOSDataSet);
        }

       
       
    }
}
