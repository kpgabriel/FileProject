namespace FileProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string directory = $"{args[0]}";
            string[] files= Directory.GetFiles(directory);
            //Loop through your files
            foreach(File file in files)
            {
                Console.WriteLine(file);
            }

        }
    }
}
