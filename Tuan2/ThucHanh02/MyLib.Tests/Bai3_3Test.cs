using Xunit;
using MyLib.Chuong1_Basic.Bai1_1;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_3;

namespace MyLib.Tests;

public class Bai3_3Test
{
    // Hàm so sánh sinh viên theo năm sinh
    private int SoSanhSinhVien(object a, object b)
    {
        SinhVien sv1 = (SinhVien)a;
        SinhVien sv2 = (SinhVien)b;

        return sv1.SinhVienNamSinh.CompareTo(
            sv2.SinhVienNamSinh
        );
    }

    [Fact]
    public void KiemTraSapXepBangDelegate()
    {
        object[] ds =
        {
            new SinhVien
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new SinhVien
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new SinhVien
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        // Truyền hàm so sánh vào Sort
        SapXepDelegate.Sort(ds, SoSanhSinhVien);

        Assert.Equal(
            2003,
            ((SinhVien)ds[0]).SinhVienNamSinh
        );

        Assert.Equal(
            2005,
            ((SinhVien)ds[1]).SinhVienNamSinh
        );

        Assert.Equal(
            2006,
            ((SinhVien)ds[2]).SinhVienNamSinh
        );
    }

    [Fact]
    public void KiemTraThuTuHoTen()
    {
        object[] ds =
        {
            new SinhVien
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new SinhVien
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new SinhVien
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        SapXepDelegate.Sort(ds, SoSanhSinhVien);

        Assert.Equal(
            "Nguyen Van A",
            ((SinhVien)ds[0]).SinhVienHoten
        );

        Assert.Equal(
            "Nguyen Van B",
            ((SinhVien)ds[1]).SinhVienHoten
        );

        Assert.Equal(
            "Nguyen Van C",
            ((SinhVien)ds[2]).SinhVienHoten
        );
    }
}