using System;
class Bai6
{
    //Bài 6
     // Khai báo phương thức SolonNhat.
    // Phương thức trả về một số nguyên nên dùng kiểu int.
    public static int SolonNhat()
    {

        int a,b,c;
        // Yêu cầu người dùng nhập số nguyên a,b,c.
        Console.WriteLine("Nhap so nguyen a: ");
        a = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap so nguyen b: ");
        b = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap so nguyen c: ");
        c = int.Parse(Console.ReadLine() ?? string.Empty);
        // Giả sử ban đầu a là số lớn nhất.
        int max =a;
        // Nếu b lớn hơn max thì cập nhật max bằng b
        if(b>a)  max = b;
        // Nếu c lớn hơn max thì cập nhật max bằng c.
        if (c>b)  max = c;
         // Trả về giá trị lớn nhất.
        return max;
    }
}