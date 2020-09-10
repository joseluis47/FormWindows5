using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private List<string> arquivo()
        {
            string caminho = Environment.CurrentDirectory;
            string arquivo = @"\nomes.txt";
            string total = caminho + arquivo;
            List<string> lista = new List<string>();
            try
            { using (FileStream fs = new FileStream(total,FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] linha = sr.ReadLine().Split(',');
                            string nome = linha[0];
                            lista.Add(nome);
                        }
                    }
                }

            } catch (Exception e)
            {
                MessageBox.Show("Erro");
            }
            return lista;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var lista = arquivo();
            foreach ( var item in lista)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add("carro");
            lista.Add("onibus");
            lista.Add("bicileta");
            lista.Add("moto");

            foreach (string item in lista)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
