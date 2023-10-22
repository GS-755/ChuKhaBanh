using System;

namespace TestCase
{
    public class Program
    {
        private static string Text { get; set; }

        public static string[] SplitString()
        {
            string[] strings = Text.Split();

            return strings;
        }
        public static string ConvertStyle1()
        {
            string finalString = "";
            string[] strings = SplitString();
            for (int k = 0; k < strings.Length; k++)
            {
                char[] chars = strings[k].ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }
                }
                finalString += new string(chars) + "\n";
            }

            return finalString;
        }
        public static string ShortenText()
        {
            string shortText = "";
            int len = Text.Length;
            Console.WriteLine($"\nOriginal text length: {Text.Length}\n");
            if (Text.Length > 10)
            {
                for (int i = 0; i < (int)(len / 2); i++)        
                    shortText += Text[i];
        
                shortText += "...";

                return shortText;
            }

            return Text;
        }
        public static void Main(string[] args)
        {
            try
            {
                // Input case
                Console.Write("Nhap text: ");
                Text = Console.ReadLine();
                string[] text = SplitString();

                // Process case
                string finalText = ConvertStyle1();
                string shortText = ShortenText();

                // Output case
                Console.WriteLine(finalText);
                Console.WriteLine($"Shorten text: {shortText}");
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("sKiLl IsSuE :)))");
                Console.WriteLine(ex.Message);
            }
            
            // Endline
            Console.WriteLine();
        }
    }
}
