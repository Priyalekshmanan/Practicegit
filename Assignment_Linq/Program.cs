namespace Assignment_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 7,8};
            var result = from k in num
                         let j= k * k * k
                         where  j> 100 && j <1000
                           select j;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
