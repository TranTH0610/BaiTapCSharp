using System;

namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_4;

public class PTBac2Console : ConsoleMenu
{
    // Hàm xử lý lựa chọn menu
    public void XuLyChucNang(int choice)
    {
        switch (choice)
        {
            case 1:
                GiaiPhuongTrinhBac2();
                break;

            default:
                Console.WriteLine("Chức năng không tồn tại!");
                break;
        }
    }

    // Giải phương trình ax^2 + bx + c = 0
    public void GiaiPhuongTrinhBac2()
    {
        Console.WriteLine();
        Console.WriteLine("=== GIAI PHUONG TRINH BAC 2 ===");

        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine() ?? "0");

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -c / b;

                Console.WriteLine(
                    $"Phương trình có một nghiệm: x = {x}"
                );
            }

            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine(
                $"Phương trình có nghiệm kép: x1 = x2 = {x}"
            );
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}