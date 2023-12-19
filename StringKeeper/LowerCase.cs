
namespace StringKeeper
{
    public class LowerCase:StringKeeper
    {
        public override string OutString(string Str1, string Str2)
        {


            string ResultString1 = Str1.ToLower();
            string ResultString2 = Str2.ToLower();
            string SumResultString = ResultString1 + ResultString2;

            
            Console.WriteLine(SumResultString);
            return SumResultString;



        }
    }
}
