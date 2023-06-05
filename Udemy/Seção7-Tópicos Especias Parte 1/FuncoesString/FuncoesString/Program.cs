namespace FuncoesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = " acbd ABCD acb ABC ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); //retira os espaço depois da string

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3); //corta a string
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("ToUpper: - " + s1 + "-");
            Console.WriteLine("ToLower: - " + s2 + "-");
            Console.WriteLine("Trim: - " + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf: " + s2);
            Console.WriteLine("Substring(3): - " + s4 + "-");
            Console.WriteLine("Substring(3, 5): - " + s5 + "-");
            Console.WriteLine("Replace('x', 'y'): - " + s6 + "-");
            Console.WriteLine("IsNullOrEmpty: - " + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: - " + b2 + "-");
        }
    }
}