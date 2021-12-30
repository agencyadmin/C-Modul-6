

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
}
