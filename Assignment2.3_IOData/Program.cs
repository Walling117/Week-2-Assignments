namespace Assignment2._3_IOData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = path + @"\PersonalData.txt";


            StreamWriter streamWriter = null;

            Person person = new Person();

            Console.Write("What is your name: ");
            person.Name = Console.ReadLine();
            Console.Write("\nAge: ");
            person.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAddress: ");
            person.Address = Console.ReadLine();


            try
            {
                if (!File.Exists(filePath))
                {
                    streamWriter = File.CreateText(filePath);
                    streamWriter.WriteLine(person.ToString().ToString());
                    Console.WriteLine("File created and written to");
                }
                else
                {
                    File.AppendAllText(filePath, person.ToString().ToString());
                    Console.WriteLine("File already exists...Appended to file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { if(streamWriter != null) streamWriter.Close(); } // Can not access file from machine if you forget to close this


            //----------------------------------Read File-----------------------------------------------
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string contentRead = streamReader.ReadToEnd();
                Console.WriteLine($"This was pulled using the 'using' block\n{contentRead}");
            }

            Console.WriteLine("\n\nThis was pulled using a while loop without the 'using' block");
            StreamReader streamReader2 = new StreamReader(filePath);

            string line;
            while((line = streamReader2.ReadLine()) != null)
                Console.WriteLine(line);
            streamReader2.Close();

        }
    }
}
