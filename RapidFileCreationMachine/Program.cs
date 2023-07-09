namespace RapidFileCreationMachine
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Receives name for files.
            WriteLine("What should I call the files?");
            string fileName = ReadLine();
            WriteLine("Okay! I'll call the files " + fileName);

            //Receives file path.
            WriteLine("Next, where would you like me to create the files? Enter the whole file path.");
            string filePath = ReadLine();


            //Creates as many files as the PC will allow in the specified directory.
            for (int i = 0; ; i++)
            {
                string fileNameFinal = Path.Combine(filePath, fileName + i + ".txt");
                File.Create(fileNameFinal).Close();
            }
    }
}