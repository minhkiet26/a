using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Utils
    {
        public static String GetString(String Msg)
        {
            Console.WriteLine(Msg);
            string s = " ";
            try
            {
                s = Console.ReadLine();
                if(s == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine (e);
            }
            return s;
        }
        public static int GetInteger(String Msg)
        {
            Console.WriteLine(Msg);
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine (e);
            }
            return i;
}
        public static bool Confirm(String Msg)
        { 
            String str = Console.ReadLine().ToUpper();
            char c = str[0];
            if(c == 'Y')
            {
                return true;
            }
            return false;
        }
    }
}
