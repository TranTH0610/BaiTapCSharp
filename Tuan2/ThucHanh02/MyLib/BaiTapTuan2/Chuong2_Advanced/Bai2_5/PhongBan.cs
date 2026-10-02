using System;

public class PhongBan
{
    private NhanVien[] ds;

    // Constructor mặc định
    public PhongBan()
    {
        ds = new NhanVien[0];
    }

    // Constructor có tham số
    public PhongBan(int n)
    {
        ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            ds[i] = new NhanVien();
        }
    }

    // Copy Constructor
    public PhongBan(PhongBan other)
    {
        ds = new NhanVien[other.ds.Length];

        for (int i = 0; i < other.ds.Length; i++)
        {
            ds[i] = new NhanVien(other.ds[i]);
        }
    }

    // Indexer
    public NhanVien this[int i]
    {
        get
        {
            return ds[i];
        }

        set
        {
            ds[i] = value;
        }
    }

    // Số nhân viên
    public int Count
    {
        get
        {
            return ds.Length;
        }
    }

    // Nhập danh sách nhân viên
    public void Nhap()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("--- Nhan vien thu " + (i + 1) + " ---");
            ds[i].Nhap();
        }
    }

    // Xuất danh sách nhân viên
    public void Xuat()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.WriteLine("--- Nhan vien thu " + (i + 1) + " ---");
            ds[i].Xuat();
        }
    }

    // Tính tổng lương phòng ban
    public double TongLuong()
    {
        double tong = 0;

        for (int i = 0; i < ds.Length; i++)
        {
            tong += ds[i].TinhLuong();
        }

        return tong;
    }
}