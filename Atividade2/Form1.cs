using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Media : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=OSA0625259W10-1;Initial Catalog=Media_alunos;Integrated Security=True"); //  > CON variavel para conexão
        SqlCommand comando = new SqlCommand(); // Comando > Variavel para comando 
        SqlDataReader dr;  // Consultar os dados 


        public Media()
        {

            InitializeComponent();
        }

        private void Media_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;  // Conectando o formulario com o banco de dados 
            CarregarMedias();
        }


        private void CarregarMedias()
        {

            conn.Open(); //Executar abertura do banco de dados  
            comando.CommandText = "select* from Media "; // comando para executar as informações de MEDIAS 
            dr = comando.ExecuteReader(); // Irá executar a variavel comando

            if (dr.HasRows) // se estiver linha 
            {

                while (dr.Read()) // Lopping // percorrer 

                {
                    listBox1.Items.Add(dr[0].ToString()); // Se inicia em zero listbox 
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                    listBox4.Items.Add(dr[3].ToString());
                    listBox5.Items.Add(dr[4].ToString());
                    listBox6.Items.Add(dr[5].ToString());
                    listBox7.Items.Add(dr[6].ToString());
                    listBox8.Items.Add(dr[7].ToString());
                    listBox9.Items.Add(dr[8].ToString());
                }



            }
            conn.Close(); // fechar banco de dados 

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox; // l Variavel 
            if (ler.SelectedIndex != -1) //irá setar a linha toda selecionada 

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ler = sender as ListBox;
            if (ler.SelectedIndex != -1)

            {
                listBox1.SelectedIndex = ler.SelectedIndex;
                listBox2.SelectedIndex = ler.SelectedIndex;
                listBox3.SelectedIndex = ler.SelectedIndex;
                listBox4.SelectedIndex = ler.SelectedIndex;
                listBox5.SelectedIndex = ler.SelectedIndex;
                listBox6.SelectedIndex = ler.SelectedIndex;
                listBox7.SelectedIndex = ler.SelectedIndex;
                listBox8.SelectedIndex = ler.SelectedIndex;
                listBox9.SelectedIndex = ler.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Calcular") 
                
                try
                {
                    int media = int.Parse(txtNumero.Text);
                    listBox1.Items.Add(media);
                    txtNumero.Text = " ";
                }

                catch
                {
                    MessageBox.Show(txtNumero.ToString());
                }
            
            // MessageBox.Show(listBox1.SelectedItem.ToString());
            // Media media = new Media();
            // media = (listBox2 + listBox3 + listBox4 + listBox5 + listBox6 + listBox7 + listBox8 +listBox9);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
        }
    }
}
