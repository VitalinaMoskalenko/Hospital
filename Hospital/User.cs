using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public static class User
    {
        public static int userId;
        public static string fName;
        public static string lName;
        public static int posId;
        public static int siudId;
        public static string posName;
        public static List<string> ServicesList = new List<string>();
        public static List<int> ServicesSiudList = new List<int>();

        public static string UserName()
        {
            return fName + " " + lName;
        }

        public static string UserDescription()
        {
            return fName + " " + lName + ", Position: " + posName;
        }
    }
}
