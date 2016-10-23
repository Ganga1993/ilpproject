using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;

namespace BO_CP
{
    //Login 
    public class BOLogin_Code : IBOLogin_Code
    {
        int username;
        string password;

        public int Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public BOLogin_Code(int username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public BOLogin_Code()
        {
        }
    }
}
