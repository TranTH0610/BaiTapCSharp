using System;

namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_4;

// Delegate xử lý khi người dùng chọn menu
public delegate void ChooseHandler(int choice);

public class ConsoleMenu
{
    public event ChooseHandler? Choose;

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Giải phương trình bậc 2");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("==========================");

            Console.Write("Thực hiện: ");

            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Vui lòng nhập số!");
                continue;
            }

            // Nếu chọn 0 thì thoát
            if (choice == 0)
            {
                Console.WriteLine("Thoát chương trình.");
                break;
            }

            // Gọi hàm xử lý lựa chọn
            XuLyLuaChon(choice);
        }
    }

    // Xử lý lựa chọn và kích hoạt Event
    public void XuLyLuaChon(int choice)
    {
        Choose?.Invoke(choice);
    }
}