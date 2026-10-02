using Xunit;

namespace MyLib.Tests;

public class Bai2_1Test
{
    [Fact]
    public void ThemPoint()
    {
        ArrayPoint arr = new ArrayPoint();

        arr.ADD(new Point(1, 2));

        Assert.Equal(1, arr.Count);
    }

    [Fact]
    public void Indexer_LayPoint()
    {
        ArrayPoint arr = new ArrayPoint();

        arr.ADD(new Point(1, 2));
        arr.ADD(new Point(3, 4));

        Point p = arr[1];

        Assert.Equal(3, p.Pointx);
        Assert.Equal(4, p.Pointy);
    }

    [Fact]
    public void Indexer_GanPoint()
    {
        ArrayPoint arr = new ArrayPoint();

        arr.ADD(new Point(1, 2));

        arr[0] = new Point(10, 20);

        Assert.Equal(10, arr[0].Pointx);
        Assert.Equal(20, arr[0].Pointy);
    }
}