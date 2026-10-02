using System;
class Bai4
{  
    //Bài 4
    // Hàm tính x mũ y, trả về kết quả kiểu int.
        public static int TinhHaiSoNguyen()
    {
         // Tạo biến kq để lưu kết quả tính x mũ y.
        int kq = 0;
        int x;
        int y;
          // Yêu cầu người dùng nhập số x
        Console.Write("Nhap x: ");
        // Kiểm tra x có phải là số nguyên tố hay không
        if(!int.TryParse(Console.ReadLine(), out x))
        {
            // Thông báo nếu x không phải là số nguyên tố
            Console.WriteLine("x khong phai la so nguyen ");
            // Trả về kết quả hiện tại và kết thúc hàm
            return 0;
        }
         // Yêu cầu người dùng nhập số y
        Console.Write("Nhap y: ");
        // Kiểm tra y có phải là số nguyên tố hay không
        if(!int.TryParse((Console.ReadLine()), out y))
        {
             // Thông báo nếu y không phải là số nguyên 
            Console.WriteLine("y khong phai la so nguyen ");
            // Trả về kết quả hiện tại và kết thúc hàm
            return 0;
        }
        kq =(int)Math.Pow(x,y);
        // Trả về kết quả hiện tại và kết thúc hàm.
        return kq;
    }
}