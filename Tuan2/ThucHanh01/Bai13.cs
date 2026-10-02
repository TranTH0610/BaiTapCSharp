using System;
// Class lưu thông tin sinh viên
class Bai13
{
    // Các thuộc tính của sinh viên
    string masv ="";
    string Hoten="";
    string diachi="";
    int nam;
     // Hàm nhập thông tin sinh viên
    public void nhap()
    {
        // Nhập mã số sinh viên
        Console.WriteLine("nhap ma so sinh vien: ");
        masv = Console.ReadLine() ?? string.Empty;
        // Nhập họ tên sinh viên
        Console.WriteLine("nhap ho ten sinh vien: ");
        Hoten = Console.ReadLine() ?? string.Empty;
         // Nhập địa chỉ sinh viên
        Console.WriteLine("nhap dia chi sinh vien: ");
        diachi = Console.ReadLine() ?? string.Empty;
         // Nhập sinh viên đang học năm thứ mấy
        Console.WriteLine("nhap sinh vien nam : ");
        nam = int.Parse(Console.ReadLine() ?? string.Empty);
    }
       // Hàm xuất thông tin sinh viên
    public void xuat()
    {
        // xuất mã số sinh viên
        Console.WriteLine("Msv: "+masv);
         // Xuất họ và tên
        Console.WriteLine("Ho va ten: "+Hoten);
         // Xuất đị chỉ
        Console.WriteLine("Dia chi: "+diachi);
        // sinh năm thứ mấy
        Console.WriteLine("Hoc nam: "+nam);
    }
}