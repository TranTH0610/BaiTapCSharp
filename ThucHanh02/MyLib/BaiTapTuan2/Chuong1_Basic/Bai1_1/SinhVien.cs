using System;
namespace MyLib.Chuong1_Basic.Bai1_1;

public class SinhVien
{
    // Field
    private string Hoten;
    private int NamSinh;
    //Constructor
    public SinhVien(){
        Hoten ="";
        NamSinh = 0;
    }
    public string SinhVienHoten
    {
        get
        {
            return Hoten;
        }
        set
        {
            Hoten = value;
        }
    }
    public int SinhVienNamSinh
    {
        get
        {
            return NamSinh;
        }
        set
        {
            NamSinh = value;
        }
    }
    //Method
    // Ham Nhập
    public void nhap()
    {
        Console.WriteLine("Nhap ho ten sinh vien: ");
        Hoten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Nhap nam sinh cua sinh vien: ");
        NamSinh = int.Parse(Console.ReadLine() ?? string.Empty);
    }
    public void xuat()
    {
        Console.WriteLine("Ho va ten: "+Hoten);
        Console.WriteLine("Nam sinh: "+NamSinh);
        Console.WriteLine("So tuoi: "+TinhTuoi());
    }
    public int TinhTuoi()
    {
        return DateTime.Now.Year-NamSinh;
    }


}
