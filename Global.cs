using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Learning_WPF
{
    public class Global
    {
        private static Global instance;
        private String name = "";
        private Semaphore sem;

        SqliteConnection conn;

        public string Name
        {
            get => name;
            set
            {
                sem.WaitOne();
                name = value;
                sem.Release();
            }
        }

        private Global()
        {
            this.sem = new Semaphore(0, 1);
            this.conn = new SqliteConnection("Data Source= C:/Users/zsv/source/repos/Learning-WPF/Registration.db");
            this.conn.Open();
        }

        public SqliteCommand getCmd()
        {
            return this.conn.CreateCommand();
        }
        public void addUser(String user)
        {
            conn.CreateCommand().CommandText = "insert into user values("+user+")";
            conn.CreateCommand().ExecuteNonQuery();
        }


        public static Global getInstance()
        {
            if (instance == null)
                instance = new Global();
            return instance;
        }
    }
}
