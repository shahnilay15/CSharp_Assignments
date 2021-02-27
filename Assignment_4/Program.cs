using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the text for file A.txt: ");
            string text = System.Console.ReadLine();

            if (String.IsNullOrWhiteSpace(text))
            {
                System.Console.WriteLine("\nPlease write something in the text file.");
            }
            else
            {
                writetext(text);
                readtext();
            }
        }

        static async void readtext()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var file = Path.Combine(dir, "A.txt");
            string res;
            try
            {
                using (StreamReader reader = File.OpenText(file))
                {
                    res = await reader.ReadLineAsync();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(Environment.NewLine + ex.Message);
            }
        }
        static async void writetext(string text)
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var file = Path.Combine(dir, "B.txt");

            try
            {
                using (StreamWriter output = new StreamWriter(file, true))
                {
                    await output.WriteAsync(text);
                    System.Console.WriteLine("\nCopied to B.txt from A.txt successfully.");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(Environment.NewLine + ex.Message);
            }
        }
    }
}
