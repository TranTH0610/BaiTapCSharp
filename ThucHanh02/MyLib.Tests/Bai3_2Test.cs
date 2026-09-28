using Xunit;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_2;

namespace MyLib.Tests;

public class Bai3_2Test
{
    // Test 1: Kiểm tra interface CompareTo
    [Fact]
    public void KiemTraCompareTo()
    {
        SV sv1 = new SV
        {
            SinhVienHoten = "Nguyen Van A",
            SinhVienNamSinh = 2003
        };

        SV sv2 = new SV
        {
            SinhVienHoten = "Nguyen Van B",
            SinhVienNamSinh = 2005
        };

        Assert.True(sv1.CompareTo(sv2) < 0);
        Assert.True(sv2.CompareTo(sv1) > 0);
    }

    // Test 2: Kiểm tra phương thức Sort()
    [Fact]
    public void KiemTraSapXep()
    {
        object[] ds =
        {
            new SV
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new SV
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new SV
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        SapXep.Sort(ds);

        SV sv0 = (SV)ds[0];
        SV sv1 = (SV)ds[1];
        SV sv2 = (SV)ds[2];

        Assert.Equal(2003, sv0.SinhVienNamSinh);
        Assert.Equal(2005, sv1.SinhVienNamSinh);
        Assert.Equal(2006, sv2.SinhVienNamSinh);
    }

    // Test 3: Kiểm tra họ tên sau khi sắp xếp
    [Fact]
    public void KiemTraThuTuHoTen()
    {
        object[] ds =
        {
            new SV
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new SV
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new SV
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        SapXep.Sort(ds);

        Assert.Equal(
            "Nguyen Van A",
            ((SV)ds[0]).SinhVienHoten
        );

        Assert.Equal(
            "Nguyen Van B",
            ((SV)ds[1]).SinhVienHoten
        );

        Assert.Equal(
            "Nguyen Van C",
            ((SV)ds[2]).SinhVienHoten
        );
    }
}