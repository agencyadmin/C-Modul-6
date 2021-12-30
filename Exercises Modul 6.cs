class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

class ProjectManager : Employee
{
    public string ProgectName;

}

class Developer : Employee
{
    public string ProgrammingLanguage;

}


class Food
{
    public protected int TerminOfUse;
}

class Fruits : Food
{
    public string Name;
    public string Sort;
    public string Harvest;
    public int Price;
}

class Apple : Fruits
{
    public string Color;

}

class Banana : Fruits
{
    public string Import;

}

class Pear : Fruits
{
    public string Region;

}

class Vegetable : Food
{
    public string Name;
    public string Sort;
    public string Harvest;
    public int Price;
}

class Potato : Vegetable
{
    public string Contry;

}

class Carrot : Vegetable
{
    public string MadeIn;

}

class Obj
{
    private string name;
    private string owner;
    private int length;
    private int count;

    public Obj(string name, string ownerName, int objLength, int count)
    {
        Obj()
            {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }

    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        CerivedClass(string name, string description) : base(name)
        {
                     protected string Description = description;
    }

    CerivedClass(string name, string description, int counter) : this CerivedClass(name, description)
    {
                 protected string Counter = counter;
}
    }

class A
{
    public virtual void Display()
    {
        Console.WriteLine("������ ����� ������ A");
    }
}
class B : A
{
    public override void Display()
    {
        Console.WriteLine("������ ����� ������ B");
    }
}
class C : A
{
    public new void Display()
    {
        Console.WriteLine("������ ����� ������ C");
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("������ ����� ������ D");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("������ ����� ������ E");
        }
    }
}

public static void Main()
{
    A a = new A();
    B b = new B();
    C c = new C();

    a.Display();    // ����� ������ A
    b.Display();    // ����� ������ B
    ((A)b).Display();   // ����� ������ B

    c.Display();    // ����� ������ C
    ((A)c).Display();   // ����� ������ B
    ((B)c).Display();   // ����� ������ B
}
}
