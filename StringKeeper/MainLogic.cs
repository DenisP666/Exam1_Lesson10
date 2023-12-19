

namespace StringKeeper
{
   public class MainLogic
    {


       static void Main(string[] args)
        {
            StringKeeper stringKeeper = new StringKeeper();
            UpperCase upperCase = new UpperCase();
            LowerCase lowerCase = new LowerCase();
            string Str1 = "hELlo";
            string Str2 = "wOrLd";
            upperCase.OutString(Str1,Str2);
            lowerCase.OutString(Str1, Str2); 
            Console.ReadLine();


        }
    }
}
