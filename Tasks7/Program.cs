

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
    //7.5.5.
    class Obj
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static int MaxValue;
        public static string Parent;
        public static int DaysInWeek;

        static Obj()
        {
            MaxValue = 2000;
            Parent = "System.Object";
            DaysInWeek = 7;
        }
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

    static class intExtensions
    {
        public static int GetNegative(this int variable)
        {
            return variable = variable < 0 ? variable : - variable;
        }
        public static int GetPositive(this int variable)
        {
            return variable > 0 ? variable : - variable;
        }
    }

    class Car<T>
    { 
    T Engine;
    }

    class ElectricEngine
    {
    
    }
    class GasEngine
    {
    
    }

    class Record <Id, Value>
    {
        public DateTime = Date;
        
        Id nomer = default(Id);
        Value znachenie = default(Value);

    }
}
