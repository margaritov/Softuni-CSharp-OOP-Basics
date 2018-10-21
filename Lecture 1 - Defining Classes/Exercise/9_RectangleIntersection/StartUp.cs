namespace _9_RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Rectangle> list = new List<Rectangle>();
            int[] cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rectangleCount = cmdArgs[0];
            int compareCount = cmdArgs[1];

            while (rectangleCount-- > 0)
            {
                string[] data = Console.ReadLine().Split();
                list.Add(new Rectangle(data[0], double.Parse(data[1]), double.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4])));
            }

            while (compareCount-- > 0)
            {
                string[] rectangles = Console.ReadLine().Split().ToArray();
                bool areIntersected = list.Where(r => r.Id == rectangles[0]).FirstOrDefault().AreIntersected(list.Where(r => r.Id == rectangles[1]).FirstOrDefault());
                Console.WriteLine(areIntersected.ToString().ToLower());
            }
            ;
        }
    }
}
