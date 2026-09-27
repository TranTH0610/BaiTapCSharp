using System;
using Xunit;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_1;

namespace MyLib.Tests;

public class Bai3_1Test
{
    // Test 1: Kiểm tra ArraySort có kế thừa SinhVien
    [Fact]
    public void KiemTraKeThua()
    {
        ArraySort sv = new ArraySort();

        sv.SinhVienHoten = "Nguyen Van A";
        sv.SinhVienNamSinh = 2003;

        Assert.Equal("Nguyen Van A", sv.SinhVienHoten);
        Assert.Equal(2003, sv.SinhVienNamSinh);
    }

    // Test 2: Kiểm tra CompareTo()
    [Fact]
    public void KiemTraCompareTo()
    {
        ArraySort sv1 = new ArraySort
        {
            SinhVienHoten = "Nguyen Van A",
            SinhVienNamSinh = 2003
        };

        ArraySort sv2 = new ArraySort
        {
            SinhVienHoten = "Nguyen Van B",
            SinhVienNamSinh = 2005
        };

        // 2003 < 2005
        Assert.True(sv1.CompareTo(sv2) < 0);

        // 2005 > 2003
        Assert.True(sv2.CompareTo(sv1) > 0);
    }

    // Test 3: Kiểm tra Array.Sort()
    [Fact]
    public void KiemTraArraySort()
    {
        ArraySort[] ds =
        {
            new ArraySort
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new ArraySort
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new ArraySort
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        // Sắp xếp bằng Array.Sort()
        Array.Sort(ds);

        // Kiểm tra thứ tự năm sinh
        Assert.Equal(2003, ds[0].SinhVienNamSinh);
        Assert.Equal(2005, ds[1].SinhVienNamSinh);
        Assert.Equal(2006, ds[2].SinhVienNamSinh);
    }

    // Test 4: Kiểm tra thứ tự họ tên sau khi sắp xếp
    [Fact]
    public void KiemTraThuTuHoTen()
    {
        ArraySort[] ds =
        {
            new ArraySort
            {
                SinhVienHoten = "Nguyen Van C",
                SinhVienNamSinh = 2006
            },

            new ArraySort
            {
                SinhVienHoten = "Nguyen Van A",
                SinhVienNamSinh = 2003
            },

            new ArraySort
            {
                SinhVienHoten = "Nguyen Van B",
                SinhVienNamSinh = 2005
            }
        };

        Array.Sort(ds);

        Assert.Equal("Nguyen Van A", ds[0].SinhVienHoten);
        Assert.Equal("Nguyen Van B", ds[1].SinhVienHoten);
        Assert.Equal("Nguyen Van C", ds[2].SinhVienHoten);
    }

    // Test 5: Kiểm tra CompareTo với null
    [Fact]
    public void KiemTraCompareToNull()
    {
        ArraySort sv = new ArraySort
        {
            SinhVienHoten = "Nguyen Van A",
            SinhVienNamSinh = 2003
        };

        Assert.Equal(1, sv.CompareTo(null));
    }
}