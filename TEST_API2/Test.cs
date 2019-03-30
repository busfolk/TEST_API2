
using TEST_API22;

namespace TEST_API2
{
    public class Test
    {
        public Test()
        {
            s = 9;

            

            
        }
        public readonly int s;
        public const int x = 9;

        public static int foo;
    }

   

    public abstract class Dog
    {
        //public Dog()
        //{
        //    //Test testy = new Test();
            
        //}

        public  string Breed { get; set; }
        public  int PawCount { get; set; }

        public abstract string Foo();

        //public static int TeethCount { get; set; }

        //delegate int delq(int i);
        //delq dd = new delq(x => x+9);

        //private poo[] arr = new poo[100];

        //public poo this[int i]
        //{
        //    get { return arr[i]; }
        //    set { arr[i] = value; }
        //}
    }
}
