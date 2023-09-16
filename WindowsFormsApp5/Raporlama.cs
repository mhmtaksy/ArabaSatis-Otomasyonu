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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        rentacarEntities con = new rentacarEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(i => i.carYear > 2021).ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(i => i.carBalance > 700000).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Customerrs.Where(i => i.customerAge > 20).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Customerrs.Where(i => i.customerDownPayment > 20000).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Branches.Where(i => i.branchGiro> 400000).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(i => i.carColour == "Beyaz").ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(i => i.carPacket == "Full").ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(i => i.carGear == "Otomatik").ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Branches.Where(i => i.branchName == "Merter").ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Branches.Where(i => i.branchName == "Şişli").ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Branches.Where(i => i.branchName == "Kartal").ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Branches.Where(i => i.branchName == "Pendik").ToList();
        }
    }
}
