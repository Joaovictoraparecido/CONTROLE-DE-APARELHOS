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
    public partial class Form3 : Form
    {
        Thread nj;
        public Form3()
        {
            InitializeComponent();
        }

        private void aPARELHOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPARELHOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONTROLE_APARELHOSDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONTROLE_APARELHOSDataSet.APARELHOS'. Você pode movê-la ou removê-la conforme necessário.
            this.aPARELHOSTableAdapter.Fill(this.cONTROLE_APARELHOSDataSet.APARELHOS);

        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            PesquisarTextbox_TextChanged(sender, e);

        }

        private void PesquisarTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = PesquisarTextbox.Text.Trim();

                if (string.IsNullOrEmpty(filtro))
                {
                    // Se o campo de pesquisa estiver vazio, exibir todos os dados
                    aPARELHOSBindingSource.RemoveFilter();
                }
                else
                {
                    // Filtrar os dados com base no texto inserido no campo de pesquisa
                    string expressao = string.Format("NOME LIKE '%{0}%' OR CPF LIKE '%{0}%' OR RG LIKE '%{0}%' OR APARELHO LIKE '%{0}%' OR NUMERO LIKE '%{0}%' OR SETOR LIKE '%{0}%' OR ESTADO LIKE '%{0}%' OR OBSERVAÇÃO LIKE '%{0}%' OR DATA LIKE '%{0}%'", filtro);
                    aPARELHOSBindingSource.Filter = expressao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar dados: {ex.Message}");
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            nj = new Thread(novoform4);
            nj.SetApartmentState(ApartmentState.STA);
            nj.Start();
        }
        private void novoform4()
        {
            Application.Run(new Form2());
        }
    }
}
