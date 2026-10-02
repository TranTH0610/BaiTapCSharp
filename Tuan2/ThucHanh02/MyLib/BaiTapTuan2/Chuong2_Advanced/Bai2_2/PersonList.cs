using System;
using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
public class PersonList
{
    private ArrayList dsPerson;
    public PersonList()
    {
        dsPerson = new ArrayList();
    }
    //Copy constructor
    public PersonList(PersonList other)
    {
        dsPerson = new ArrayList();
        foreach (Person p in other.dsPerson)
        {
            dsPerson.Add(new Person(p));
        }
    }
    public void ADD(Person x)
    {
        dsPerson.Add(x);
    }

    public void input()
    {
        Console.WriteLine("nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("nhap nguoi thu {i+1}: ");
            Person p = new Person();
            p.nhap();
            ADD(p);
        }
    }
    public void Output()
    {
        foreach (Person p in dsPerson)
        {
            p.xuat();
            Console.WriteLine();
        }
    }
    // Trả về danh sách những người còn sống
    public PersonList LivingPeople()
    {
        PersonList result = new PersonList();

        foreach (Person p in dsPerson)
        {
            if (p.IsLiving())
            {
                result.ADD(p);
            }
        }

        return result;
    }

    // Số lượng Person
    public int Count
    {
        get { return dsPerson.Count; }
    }
}
