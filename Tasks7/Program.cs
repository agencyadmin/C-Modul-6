

class Programm
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Вызван метод класса A");
        }
    }
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Вызван метод класса B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Вызван метод класса C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса D");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса E");
        }
    }
    public static void Main(string[] arg)
    {
        D d = new D();
        E e = new E();

        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }

    class Obj
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static int MaxValue = 2000;
    }

    //Задание 7.5.3

    class Helper

    {
        public static int num1;
        public static int num2;
        public static void Swap(out int A; out int B;)
            {
            int C = A;
            num1 = B;
            num2 = C;
            }
}
