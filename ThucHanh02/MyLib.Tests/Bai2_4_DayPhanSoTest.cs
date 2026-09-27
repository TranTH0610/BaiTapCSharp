using Xunit;

namespace MyLib.Tests;

public class Bai2_4_DayPhanSoTest
{
    // Test constructor có tham số
    [Fact]
    public void Constructor()
    {
        DayPhanSo ds = new DayPhanSo(3);

        Assert.Equal(3, ds.Count);
    }

    // Test Indexer
    [Fact]
    public void Indexer()
    {
        DayPhanSo ds = new DayPhanSo(2);

        ds[0] = new PhanSo(1, 2);
        ds[1] = new PhanSo(3, 4);

        Assert.Equal("1/2", ds[0].ToString());
        Assert.Equal("3/4", ds[1].ToString());
    }

    // Test Copy Constructor
    [Fact]
    public void CopyConstructor()
    {
        DayPhanSo ds1 = new DayPhanSo(2);

        ds1[0] = new PhanSo(1, 2);
        ds1[1] = new PhanSo(3, 4);

        DayPhanSo ds2 = new DayPhanSo(ds1);

        Assert.Equal("1/2", ds2[0].ToString());
        Assert.Equal("3/4", ds2[1].ToString());
    }

    // Test tính tổng
    [Fact]
    public void TongPhanSo()
    {
        DayPhanSo ds = new DayPhanSo(3);

        ds[0] = new PhanSo(1, 2);
        ds[1] = new PhanSo(1, 3);
        ds[2] = new PhanSo(1, 6);

        PhanSo tong = ds.Tong();

        Assert.Equal("1", tong.ToString());
    }

    // Test trường hợp tổng ra phân số
    [Fact]
    public void TongPhanSo_KetQuaPhanSo()
    {
        DayPhanSo ds = new DayPhanSo(2);

        ds[0] = new PhanSo(1, 2);
        ds[1] = new PhanSo(1, 4);

        PhanSo tong = ds.Tong();

        Assert.Equal("3/4", tong.ToString());
    }
}