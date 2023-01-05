using System;
using System.IO;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IsValidXML(); ;
        }


        private static void IsValidXML()
        {
            string filePath = "";

            try
            {
                var abc = Directory.EnumerateFiles(@"D:\Git\",
                    "*.resx", SearchOption.AllDirectories);

                foreach (string file in abc)
                {
                    filePath = file;
                    var contents = File.ReadAllText(file);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(contents);
                }

            }
            catch (Exception ex)
            {
                Console.Write("error");
                Console.WriteLine(filePath);
            }

            Console.ReadLine();

        }

    }
}
