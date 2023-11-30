namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"D:\C Sharp\New folder\PolymorphismC\hightscore.txt", lines);
            
            //method 2
            //Console.WriteLine("Please give the file a name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please enter the text for the file");
            //string input = Console.ReadLine();

            //File.WriteAllText(@"D:\C Sharp\New folder\PolymorphismC\" + fileName + ".txt", input);

            //method 3
            using (StreamWriter file = new StreamWriter(@"D:\C Sharp\New folder\PolymorphismC\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"D:\C Sharp\New folder\PolymorphismC\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

                // Example 1 - reading Text
                //string text = System.IO.File.ReadAllText(@"D:\C Sharp\New folder\PolymorphismC\textFile.txt");

                //Console.WriteLine("Textfile contains following text: {0}", text);

                //string[] lines = System.IO.File.ReadAllLines(@"D:\C Sharp\New folder\PolymorphismC\textFile.txt");

                //Console.WriteLine("Contens of textfile.txt = ");
                //foreach (string line in lines) 
                //{
                //    Console.WriteLine("\t" + line);
                //}

                Console.ReadKey();
        }
    }
}





