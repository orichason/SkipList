using System;

namespace SkipList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            SkipList<int> List = new SkipList<int>(random);

            List.Insert(5);
        }
    }
}
