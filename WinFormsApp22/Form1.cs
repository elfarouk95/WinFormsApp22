using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp22.db;

namespace WinFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SchoolContext c = new SchoolContext();

            c.Database.EnsureCreated();

            dataGridView1.DataSource = c.studenst.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string name = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            float gpa = float.Parse(textBox4.Text);

            Student s = new Student();
            s.Name = name;
            s.Email = email;
            s.Age = age;
            s.Gpa = gpa;

            SchoolContext c = new SchoolContext();

            c.Database.EnsureCreated();

            c.studenst.Add(s);

            c.SaveChanges();


            dataGridView1.DataSource = c.studenst.ToList();
        }
    }
}
