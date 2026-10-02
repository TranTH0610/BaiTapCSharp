using Xunit;

namespace MyLib.Tests;

public class Bai2_3_DaThucTest
{
    [Fact]
    public void ConstructorMacDinh()
    {
        DaThuc p = new DaThuc();

        Assert.Equal(-1, p.Bac);
    }

    [Fact]
    public void ConstructorCoThamSo()
    {
        DaThuc p = new DaThuc(3);

        Assert.Equal(3, p.Bac);
    }

    [Fact]
    public void Indexer()
    {
        DaThuc p = new DaThuc(3);

        p[0] = 2;
        p[1] = 3;
        p[2] = 4;
        p[3] = 5;

        Assert.Equal(2, p[0]);
        Assert.Equal(3, p[1]);
        Assert.Equal(4, p[2]);
        Assert.Equal(5, p[3]);
    }

    [Fact]
    public void CopyConstructor()
    {
        DaThuc p1 = new DaThuc(2);

        p1[0] = 2;
        p1[1] = 3;
        p1[2] = 4;

        DaThuc p2 = new DaThuc(p1);

        Assert.Equal(2, p2[0]);
        Assert.Equal(3, p2[1]);
        Assert.Equal(4, p2[2]);
    }

    [Fact]
    public void TinhGiaTri()
    {
        DaThuc p = new DaThuc(2);

        p[0] = 2;
        p[1] = 3;
        p[2] = 4;

        double ketQua = p.TinhGiaTri(2);

        Assert.Equal(24, ketQua);
    }
}