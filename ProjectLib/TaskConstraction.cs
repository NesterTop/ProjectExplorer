using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ProjectLib
{
    
    public class TaskConstraction
    {
        DataBase db = new DataBase();

        public bool AddTask(string name, string descr, string name_proj)
        {
            try
            {
                db.ConnectionOpen();
                db.ExecuteSqlNonQuery($"insert into tasks values((select id from projects where name = '{name_proj}'),'{name}', '{descr}', 0);");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
