using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ProjectLib
{
    public class ProjectConstraction
    {
        DataBase db = new DataBase();
        public bool AddProject(string name, string descr)
        {
            try
            {
                db.ConnectionOpen();
                db.ExecuteSqlNonQuery($"insert into projects values('{name}', '{descr}');");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProject(string name)
        {
            try
            {
                db.ExecuteSqlNonQuery($"delete from projects where name = '{name}';");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
