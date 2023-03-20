using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatveevWPFSessia1
{
    public partial class User
    {
        public string FIO
        {
            get
            {
                return UserSurname + " " + UserName + " " + UserPatronymic;
            }
        }

    }
}
