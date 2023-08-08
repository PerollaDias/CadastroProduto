using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        List<Produto> produto = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                Produto produto1 = new Produto();

            try
            {
                produto1.codigo = textBox1.Text;
                produto1.descricao = textBox2.Text;
                produto1.lucro = Convert.ToDouble(textBox4.Text);
                produto1.precoaqs = Convert.ToDouble(textBox3.Text);
                produto1.valorvenda = produto1.precoaqs + (produto1.precoaqs * produto1.lucro / 100);

                textBox5.Text = produto1.valorvenda.ToString();


                produto.Add(produto1);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produto;
            }

            
            catch (FormatException ex)
            {
                MessageBox.Show($"Não é permitido escrever letras! ");
            }

            catch (Exception ex)
            {
               MessageBox.Show($"Ocorreu um erro! ");
            }
            

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produto.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

                
        }
    }
}
