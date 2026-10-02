using Xunit;

namespace MyLib.Tests;

public class Bai2_2Test
{
    // Test Constructor mặc định
    [Fact]
    public void ConstructorMacDinh()
    {
        PersonList list = new PersonList();

        Assert.Equal(0, list.Count);
    }

    // Test Add(Person)
    [Fact]
    public void AddPerson()
    {
        PersonList list = new PersonList();

        Person p = new Person();
        p.Id = 1;
        p.Name = "Nguyen Van A";
        p.Yob = 2000;
        p.Yod = 0;

        list.ADD(p);

        Assert.Equal(1, list.Count);
    }

    // Test Add nhiều Person
    [Fact]
    public void AddNhieuPerson()
    {
        PersonList list = new PersonList();

        Person p1 = new Person();
        p1.Id = 1;
        p1.Name = "Nguyen Van A";

        Person p2 = new Person();
        p2.Id = 2;
        p2.Name = "Tran Van B";

        list.ADD(p1);
        list.ADD(p2);

        Assert.Equal(2, list.Count);
    }

    // Test LivingPeople
    [Fact]
    public void LivingPeople()
    {
        PersonList list = new PersonList();

        // Người còn sống
        Person p1 = new Person();
        p1.Name = "Nguyen Van A";
        p1.Yod = 0;

        // Người đã mất
        Person p2 = new Person();
        p2.Name = "Tran Van B";
        p2.Yod = 2020;

        // Người còn sống
        Person p3 = new Person();
        p3.Name = "Le Van C";
        p3.Yod = 0;

        list.ADD(p1);
        list.ADD(p2);
        list.ADD(p3);

        PersonList living = list.LivingPeople();

        Assert.Equal(2, living.Count);
    }

    // Test Copy Constructor
    [Fact]
    public void CopyConstructor()
    {
        PersonList list1 = new PersonList();

        Person p1 = new Person();
        p1.Id = 1;
        p1.Name = "Nguyen Van A";
        p1.Yob = 2000;
        p1.Yod = 0;

        list1.ADD(p1);

        PersonList list2 = new PersonList(list1);

        Assert.Equal(list1.Count, list2.Count);
    }
}