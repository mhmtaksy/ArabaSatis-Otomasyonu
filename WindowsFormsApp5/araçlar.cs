using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class araçlar : Form
    {
        public araçlar()
        {
            InitializeComponent();
        }

        rentacarEntities con = new rentacarEntities();

        private void araçlar_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["carID"].Value.ToString();
            textBox1.Text = column.Cells["carBalance"].Value.ToString();
            textBox2.Text = column.Cells["carNumber"].Value.ToString();
            textBox4.Text = column.Cells["carModel"].Value.ToString();
            textBox3.Text = column.Cells["carYear"].Value.ToString();
            textBox6.Text = column.Cells["carEngine"].Value.ToString();
            textBox5.Text = column.Cells["carPacket"].Value.ToString();
            textBox8.Text = column.Cells["carColour"].Value.ToString();
            textBox7.Text = column.Cells["carGear"].Value.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın Almaya Yönlendiriliyorsunuz");
            Sipariş go = new Sipariş();
            go.Show();
            this.Hide();
        }
    }
}
