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
    public partial class Proj_del : Form
    {
        DataBase db = new DataBase();
        public Proj_del()
        {
            InitializeComponent();
        }

        private void Proj_del_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            DialogResult dr = MessageBox.Show("Вы уверены что хотите удалить данные об этом проекте?",
                      "Подтверждение", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    db.ExecuteSqlNonQuery($"delete from projects where name = '{name}';");
                    UpdateData();

                    break;
                case DialogResult.No:
                    break;
            }
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

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
