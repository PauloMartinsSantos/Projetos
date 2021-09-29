using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualizadorProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeModeloDosCarros = Directory.GetFiles(@"C:\Users\paulo.santos-ext\source\repos\Projetos\VisualizadorProdutos\Imagens\Carros\");

            // foreach = para cada elemento faça algo....
            foreach (string img in nomeModeloDosCarros)
            {
                //array de separação do caminho da imagem
                string [] separador = img.Split('\\');
                string[] nomeSelecionado = separador[9].Split('.');
                
                
                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox1.ImageLocation = @"C:\Users\paulo.santos-ext\source\repos\Projetos\VisualizadorProdutos\Imagens\Carros\" + comboBox2.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
               
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if(comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ARGO");
                comboBox2.Items.Add("500E");
                comboBox2.Items.Add("CRONOS");

            }
            else if (comboBox1.Text == "VOLKSVAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("JETTA");
                comboBox2.Items.Add("TAOS");

            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("JOY");
                comboBox2.Items.Add("CAMARO");
                
            }
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("KA");
                comboBox2.Items.Add("EDGE");
                comboBox2.Items.Add("MAVERICK");
            }
            else if (comboBox1.Text == "RENAULT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SANDERO");
                comboBox2.Items.Add("LOGAN");
                comboBox2.Items.Add("CAPTUR");
            }
        }
    }
}
