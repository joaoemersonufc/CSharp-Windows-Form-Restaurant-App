using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaKabrasa.View
{
    public partial class PainelCaixa : Form
    {
        DateTime HoraAbertura;
        DateTime HoraEncerramento;

        public decimal saldoAnterior;
        public PainelCaixa()
        {
            InitializeComponent();
        }

        private void btnAbriCaixa_Click(object sender, EventArgs e)
        {
            btnAbriCaixa.Enabled = false;
            btnFecharCaixa.Enabled = true;
            HoraAbertura = DateTime.Now;
            labelStatusCaixa.Text = "CAIXA ABERTO";
            label15.Text = HoraAbertura.ToLongTimeString();
            
        }
        
        private void btnAdicionarLan_Click(object sender, EventArgs e)
        {
            using (var lancar = new Lancar())
            {
                saldoAnterior = Convert.ToDecimal(labelSaldoAtual.Text);
                lancar.ShowDialog();


                if (lancar.comboBoxTipo.SelectedItem == null)
                {

                }
                else if (lancar.comboBoxTipo.SelectedItem.ToString() == "Retirada")
                {
                    HoraAbertura = DateTime.Now;
                    dataGridView1.Rows.Insert(0, (HoraAbertura.ToShortDateString() + "/" + HoraAbertura.ToShortTimeString()), lancar.textBoxObs.Text, "", lancar.textBoxValor.Text);
                    if (lancar.textBoxValor.Text != "")
                    {
                        labelSaldoAtual.Text = Convert.ToString((Convert.ToDecimal(labelSaldoAtual.Text) - Convert.ToDecimal(lancar.textBoxValor.Text)));
                    }
                }
                else if (lancar.comboBoxTipo.SelectedItem.ToString() == "Adicionando")
                {
                    HoraAbertura = DateTime.Now;
                    dataGridView1.Rows.Insert(0, (HoraAbertura.ToShortDateString() + "/" + HoraAbertura.ToShortTimeString()), lancar.textBoxObs.Text, lancar.textBoxValor.Text, "");
                    if (lancar.textBoxValor.Text != "")
                    {
                        labelSaldoAtual.Text = Convert.ToString(Convert.ToDecimal(labelSaldoAtual.Text) + Convert.ToDecimal(lancar.textBoxValor.Text));
                    }
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelCaixa_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluirLan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells["Selecionar"].Value) == true) {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            HoraEncerramento = DateTime.Now;
            listCaixa.Items.Insert(0,"CAIXA ENCERRADO R$:" + labelSaldoAtual.Text + " EM: " + HoraEncerramento.ToShortDateString() + " ÀS:" + HoraEncerramento.ToShortTimeString());
            btnAbriCaixa.Enabled = true;
            btnFecharCaixa.Enabled = false;
            labelStatusCaixa.Text = "CAIXA FECHADO";
            labelSaldoAtual.Text = "00,00";
            label17.Text = HoraEncerramento.ToLongTimeString();
            EdtSaldoInicial.Text = labelSaldoAtual.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Selecionar"].Value) == true)
                {
                    using (var lancar = new Lancar())
                    {
                        
                        lancar.ShowDialog();

                        if (lancar.comboBoxTipo.SelectedItem == null)
                        {

                        }
                        else if (lancar.comboBoxTipo.SelectedItem.ToString() == "Retirada")
                        {
                            HoraAbertura = DateTime.Now;
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            dataGridView1.Rows.Insert(i, (HoraAbertura.ToShortDateString() + "/" + HoraAbertura.ToShortTimeString()), lancar.textBoxObs.Text, "", lancar.textBoxValor.Text);

                            if (lancar.textBoxValor.Text != "")
                            {
                                labelSaldoAtual.Text = Convert.ToString(saldoAnterior - Convert.ToDecimal(lancar.textBoxValor.Text));
                            }
                        }
                        else if (lancar.comboBoxTipo.SelectedItem.ToString() == "Adicionando")
                        {
                            HoraAbertura = DateTime.Now;
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            dataGridView1.Rows.Insert(i, (HoraAbertura.ToShortDateString() + "/" + HoraAbertura.ToShortTimeString()), lancar.textBoxObs.Text, lancar.textBoxValor.Text, "");
                            if (lancar.textBoxValor.Text != "")
                            {
                                labelSaldoAtual.Text = Convert.ToString(saldoAnterior + Convert.ToDecimal(lancar.textBoxValor.Text));
                            }
                        }
                    }

                }
            }

        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
    }
}
