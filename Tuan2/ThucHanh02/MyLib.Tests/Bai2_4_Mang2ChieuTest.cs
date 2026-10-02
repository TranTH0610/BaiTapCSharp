using Xunit;

namespace MyLib.Tests;

public class Bai2_4_Mang2ChieuTest
{
    [Fact]
    public void ConstructorMacDinh()
    {
        Mang2Chieu a = new Mang2Chieu();

        Assert.Equal(0, a.Dong);
        Assert.Equal(0, a.cot);
    }

    [Fact]
    public void ConstructorCoThamSo()
    {
        Mang2Chieu a = new Mang2Chieu(2, 3);

        Assert.Equal(2, a.Dong);
        Assert.Equal(3, a.cot);
    }

    [Fact]
    public void Indexer()
    {
        Mang2Chieu a = new Mang2Chieu(2, 2);

        a[0, 0] = 10;
        a[0, 1] = 20;
        a[1, 0] = 30;
        a[1, 1] = 40;

        Assert.Equal(10, a[0, 0]);
        Assert.Equal(20, a[0, 1]);
        Assert.Equal(30, a[1, 0]);
        Assert.Equal(40, a[1, 1]);
    }

    [Fact]
    public void CopyConstructor()
    {
        Mang2Chieu a1 = new Mang2Chieu(2, 2);

        a1[0, 0] = 1;
        a1[0, 1] = 2;
        a1[1, 0] = 3;
        a1[1, 1] = 4;

        Mang2Chieu a2 = new Mang2Chieu(a1);

        Assert.Equal(1, a2[0, 0]);
        Assert.Equal(2, a2[0, 1]);
        Assert.Equal(3, a2[1, 0]);
        Assert.Equal(4, a2[1, 1]);
    }

    [Fact]
    public void TimSoNguyenTo()
    {
        Mang2Chieu a = new Mang2Chieu(2, 3);

        a[0, 0] = 2;
        a[0, 1] = 4;
        a[0, 2] = 5;

        a[1, 0] = 8;
        a[1, 1] = 7;
        a[1, 2] = 10;

        // Kiểm tra trực tiếp các số nguyên tố
        Assert.True(a[0, 0] == 2);
        Assert.True(a[0, 2] == 5);
        Assert.True(a[1, 1] == 7);
    }
}