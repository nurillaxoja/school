using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.dbModules
{
    class UsersModule
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public DateTime dateOfBrith { get; set; }
        public string gender { get; set; }
        public string photo { get; set; }
    }
}
