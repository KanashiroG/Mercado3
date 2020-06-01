using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetos_Pessoais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int qtde;


        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("COD.PRODUTO", typeof(int));
            table.Columns.Add("DESCRIÇÂO", typeof(string));
            dataGridView1.DataSource = table;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtQuantidade.Text = "0";
            txtCodigo.Text = "00000000";
            txtClienteDinheiro.Text = "R$ 0,00";

            foreach (DataRow item in table.Rows)
            {
            
            }

            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
                //dataGridView1.Rows.Remove(item);
            //}
           
          
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int produto;


            if (txtQuantidade.Text == "0" + "" || txtCodigo.Text == "0" + "")
            {
                MessageBox.Show("Por favor preenchar os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {   

                produto = Convert.ToInt32(txtQuantidade.Text);
                qtde += produto;

                lblProdutoTotal.Text = $"PRODUTO TOTAL: {qtde}";
                
                
                if (txtCodigo.Text == "1234678")
                {
                    table.Rows.Add(txtCodigo.Text, "Trakinas");
                    dataGridView1.DataSource = table;

                }

                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }

        private void pbxFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o Aplicativo DIA", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
