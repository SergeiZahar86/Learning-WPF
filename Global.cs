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

        //SqliteConnection conn;

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
           this.sem = new Semaphore(1, 1);
           //this.conn = new SqliteConnection("Data Source=hello.db");
           //this.conn.Open();
        }
        /*
        public SqliteCommand getCmd()
        {
            return this.conn.CreateCommand();
        }
        */


        public static Global getInstance()
        {
            if (instance == null)
                instance = new Global();
            return instance;
        }
    }
}
