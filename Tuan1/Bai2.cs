using System;
class Bai2
{
    //Bài 2
    // pubblic Có nghĩa là phương thức này có thể được gọi từ bên ngoài class.
    // static Có nghĩa là phương thức thuộc về class, không cần tạo đối tượng vẫn gọi được.
    // void chỉ thực hiện công việc, không trả về kết quả.
     public static void NhapHoVaTen()
    {
        //Console.WriteLine() dùng để in nội dung ra màn hình.
        Console.WriteLine("Nhap Ten: ");
        // Khai báo một biến tên là hoten string nghĩa là biến dùng để lưu chuỗi ký tự.
        string hoten = Console.ReadLine() ?? string.Empty;
        //Dùng để đọc dữ liệu người dùng nhập từ bàn phím
        Console.WriteLine(" Chao " + hoten);
    }
}