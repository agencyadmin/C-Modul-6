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
}