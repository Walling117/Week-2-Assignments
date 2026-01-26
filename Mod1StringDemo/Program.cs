using System.Text;

namespace Mod1StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings are a sequence of characters enclosed in double qoutes
            //they are immutable, when we are using + operator
            // it creates a new string object in the memory
            string s = string.Empty;

            // this is better because this allocated on the heap 
            // it does not create multiple strings. It is mutable
            StringBuilder address = new StringBuilder();
            address.Append("123 Main st");
            address.Append(",");
            address.Append("Springfield");
            Console.WriteLine(address);


            string s1 = "  amazing ";
            Console.WriteLine($"Length of s1: {s1.Length}");
            Console.WriteLine($"Trimming s1: {s1.Trim().Length}");
            Console.WriteLine(s1.Length);

            //1.
            string header = "* A Short Play. *";
            var newHeader = header.Trim(new char[] {' ', '*','.'}); // passing an array of things to remove
            Console.WriteLine(newHeader);
            //2.
            var newHeader2 = header.Trim(' ', '*', '.');
            Console.WriteLine(newHeader2);
            // Replace
            var st = header.Replace(' ', '-');
            Console.WriteLine(st);
            // Converting char to string
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            string voewlString = new string(vowel);
            foreach( char c in voewlString)
            {
                Console.WriteLine(c); 
            }

            string s2 = "Wake up early in the morning.";
            string[] words = s2.Split(new char[] { ' ', ',', '.' });
            
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            // Substring
            var sub = s2.Substring(0, 5);
            Console.WriteLine(sub);
            // IndexOf
            Console.WriteLine(s2.IndexOf("early")); // Prints starting index of early
            Console.WriteLine(s2.Replace("early","late"));

            int[] nums = { 2, 3, 4, 5, 6, 7 };

            string numsarray=String.Concat(nums);
        }
    }
}
