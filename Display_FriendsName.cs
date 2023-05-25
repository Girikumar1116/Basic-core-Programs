using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Display_FriendsName
    {
        public Display_FriendsName() { DisplayFriend_Names(); }
        public static void DisplayFriend_Names()
        {
            ArrayList list = new ArrayList() { "Revi", "bobby", "jilani", "Masthan", "Build up babai" };
            foreach (var s in list)
            {
                Console.Write(s + " ");
            }
        }

    }
}
