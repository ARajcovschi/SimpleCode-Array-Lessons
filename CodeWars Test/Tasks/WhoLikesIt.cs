using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Test.Tasks
{

    class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
                return "no one likes this";

            if (name.Length == 1)
                return $"{name[0]} likes this";

            if (name.Length == 2)
                return $"{name[0]} and {name[1]} like this";

            if (name.Length == 3)
                return $"{name[0]}, {name[1]} and {name[2]} like this";

            if (name.Length >= 4)
                return $"{name[0]}, {name[1]} and" + " " + (name.Length - 2) + " others like this";
            return ""; //fucking fuck When the compiler looks at your code, it's sees a third path
                       //(the else you didn't code for) that could occur but doesn't return a value.
                       //Hence not all code paths return a value.
        }
    }
}
