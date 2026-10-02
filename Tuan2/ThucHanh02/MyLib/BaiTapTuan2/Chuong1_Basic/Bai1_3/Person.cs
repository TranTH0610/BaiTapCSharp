using System;
public class Person
{
    private int id;
    private string name;
    private int yob;
    private int yod;
    public Person()
    {
        id =0;
        name ="";
        yob =0;
        yod =0;
    }
    //COPY CONSTRUCTOR
    public Person(Person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }
    // PROPERTY
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Yob
    {
        get { return yob; }
        set { yob = value; }
    }

    public int Yod
    {
        get { return yod; }
        set { yod = value; }
    }
    public void nhap()
    {
        Console.Write("Nhap ID: ");
        id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap ten: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine() ?? "0");
    }
     public void xuat()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Ten: " + name);
        Console.WriteLine("Nam sinh: " + yob);
        Console.WriteLine("Nam mat: " + yod);
        Console.WriteLine("Dang song: " + IsLiving());
    }
     // ISLIVING
       public bool IsLiving()
    {
        if (yod == 0)
        {
            return true;
        }

        return false;
    }
}
