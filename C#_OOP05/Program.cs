using test;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D P1 = ReadPoint("P1");
            Point3D P2 = ReadPoint("P2");

            Console.WriteLine(P1);
            Console.WriteLine(P2);

            Console.WriteLine(P1 == P2 ? "P1 and P2 are Equal" : "P1 and P2 are NOT Equal");

            Point3D[] arr = {
            new Point3D(4, 5, 6),
            new Point3D(2, 3, 7),
            new Point3D(1, 9, 0),
            new Point3D(2, 2, 2)
        };

            Array.Sort(arr);
            Console.WriteLine("Sorted Array:");
            foreach (Point3D p in arr) Console.WriteLine(p);

            Point3D clone = (Point3D)P1.Clone();
            Console.WriteLine("Cloned Point: " + clone);
        }

        private static Point3D ReadPoint(string name)
        {
            int x = ReadInt($"Enter X for {name}: ");
            int y = ReadInt($"Enter Y for {name}: ");
            int z = ReadInt($"Enter Z for {name}: ");
            return new Point3D(x, y, z);
        }

        private static int ReadInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Try again: ");
            }
            return value;
        }
    }
}
