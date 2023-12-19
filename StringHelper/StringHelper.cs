namespace StringHelper
{
    public class StringHelper
    {
        public string ReverseString(string str)
        {
            char[] NewString = str.ToCharArray();
            Array.Reverse(NewString);
            return new string(NewString);
        }

    }
}
