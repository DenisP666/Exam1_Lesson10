

namespace StringKeeper
{
    public class UpperCase:StringKeeper
    {
        string Str1;
        string Str2;
        
        public override string OutString(string Str1, string Str2)
        {

            
            string ResultString1 = Str1.ToUpper();
            string ResultString2 = Str2.ToUpper();
            string SumResultString = ResultString1 + ResultString2;
            Console.WriteLine(SumResultString);
            return SumResultString;

            
        }
    }
}
