namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Define 3D Point Class and the basic Constructors (use chaining in constructors).

            //    Point3D P = new Point3D(10, 10, 10);
            //    Console.WriteLine(P.ToString());

            //    // Read two points from user
            //    Point3D P1 = ReadPoint("P1");
            //    Point3D P2 = ReadPoint("P2");

            //    // Equality check
            //    if (P1 == P2)
            //        Console.WriteLine("Points are equal.");
            //    else
            //        Console.WriteLine("Points are NOT equal.");

            //    // Create array of points
            //    Point3D[] points = new Point3D[]
            //    {
            //    new Point3D(1, 5, 3),
            //    new Point3D(2, 3, 1),
            //    new Point3D(1, 3, 2),
            //    new Point3D(3, 1, 1)
            //    };

            //    // Sort
            //    Array.Sort(points);
            //    Console.WriteLine("\nSorted Points:");
            //    foreach (var point in points)
            //        Console.WriteLine(point);

            //    // Clone
            //    Point3D clone = (Point3D)P1.Clone();
            //    Console.WriteLine($"\nCloned P1: {clone}");
            //}

            //static Point3D ReadPoint(string name)
            //{
            //    int x = ReadInt($"{name}.X: ");
            //    int y = ReadInt($"{name}.Y: ");
            //    int z = Convert.ToInt32(ReadInput($"{name}.Z: "));
            //    return new Point3D(x, y, z);
            //}

            //static int ReadInt(string message)
            //{
            //    int val;
            //    string input;
            //    do
            //    {
            //        Console.Write(message);
            //        input = Console.ReadLine();
            //    } while (!int.TryParse(input, out val));
            //    return val;
            //}

            //static string ReadInput(string message)
            //{
            //    Console.Write(message);
            //    return Console.ReadLine();
            #endregion

            #region Second Project
            //double x = 10, y = 5;

            //Console.WriteLine("Addition: " + Maths.Add(x, y));
            //Console.WriteLine("Subtraction: " + Maths.Subtract(x, y));
            //Console.WriteLine("Multiplication: " + Maths.Multiply(x, y));

            //try
            //{
            //    Console.WriteLine("Division: " + Maths.Divide(x, y));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            #endregion


            #region Third Project:
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1); // Hours: 1, Minutes :10, Seconds :15

            D1 = new Duration(3600);
            Console.WriteLine(D1); // Hours: 1, Minutes :0, Seconds :0

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2); // Hours: 2, Minutes :10, Seconds :0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3); // Minutes :11, Seconds :6

            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2: " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800: " + D3);

            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3: " + D3);

            D3 = ++D1;
            Console.WriteLine("D3 = ++D1: " + D3);

            D3 = --D2;
            Console.WriteLine("D3 = --D2: " + D3);

            D1 = D1 - D2;
            Console.WriteLine("D1 = D1 - D2: " + D1);

            if (D1 > D2) Console.WriteLine("D1 > D2");
            if (D1 <= D2) Console.WriteLine("D1 <= D2");

            if (D1) Console.WriteLine("D1 is true (not zero)");
            else Console.WriteLine("D1 is false (zero)");

            DateTime dt = (DateTime)D1;
            Console.WriteLine("D1 as DateTime: " + dt.ToLongTimeString());
            #endregion
        }
    }
}
