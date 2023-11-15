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
    public partial class Form5 : Form
    {

        Thread nj;
        public Form5()
        {
            InitializeComponent();
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.exemplo.com" pela URL do site que você deseja abrir
            string url = "https://www.linkedin.com/in/jo%C3%A3o-victor-aparecido-jesus-de-oliveira-5b1400208/";

            // Abre a URL no navegador padrão do sistema
            Process.Start(url);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cONTROLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cONTROLE_APARELHOSDataSet.CONTROLE'. Você pode movê-la ou removê-la conforme necessário.
            this.cONTROLETableAdapter.Fill(this.cONTROLE_APARELHOSDataSet.CONTROLE);

        }

        private void PesquisarTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = PesquisarTextbox.Text.Trim();

                if (string.IsNullOrEmpty(filtro))
                {
                    // Se o campo de pesquisa estiver vazio, exibir todos os dados
                    cONTROLEBindingSource.RemoveFilter();
                }
                else
                {
                    // Filtrar os dados com base no texto inserido no campo de pesquisa
                    string expressao = string.Format("NOME LIKE '%{0}%' OR ESTADO LIKE '%{0}%' OR NUMERO_DE_SERIE LIKE '%{0}%' OR APARELHO LIKE '%{0}%' OR NUMERO_DO_APARELHO LIKE '%{0}%' OR DISPONIVEL LIKE '%{0}%'", filtro);
                    cONTROLEBindingSource.Filter = expressao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar dados: {ex.Message}");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            PesquisarTextbox_TextChanged(sender, e);
        }
    }
}
