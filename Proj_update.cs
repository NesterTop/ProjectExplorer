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

namespace WindowsFormsApp1
{
    public partial class Proj_update : Form
    {
        DataBase db = new DataBase();
        public Proj_update()
        {
            InitializeComponent();
        }

        private void Proj_update_Load(object sender, EventArgs e)
        {
            UpdateData();
        }


        private void UpdateData()
        {
            comboBox_old_name.Items.Clear();
            string querystring = "select name from projects;";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_old_name.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            string name_now = comboBox_old_name.SelectedItem.ToString();

            object querystr = $"select * from projects where name = '{name_now}';";
            SqlCommand comm = new SqlCommand((string)querystr, db.GetConnection());
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            object name = read.GetValue(1);
            object descr = read.GetValue(2);
            read.Close();

            object NewName = name;
            object NewDescr = descr;

            if (checkBox_new_name.Checked)
            {
                NewName = textBox_newname.Text;
            }
            if (checkBox_descr.Checked)
            {
                NewDescr = textBox_descr.Text;                                                                                                                             // Проверка чекбокса с Email
            }

            db.ExecuteSqlNonQuery($"update Projects set name = '{NewName}', description = '{NewDescr}' where name = '{name_now}';");

            MessageBox.Show("Вы изменили данные!", "Оповещение");
            UpdateData();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
