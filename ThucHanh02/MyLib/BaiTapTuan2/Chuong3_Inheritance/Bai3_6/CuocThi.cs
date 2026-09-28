using System;
using System.Collections.Generic;

namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_6;

public class CuocThi
{
    private List<ThiSinh> danhSach;

    public CuocThi()
    {
        danhSach = new List<ThiSinh>();
    }

    public void ThemThiSinh(ThiSinh thiSinh)
    {
        danhSach.Add(thiSinh);
    }

    public void XuatDanhSach()
    {
        Console.WriteLine("========== KET QUA CUOC THI ==========");

        foreach (ThiSinh ts in danhSach)
        {
            Console.WriteLine("SBD: " + ts.SBD);
            Console.WriteLine("Ho ten: " + ts.HoTen);
            Console.WriteLine("Tong diem: " + ts.TinhTongDiem());
            Console.WriteLine("--------------------------------------");
        }
    }

    public List<ThiSinh> DanhSach
    {
        get { return danhSach; }
    }
}