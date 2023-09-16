using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class yöneticiaraç : Form
    {
        public yöneticiaraç()
        {
            InitializeComponent();
        }

        private void yöneticiaraç_Load(object sender, EventArgs e)
        {

        }
       
        rentacarEntities con = new rentacarEntities();

        private void araçlar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            Car car = new Car();           
            car.carBalance = Convert.ToInt32(textBox1.Text);
            car.carNumber = Convert.ToInt32(textBox2.Text);
            car.carModel = textBox4.Text;
            car.carYear = Convert.ToInt32(textBox3.Text);
            car.carEngine = Convert.ToInt32(textBox6.Text);
            car.carPacket = textBox5.Text;
            car.carColour = textBox8.Text;
            car.carGear =  textBox7.Text;
            con.Cars.Add(car);
            con.SaveChanges();
            dataGridView1.DataSource = con.Cars.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = con.Cars.Where(x=>x.carID ==ID).FirstOrDefault();
            update.carBalance = Convert.ToInt32(textBox1.Text);
            update.carNumber = Convert.ToInt32(textBox2.Text);
            update.carModel = textBox4.Text;
            update.carYear = Convert.ToInt32(textBox3.Text);
            update.carEngine = Convert.ToInt32(textBox6.Text);
            update.carPacket = textBox5.Text;
            update.carColour = textBox8.Text;
            update.carGear = textBox7.Text;            
            con.SaveChanges();
            dataGridView1.DataSource = con.Cars.ToList();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            var deleteCar = con.Cars.Where(x => x.carID == id).FirstOrDefault();
            con.Cars.Remove(deleteCar);
            dataGridView1 .DataSource = con.Cars.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.Cars.Where(a => a.carModel.Contains(textBox4.Text)).FirstOrDefault();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            araçlar go = new araçlar();
            go.Show();
            this.Hide();
        }
    }
}