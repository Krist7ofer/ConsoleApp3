namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod 1-3");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Meetod1();
            }

            else if (choice == 2)
            {
                Meetod2();
            }

            else if (choice == 3)
            {
                Meetod3();
            }

            else
            {
                Console.WriteLine("Valisite vale juhtumi");
            }
        }
        static void Meetod1()
        {
            Console.WriteLine("Loo fail läbi konsooli");

            string filePath = @"C:/Users/opilane/Desktop/File.txt";

            File.Create(filePath);
        }
        static void Meetod2()
        {
            Console.WriteLine("Loo ja kirjuta faili sisu läbi konsooli");

            string filePath = @"C:/Users/opilane/Desktop/WriteToFile.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        static void Meetod3()
        {
            string path = Environment.CurrentDirectory;
            string file_name = "\\url_name";
            string full_path = path + file_name;

            if (File.Exists(full_path))
            {
                if (File.ReadAllText(full_path) == full_path)
                {
                    Console.WriteLine("File already has url inside");
                }
            }
            else
            {
                File.Create(full_path);

                Console.WriteLine("File doesn't exist, creating it now");
                File.WriteAllText(full_path, full_path);
            }
        }
    }
}