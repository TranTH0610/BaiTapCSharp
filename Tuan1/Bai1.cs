using System;
class bai1
{
    //Bài 1
    // pubblic Có nghĩa là phương thức này có thể được gọi từ bên ngoài class.
    // static Có nghĩa là phương thức thuộc về class, không cần tạo đối tượng vẫn gọi được.
    // void chỉ thực hiện công việc, không trả về kết quả.
    public static void HovaTen()
    {
        //Console.WriteLine() dùng để in nội dung ra màn hình.
        Console.WriteLine("Nhap Ho Ten: ");
        // Khai báo một biến tên là Hoten string nghĩa là biến dùng để lưu chuỗi ký tự.
        string Hoten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(Hoten);
        //Dùng để đọc dữ liệu người dùng nhập từ bàn phím
    }
}