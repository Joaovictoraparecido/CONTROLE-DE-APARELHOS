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
    public partial class Form2 : Form
    {
        Thread nj;
        public Form2()
        {
            InitializeComponent();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONTROLE_APARELHOSDataSet.APARELHOS'. Você pode movê-la ou removê-la conforme necessário.
            this.aPARELHOSTableAdapter.Fill(this.cONTROLE_APARELHOSDataSet.APARELHOS);

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPARELHOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONTROLE_APARELHOSDataSet);

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            aPARELHOSBindingSource.AddNew();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            aPARELHOSBindingSource.RemoveCurrent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform2);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform2()
        {
            Application.Run(new Form1());
        }
    }
}
