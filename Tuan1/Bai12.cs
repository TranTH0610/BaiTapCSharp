using System;
class Bai12
{
    // Bài 12
     // Hàm nhận vào một chuỗi s
    public static void XuLy(string s)
    {
           // Chuyển chuỗi thành chữ thường
        Console.WriteLine("chuoi thuong: " + s.ToLower());
           // Chuyển chuỗi thành chữ Hoa
        Console.WriteLine("chuoi in hoa: " + s.ToUpper());
        // Tách chuỗi thành các từ dựa vào dấu cách
        // RemoveEmptyEntries giúp bỏ qua các phần tử rỗng
        string [] mangTu = s.Split(
            new char[] {' '},StringSplitOptions.RemoveEmptyEntries
        );
          // Đếm số từ trong chuỗi
        Console.WriteLine("dem chuoi: " + mangTu.Length);
    }
}