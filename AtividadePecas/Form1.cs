using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AtividadePecas
{
    public partial class Form1 : Form
    {
        List<Carro> carros;
        public Form1()
        {
            InitializeComponent();
            this.carros = new List<Carro>();
        }

        private void btCarroAdicionar_Click(object sender, EventArgs e)
        {
            if(tbCarroNome.Text.Length > 0 &&
                tbCarroMarca.Text.Length > 0 &&
                ndAno.Value > 0)
            {
                string nome = tbCarroNome.Text;
                string marca = tbCarroMarca.Text;
                int ano = (int)ndAno.Value;
                Carro carro = new Carro(marca, nome, ano);
                this.carros.Add(carro);
                AtualizarCarros();
                tbCarroMarca.Text = "";
                tbCarroNome.Text = "";
                ndAno.Value = ndAno.Maximum;
                MessageBox.Show($"Carro {carro.marca} {carro.nome} {carro.ano} cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void AtualizarCarros()
        {
            cbCarro.Items.Clear();
            foreach(Carro c in this.carros)
            {
                /*
                cbCarro.DisplayMember = "Texto";
                cbCarro.ValueMember = "ObjCarro";
                cbCarro.Items.Add(
                    new { Texto = $"{c.marca} {c.nome} {c.ano.ToString()}",
                    ObjCarro = c}
                    );
                */
                cbCarro.Items.Add($"{c.marca} {c.nome} {c.ano.ToString()}");
            }
        }

        private void btPecaAdicionar_Click(object sender, EventArgs e)
        {
            if (tbPecaMarca.Text.Length > 0 &&
                tbPecaNome.Text.Length > 0 &&
                tbPecaModelo.Text.Length > 0)
            {
                //Carro c = (Carro)cbCarro.SelectedItem.GetType().GetProperty("ObjCarro").GetValue(cbCarro.SelectedItem, null);
                Carro c = this.carros[cbCarro.SelectedIndex];
                Peca p = new Peca(tbPecaMarca.Text,
                    tbPecaNome.Text, tbPecaModelo.Text,
                    ndPecaValor.Value);
                c.pecas.Add(p);
                tbPecaMarca.Text = "";
                tbPecaNome.Text = "";
                tbPecaModelo.Text = "";
                ndPecaValor.Value = 0;
                MessageBox.Show("Peça cadastrada com sucesso!");
                AtualizarPecas(c);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos necessários para cadastrar a peça!");
            }
        }

        private void AtualizarPecas(Carro c)
        {
            lbPeca.Text = $"Peças do carro {c.marca} {c.nome} {c.ano}:";
            lvPecas.Items.Clear();

            foreach (Peca p in c.pecas) {
                ListViewItem item = new ListViewItem(p.marca);
                item.SubItems.Add(p.nome);
                item.SubItems.Add(p.modelo);
                item.SubItems.Add(p.valor.ToString());
                lvPecas.Items.Add(item);
            }
        }

        private void cbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Carro c = (Carro)cbCarro.SelectedItem.
                GetType().
                GetProperty("ObjCarro").
                GetValue(cbCarro.SelectedItem, null);*/
            Carro c = this.carros[cbCarro.SelectedIndex];
            AtualizarPecas(c);
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (lvPecas.Items.Count > 0)
            {
                /*Carro c = (Carro)cbCarro.SelectedItem.
                GetType().
                GetProperty("ObjCarro").
                GetValue(cbCarro.SelectedItem, null);
                */
                Carro c = this.carros[cbCarro.SelectedIndex];
                int indice = lvPecas.SelectedIndices[0];
                c.pecas.RemoveAt(indice);

                AtualizarPecas(c);
            }
            else
            {
                MessageBox.Show("Não há peça para deletar.");
            }
        }

        private void lvPecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPecas.SelectedItems.Count > 0)
            {
                btDeletar.Enabled = true;
            }
            else
            {
                btDeletar.Enabled = false;
            }
        }
    }
}
