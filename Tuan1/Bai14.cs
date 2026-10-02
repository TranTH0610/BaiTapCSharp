using System;
//Bài 14 
// Class lưu thông tin và tính lương nhân viên
class Bai14
{
    // Thuộc tính của nhân viên
    string Ten="";
    double luong;
    int vang;
    // hàm nhập thông tin nhân viên
    public void nhap()
    {
        // Nhập họ tên nhân viên
        Console.WriteLine("nhap ho ten nhan vien: ");
        Ten = Console.ReadLine() ?? string.Empty;
         // Nhập mức lương
        Console.WriteLine("nhap so luong: ");
        luong = double.Parse(Console.ReadLine() ?? string.Empty);
         // Nhập số buổi vắng
        Console.WriteLine("nhap so buoi vang: ");
        vang = int.Parse(Console.ReadLine() ?? string.Empty);
    }
    // Hàm tính lương sau khi trừ tiền vắng
    public double tinhluong()
    {
         // Mỗi buổi vắng bị trừ 100000 đồng
        return luong - vang*100000;
    }
    // Hàm xuất thông tin nhân viên
    public void xuat()
    {
         // Xuất tên nhân viên
        Console.WriteLine("Ten: " + Ten);
        // Xuất lương sau khi đã trừ tiền vắng
        Console.WriteLine("Luong: " + tinhluong());
         // Xuất số buổi vắng
        Console.WriteLine("vang: "+ vang);

    }
}