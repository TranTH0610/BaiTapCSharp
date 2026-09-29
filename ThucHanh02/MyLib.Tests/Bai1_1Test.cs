using System;
using System.IO;
using Xunit;
using MyLib.Chuong1_Basic.Bai1_1;

namespace MyLib.Tests;

public class Bai1_1Test
{
    // ==========================================
    // TEST 1: KIỂM TRA CONSTRUCTOR
    // ==========================================

    [Fact]
    public void KiemTraConstructor()
    {
        SinhVien sv = new SinhVien();

        Assert.Equal("", sv.SinhVienHoten);
        Assert.Equal(0, sv.SinhVienNamSinh);
    }


    // ==========================================
    // TEST 2: KIỂM TRA PROPERTY HỌ TÊN
    // ==========================================

    [Fact]
    public void KiemTraHoTen()
    {
        SinhVien sv = new SinhVien();

        sv.SinhVienHoten = "Nguyen Van A";

        Assert.Equal("Nguyen Van A", sv.SinhVienHoten);
    }


    // ==========================================
    // TEST 3: KIỂM TRA PROPERTY NĂM SINH
    // ==========================================

    [Fact]
    public void KiemTraNamSinh()
    {
        SinhVien sv = new SinhVien();

        sv.SinhVienNamSinh = 2005;

        Assert.Equal(2005, sv.SinhVienNamSinh);
    }


    // ==========================================
    // TEST 4: KIỂM TRA TÍNH TUỔI
    // ==========================================

    [Fact]
    public void KiemTraTinhTuoi()
    {
        SinhVien sv = new SinhVien();

        sv.SinhVienNamSinh = 2005;

        int tuoi = DateTime.Now.Year - 2005;

        Assert.Equal(tuoi, sv.TinhTuoi());
    }


    // ==========================================
    // TEST 5: KIỂM TRA NHẬP THÔNG TIN
    // ==========================================

    [Fact]
    public void KiemTraNhap()
    {
        SinhVien sv = new SinhVien();

        // Giả lập dữ liệu nhập từ bàn phím
        Console.SetIn(
            new StringReader("Nguyen Van A\n2005\n")
        );

        sv.nhap();

        Assert.Equal("Nguyen Van A", sv.SinhVienHoten);
        Assert.Equal(2005, sv.SinhVienNamSinh);
    }


    // ==========================================
    // TEST 6: KIỂM TRA XUẤT THÔNG TIN
    // ==========================================

    [Fact]
    public void KiemTraXuat()
    {
        SinhVien sv = new SinhVien();

        sv.SinhVienHoten = "Nguyen Van A";
        sv.SinhVienNamSinh = 2005;

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        sv.xuat();

        string ketQua = output.ToString();

        Assert.Contains("Ho va ten: Nguyen Van A", ketQua);
        Assert.Contains("Nam sinh: 2005", ketQua);
        Assert.Contains(
            "So tuoi: " + (DateTime.Now.Year - 2005),
            ketQua
        );
    }
}