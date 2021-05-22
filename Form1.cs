using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("First Name", typeof(String));
            dataTable.Columns.Add("Last Name", typeof(String));
            dataTable.Columns.Add("Name", typeof(String));

            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(textBox4.Text, textBox1.Text, textBox2.Text, textBox3);
            dataGridView1.DataSource = dataTable;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
