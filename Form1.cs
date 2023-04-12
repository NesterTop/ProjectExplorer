using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.ConnectionOpen();
            UpdateData();
        }

        private void button_show_all_proj_Click(object sender, EventArgs e)
        {
            DataTable projects = db.ExecuteSql($"select Name as Название_Проекта, Description as Описание_Проекта from projects;");

            dataGridView1.DataSource = projects;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object proj = comboBox1.SelectedItem;

            DataTable projects = db.ExecuteSql($"select projects.Name as Название_Проекта, tasks.name as Название_задачи, tasks.description as Описание_задачи, tasks.checked as Готовность_задачи from projects, tasks where (select id from projects where name = '{proj}') = tasks.id_project and projects.name = '{proj}';");

            dataGridView1.DataSource = projects;
        }

        private void button_add_proj_Click(object sender, EventArgs e)
        {
            Proj_add proj_Add = new Proj_add();
            proj_Add.Show();
        }

        private void UpdateData()
        {
            comboBox1.Items.Clear();
            string querystring = "select name from projects;";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button_add_tasks_Click(object sender, EventArgs e)
        {
            Task_add task_Add = new Task_add();
            task_Add.Show();
        }

        private void button_del_proj_Click(object sender, EventArgs e)
        {
            Proj_del proj_Del = new Proj_del();
            proj_Del.Show();
        }

        private void button_update_proj_Click(object sender, EventArgs e)
        {
            Proj_update proj_Update = new Proj_update();
            proj_Update.Show();
        }
    }
}
