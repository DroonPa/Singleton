using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySingletonLibrary
{
    public sealed class DbManager
    {
        private static readonly DbManager instance = new DbManager();

        public static DbManager Instance => instance;

        private DbManager() { }

        public string GetConnectionStatus()
        {
            return "Connected to DB!";
        }
    }
}
