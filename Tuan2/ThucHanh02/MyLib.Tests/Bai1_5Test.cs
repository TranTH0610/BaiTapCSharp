using Xunit;
using MyLib;

namespace MyLib.Tests;

public class Bai1_5Test
{
    [Fact]
    public void TinhGiaTri()
    {
        DonThuc p = new DonThuc(3, 2);

        double ketQua = p.TinhDonThuc(2);

        Assert.Equal(12, ketQua);
    }

    [Fact]
    public void DaoHam()
    {
        DonThuc p = new DonThuc(3, 2);

        DonThuc ketQua = p.DaoHam();

        Assert.Equal("6x^1", ketQua.ToString());
    }

    [Fact]
    public void DaoHamSoHang()
    {
        DonThuc p = new DonThuc(5, 0);

        DonThuc ketQua = p.DaoHam();

        Assert.Equal("0x^0", ketQua.ToString());
    }

    [Fact]
    public void SoMuAm_BaoLoi()
    {
        Assert.Throws<ArgumentException>(() =>
            new DonThuc(3, -1)
        );
    }
}