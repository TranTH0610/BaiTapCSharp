using Xunit;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_6;

namespace MyLib.Tests;

public class Bai3_6Test
{
    // ==========================================
    // TEST 1: THÍ SINH CHUYÊN
    // TIẾNG ANH 7-8 → CỘNG 1
    // ==========================================

    [Fact]
    public void KiemTraThiSinhChuyenCong1Diem()
    {
        ThiSinhChuyen ts = new ThiSinhChuyen(
            "C01",
            "Nguyen Van A",
            8,
            7,
            9,
            8
        );

        double tong = ts.TinhTongDiem();

        Assert.Equal(25, tong);
    }


    // ==========================================
    // TEST 2: THÍ SINH CHUYÊN
    // TIẾNG ANH 9-10 → CỘNG 2
    // ==========================================

    [Fact]
    public void KiemTraThiSinhChuyenCong2Diem()
    {
        ThiSinhChuyen ts = new ThiSinhChuyen(
            "C02",
            "Nguyen Van B",
            8,
            7,
            9,
            9
        );

        double tong = ts.TinhTongDiem();

        Assert.Equal(26, tong);
    }


    // ==========================================
    // TEST 3: TIẾNG ANH KHÔNG ĐƯỢC CỘNG
    // ==========================================

    [Fact]
    public void KiemTraThiSinhChuyenKhongCong()
    {
        ThiSinhChuyen ts = new ThiSinhChuyen(
            "C03",
            "Nguyen Van C",
            8,
            7,
            9,
            6
        );

        double tong = ts.TinhTongDiem();

        Assert.Equal(24, tong);
    }


    // ==========================================
    // TEST 4: THÍ SINH SIÊU CÚP
    // ==========================================

    [Fact]
    public void KiemTraThiSinhSieuCup()
    {
        ThiSinhSieuCup ts = new ThiSinhSieuCup(
            "SC01",
            "Nguyen Van D",
            8,
            7,
            9,
            8
        );

        double tong = ts.TinhTongDiem();

        Assert.Equal(32, tong);
    }


    // ==========================================
    // TEST 5: KIỂM TRA KẾ THỪA
    // ==========================================

    [Fact]
    public void KiemTraKeThua()
    {
        ThiSinhChuyen chuyen = new ThiSinhChuyen();
        ThiSinhSieuCup sieuCup = new ThiSinhSieuCup();

        Assert.IsAssignableFrom<ThiSinh>(chuyen);
        Assert.IsAssignableFrom<ThiSinh>(sieuCup);
    }


    // ==========================================
    // TEST 6: KIỂM TRA ĐA HÌNH
    // ==========================================

    [Fact]
    public void KiemTraDaHinh()
    {
        ThiSinh ts1 = new ThiSinhChuyen(
            "C01",
            "Nguyen Van A",
            8,
            7,
            9,
            8
        );

        ThiSinh ts2 = new ThiSinhSieuCup(
            "SC01",
            "Nguyen Van B",
            8,
            7,
            9,
            8
        );

        Assert.Equal(25, ts1.TinhTongDiem());
        Assert.Equal(32, ts2.TinhTongDiem());
    }


    // ==========================================
    // TEST 7: QUẢN LÝ DANH SÁCH CUỘC THI
    // ==========================================

    [Fact]
    public void KiemTraThemThiSinh()
    {
        CuocThi cuocThi = new CuocThi();

        ThiSinhChuyen ts1 = new ThiSinhChuyen(
            "C01",
            "Nguyen Van A",
            8,
            7,
            9,
            8
        );

        cuocThi.ThemThiSinh(ts1);

        Assert.Single(cuocThi.DanhSach);
        Assert.Equal("C01", cuocThi.DanhSach[0].SBD);
    }
}