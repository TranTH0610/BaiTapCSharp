using System;
class Bai5
{
    // Khai báo phương thức MENU, dùng để hiển thị và xử lý menu
    public static void MENU()
    {
        // Khai báo biến n để lưu lựa chọn của người dùng.
        int n;
          // Khai báo hai biến số thực x và y, ban đầu có giá trị bằng 0.
        float x=0,y=0;
         // Dùng vòng lặp do...while để menu được hiển thị nhiều lần.
        do{
        // menu 
        Console.WriteLine("1.Nhap 2 so thuc x y");
        Console.WriteLine("2.Tinh x^y");
        Console.WriteLine("3.Tinh can bac 2 cua x,y");
        Console.WriteLine("4.Thoat");
          // Yêu cầu người dùng chọn chức năng.
        Console.WriteLine("Chon chuc nang: ");
        // Dùng switch để xử lý lựa chọn của người dùng.
        n = int.Parse(Console.ReadLine() ?? string.Empty);
        switch(n){
            // Nếu người dùng chọn chức năng 1.
            case 1:
            {
                  // Yêu cầu nhập giá trị x.
                Console.WriteLine("Nhap so x: ");
                 // Nhập x từ bàn phím và chuyển sang kiểu float.
                x = float.Parse(Console.ReadLine() ?? string.Empty);
                  // Yêu cầu nhập giá trị y.
                Console.WriteLine("Nhap so y: ");
                // Nhập y từ bàn phím và chuyển sang kiểu float.
                y = float.Parse(Console.ReadLine() ?? string.Empty);
            }
            break;// Kết thúc case 1.
            case 2:
                {
                    // Tính x mũ y bằng hàm Math.Pow().
                    // Ép kiểu kết quả từ double sang float.
                  float kq =(float)Math.Pow(x,y);
                   // In kết quả x mũ y ra màn hình.
                  Console.WriteLine("ket qua: "+kq); 
                }
                break;// Kết thúc case 2.
            case 3:
                {
                    // Tính căn bậc hai của x.
                    // Math.Sqrt() trả về kiểu double nên ép sang float.
                    float a = (float)Math.Sqrt(x);
                    float b = (float)Math.Sqrt(y);
                    Console.WriteLine("can bac 2 cua x: "+a);
                    Console.WriteLine("can bac 2 cua y: "+b);
                }
                break;// Kết thúc case 3.
            case 4:
                {
                     // Thông báo chương trình chuẩn bị thoát menu.
                   Console.WriteLine("thoat menu"); 
                }
                break;// Kết thúc case 4.
                 // Nếu người dùng nhập lựa chọn khác 1, 2, 3, 4.
                default:
                Console.WriteLine("ban da nhap sai!");
                break;// Kết thúc default.
        }
        // Tiếp tục lặp menu nếu n khác 4.
        }while (n != 4);
    }

}