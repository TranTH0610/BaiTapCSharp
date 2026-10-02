using System;
class Bai3
{
    //Bài 3
    //int cho biết hàm này sẽ trả về một số nguyên.
    public static int TinhHaiSoNguyen()
    {
        //Tạo biến kq kiểu int để lưu kết quả.
        int kq = 0;
        Console.WriteLine("Nhap x: ");
        // nhập biến x
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap y: ");
        // nhập biến y
        int y = int.Parse(Console.ReadLine() ?? string.Empty);
        // tính x^y
        kq = (int)Math.Pow(x, y);
        return kq;// trả về kết quả x^y.
    }
}