using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Sipariş : Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }

        rentacarEntities con = new rentacarEntities();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Text = column.Cells["carID"].Value.ToString();
            textBox2.Text = column.Cells["carBalance"].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın alma işlemi başarılı ödeme sayfasına yönlendiriliyorsunuz");
        }
    }
}
