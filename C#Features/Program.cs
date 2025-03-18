namespace C_Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What's new in C#7
            #region Inline out Variables
            //Console.WriteLine("How Old Are you?");

            //int.TryParse(Console.ReadLine(),out int result);

            //Console.WriteLine($"My Age is: {result}");
            #endregion
            #region Tuples

            //  var tuple = (id: 1, name: "abdelrhamn", FollowFootball: false);
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);
            //Console.WriteLine(tuple.Item3);

            //var a = getMinMax(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0, 10 });

            //Console.WriteLine(a.);
            //Console.WriteLine(a.Item2);
            #endregion
            #region Patren Matching

            #region is keyword
            //int x = 10;
            //if (x is int newx when newx > 5)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(newx);

            #endregion

            #region When keyword
            //object i = -10;

            //switch (i)
            //{
            //    case int z when z > 0:
            //        Console.WriteLine("Interger And positive");
            //        break;

            //    case int z when z < 1:
            //        Console.WriteLine("Interger And negative");
            //        break;
            //    case int z:
            //        Console.WriteLine("Interger");
            //        break;


            //}


            #endregion

            #endregion

            #endregion
            #region What is new in c#8


           


            #endregion
            #region Raw string Literal “””

            var text = """
                Hello,
                I'm abdelrhman,
                    Bye
                """;
            Console.WriteLine(text);


            string path = """C:\Users\John\Documents""";

            #endregion
        }

        private static (int min, int max) getMinMax(int[] array)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }

                if (item < min)
                {
                    min = item;
                }
            }

            return (min, max);
        }

    }
    //public class Circle
    //{

    //    public int H { get; set; }
    //    public int W { get; set; }

    //    public static int getArea()
    //    {
    //        return H * W;
    //    }
    //}
}
