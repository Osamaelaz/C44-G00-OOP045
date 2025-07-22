namespace ThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine("D1:" + D1);

            D1 = new Duration(3600);
            Console.WriteLine("D1:" + D1);

            Duration O = new Duration(3600);
            Console.WriteLine("Equals(): " + O.Equals(D1));
            Console.WriteLine("D1.GetHashCode() :" + D1.GetHashCode());
            Console.WriteLine("O.GetHashCode() :" + O.GetHashCode());

            Duration D2 = new Duration(7800);
            Console.WriteLine("D2:" + D2);

            Duration D3 = new Duration(666);
            Console.WriteLine("D3:" + D3);

            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2 => " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800 => " + D3);

            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3 => " + D3);

            D3 = ++D1;
            Console.WriteLine("++D1 => " + D3);

            D3 = --D2;
            Console.WriteLine("--D2 => " + D3);

            D1 = D1 - D2;
            Console.WriteLine("D1 - D2 => " + D1);

            Console.WriteLine(D1 > D2 ? "D1 > D2" : "D1 <= D2");
            DateTime dt = (DateTime)D3;
            Console.WriteLine("Cast to DateTime => " + dt);
        }
    }
}
