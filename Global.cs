using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_WPF
{
    public class Global
    {
        private static Global instance;
        private String name = "";
        private Semaphore sem;
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

        }

        public static Global getInstance()
        {
            if (instance == null)
                instance = new Global();
            return instance;
        }
    }
}
