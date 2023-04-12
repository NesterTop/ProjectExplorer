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
    public partial class Proj_add : Form
    {
        DataBase db = new DataBase();
        public Proj_add()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            db.ConnectionOpen();
            string name = textBox_name.Text;
            string descr = textBox_description.Text;

            db.ExecuteSqlNonQuery($"insert into projects values('{name}', '{descr}');");
            MessageBox.Show("Вы добавили новый проект!", "Оповещение");
        }

        private void Proj_add_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
