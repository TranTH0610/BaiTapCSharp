using Xunit;

namespace MyLib.Tests;

public class Bai2_3_Mang1ChieuTest
{
    // Test constructor có số lượng phần tử
    [Fact]
    public void ConstructorSoLuong()
    {
        Mang1Chieu d = new Mang1Chieu(5);

        Assert.Equal(5, d.Count);
    }

    // Test Indexer
    [Fact]
    public void Indexer()
    {
        Mang1Chieu d = new Mang1Chieu(3);

        d[0] = 10;
        d[1] = 20;
        d[2] = 30;

        Assert.Equal(10, d[0]);
        Assert.Equal(20, d[1]);
        Assert.Equal(30, d[2]);
    }

    // Test Copy Constructor
    [Fact]
    public void CopyConstructor()
    {
        Mang1Chieu d1 = new Mang1Chieu(3);

        d1[0] = 10;
        d1[1] = 20;
        d1[2] = 30;

        Mang1Chieu d2 = new Mang1Chieu(d1);

        Assert.Equal(10, d2[0]);
        Assert.Equal(20, d2[1]);
        Assert.Equal(30, d2[2]);
    }

    // Test tìm số chẵn
    [Fact]
    public void TimSoChan()
    {
        Mang1Chieu d = new Mang1Chieu(5);

        d[0] = 10;
        d[1] = 15;
        d[2] = 20;
        d[3] = 25;
        d[4] = 30;

        Mang1Chieu ketQua = d.TimSoChan();

        Assert.Equal(3, ketQua.Count);
        Assert.Equal(10, ketQua[0]);
        Assert.Equal(20, ketQua[1]);
        Assert.Equal(30, ketQua[2]);
    }
}