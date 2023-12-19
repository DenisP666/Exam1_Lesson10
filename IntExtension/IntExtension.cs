namespace IntExtension
{
    internal class IntExtension
    {
        static void Main(string[] args)
        {
            Extens extens = new Extens();
            Console.WriteLine("enter your INT Value");
            int Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(extens.ExtensInt(Value));
            Console.ReadLine();
        }
    }
}
