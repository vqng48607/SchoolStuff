namespace streamReaderTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader st = new StreamReader("test.txt");
            try
            {
                string readLineSt = st.ReadLine();
                Console.WriteLine(readLineSt);
            }

            finally
            {
                st.Close();
            }

            Console.ReadLine();
        }

    }
}