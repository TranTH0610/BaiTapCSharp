using Xunit;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_5;

namespace MyLib.Tests;

public class Bai3_5Test
{
    // ==========================================
    // TEST 1: NHÂN VIÊN KINH DOANH
    // ==========================================

    [Fact]
    public void KiemTraLuongNhanVienKinhDoanh()
    {
        NhanVienKinhDoanh nv = new NhanVienKinhDoanh(
            "KD01",
            "Nguyen Van A",
            8000000,
            5
        );

        double luong = nv.TinhLuong();

        Assert.Equal(10500000, luong);
    }


    // ==========================================
    // TEST 2: NHÂN VIÊN SẢN XUẤT
    // KHÔNG ĐƯỢC THƯỞNG
    // ==========================================

    [Fact]
    public void KiemTraLuongNhanVienSanXuat()
    {
        NhanVienSanXuat nv = new NhanVienSanXuat(
            "SX01",
            "Nguyen Van B",
            2000
        );

        double luong = nv.TinhLuong();

        Assert.Equal(2000000, luong);
    }


    // ==========================================
    // TEST 3: NHÂN VIÊN SẢN XUẤT
    // ĐƯỢC THƯỞNG 5%
    // ==========================================

    [Fact]
    public void KiemTraThuong5PhanTram()
    {
        NhanVienSanXuat nv = new NhanVienSanXuat(
            "SX02",
            "Nguyen Van C",
            4000
        );

        double luong = nv.TinhLuong();

        Assert.Equal(4200000, luong);
    }


    // ==========================================
    // TEST 4: KIỂM TRA KẾ THỪA
    // ==========================================

    [Fact]
    public void KiemTraKeThua()
    {
        NhanVienKinhDoanh nv1 = new NhanVienKinhDoanh();
        NhanVienSanXuat nv2 = new NhanVienSanXuat();

        Assert.IsAssignableFrom<NhanVien3_5>(nv1);
        Assert.IsAssignableFrom<NhanVien3_5>(nv2);
    }


    // ==========================================
    // TEST 5: KIỂM TRA ĐA HÌNH
    // ==========================================

    [Fact]
    public void KiemTraDaHinh()
    {
        NhanVien3_5 nv1 = new NhanVienKinhDoanh(
            "KD01",
            "Nguyen Van A",
            8000000,
            5
        );

        NhanVien3_5 nv2 = new NhanVienSanXuat(
            "SX01",
            "Nguyen Van B",
            4000
        );

        Assert.Equal(10500000, nv1.TinhLuong());
        Assert.Equal(4200000, nv2.TinhLuong());
    }
}