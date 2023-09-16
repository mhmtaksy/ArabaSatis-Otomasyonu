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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        rentacarEntities con = new rentacarEntities();

        
        private void button1_Click(object sender, EventArgs e)
        {

            Customerr customerr = new Customerr();
            customerr.customerNameSurname = textBox1.Text;
            customerr.customerPhone = textBox2.Text;
            customerr.customerAge = Convert.ToInt32(textBox3.Text);
            customerr.customerBalance = Convert.ToInt32(textBox4.Text);
            customerr.customerDownPayment = Convert.ToInt32(textBox5.Text);
            con.Customerrs.Add(customerr);
            con.SaveChanges();
            araçlar go = new araçlar();
            go.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        public bool LoginUser(string usernamesurname, string phone)
        {
            var query = from user in con.Employees where user.employeeNameSurname == usernamesurname && user.employeePhone == phone select user;


            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginUser(textBox10.Text, textBox9.Text))
            {
                yöneticiaraç go = new yöneticiaraç();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
