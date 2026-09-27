using Xunit;

namespace MyLib.Tests;

public class Bai2_5Test
{
    [Fact]
    public void TinhLuongNhanVien()
    {
        NhanVien nv = new NhanVien(
            "Nguyen Van A",
            10000000,
            2
        );

        Assert.Equal(9800000, nv.TinhLuong());
    }

    [Fact]
    public void ConstructorPhongBan()
    {
        PhongBan pb = new PhongBan(3);

        Assert.Equal(3, pb.Count);
    }

    [Fact]
    public void Indexer()
    {
        PhongBan pb = new PhongBan(2);

        pb[0] = new NhanVien("A", 10000000, 0);
        pb[1] = new NhanVien("B", 12000000, 1);

        Assert.Equal("A", pb[0].HoTen);
        Assert.Equal("B", pb[1].HoTen);
    }

    [Fact]
    public void TongLuong()
    {
        PhongBan pb = new PhongBan(2);

        pb[0] = new NhanVien(
            "Nguyen Van A",
            10000000,
            2
        );

        pb[1] = new NhanVien(
            "Tran Van B",
            12000000,
            1
        );

        double tong = pb.TongLuong();

        Assert.Equal(21700000, tong);
    }
}