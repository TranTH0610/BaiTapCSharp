using System;

public class NhanVien
{
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    // Constructor mặc định
    public NhanVien()
    {
        hoTen = "";
        mucLuong = 0;
        soNgayVang = 0;
    }

    // Constructor có tham số
    public NhanVien(string hoTen, double mucLuong, int soNgayVang)
    {
        this.hoTen = hoTen;
        this.mucLuong = mucLuong;
        this.soNgayVang = soNgayVang;
    }

    // Copy Constructor
    public NhanVien(NhanVien nv)
    {
        hoTen = nv.hoTen;
        mucLuong = nv.mucLuong;
        soNgayVang = nv.soNgayVang;
    }

    // Property
    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double MucLuong
    {
        get { return mucLuong; }
        set { mucLuong = value; }
    }

    public int SoNgayVang
    {
        get { return soNgayVang; }
        set { soNgayVang = value; }
    }

    // Nhập
    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap muc luong: ");
        mucLuong = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(Console.ReadLine() ?? "0");
    }

    // Tính lương thực nhận
    public double TinhLuong()
    {
        return mucLuong - soNgayVang * 100000;
    }

    // Xuất
    public void Xuat()
    {
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Muc luong: " + mucLuong);
        Console.WriteLine("So ngay vang: " + soNgayVang);
        Console.WriteLine("Luong thuc nhan: " + TinhLuong());
    }
}