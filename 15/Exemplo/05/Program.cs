using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 15.Exemplo.05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";
            
            Console.WriteLine(cookies["phone"] );
            Console.WriteLine(cookies["email"] );
            
            cookies.Remove("email");
            if (cokkies.ContainsKey("email") ){
                Console.WriteLine(cookies["email"] );
            }
            else
            {
                Console.WriteLine("There is no 'email'  key.");
            }
            
            Console.WriteLine("Size:" + cookies.Count);

            Console.WriteLine("All cookies: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}