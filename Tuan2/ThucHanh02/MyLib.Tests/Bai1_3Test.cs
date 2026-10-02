using Xunit;

namespace MyLib.Tests;

public class Bai1_3Test
{
    // Test constructor mặc định
    [Fact]
    public void ConstructorMacDinh()
    {
        Person p = new Person();

        Assert.Equal(0, p.Id);
        Assert.Equal("", p.Name);
        Assert.Equal(0, p.Yob);
        Assert.Equal(0, p.Yod);
    }

    // Test Property
    [Fact]
    public void TestProperty()
    {
        Person p = new Person();

        p.Id = 1;
        p.Name = "Nguyen Van A";
        p.Yob = 2000;
        p.Yod = 0;

        Assert.Equal(1, p.Id);
        Assert.Equal("Nguyen Van A", p.Name);
        Assert.Equal(2000, p.Yob);
        Assert.Equal(0, p.Yod);
    }

    // Test người đang sống
    [Fact]
    public void IsLiving_DangSong()
    {
        Person p = new Person();

        p.Yod = 0;

        Assert.True(p.IsLiving());
    }

    // Test người đã mất
    [Fact]
    public void IsLiving_DaMat()
    {
        Person p = new Person();

        p.Yod = 2020;

        Assert.False(p.IsLiving());
    }

    // Test Copy Constructor
    [Fact]
    public void CopyConstructor()
    {
        Person p1 = new Person();

        p1.Id = 1;
        p1.Name = "Nguyen Van A";
        p1.Yob = 2000;
        p1.Yod = 0;

        Person p2 = new Person(p1);

        Assert.Equal(p1.Id, p2.Id);
        Assert.Equal(p1.Name, p2.Name);
        Assert.Equal(p1.Yob, p2.Yob);
        Assert.Equal(p1.Yod, p2.Yod);
    }
}