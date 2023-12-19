namespace StringHelper
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            StringHelper stringHelper = new StringHelper();

            Console.WriteLine("enter your string");

            string str = Console.ReadLine();

            stringHelper.ReverseString(str);
            Console.WriteLine(stringHelper.ReverseString(str));
            Console.ReadLine();

        }
    }
}
