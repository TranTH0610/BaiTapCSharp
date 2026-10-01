using BaiThucHanhLINQ.Exercises;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
    {
        Console.OutputEncoding =
            System.Text.Encoding.UTF8;

        Console.WriteLine(
            "==============================================");

        Console.WriteLine(
            "        THỰC HÀNH LINQ CƠ BẢN");

        Console.WriteLine(
            "==============================================");

        // Bài 2
        Bai2_1.Run();
        Bai2_2.Run();

        // Bài 3
        Bai3_1.Run();
        Bai3_2.Run();

        // Bài 5
        Bai5_1.Run();
        Bai5_2.Run();

        // Bài 6
        Bai6_2.Run();

        Console.WriteLine(
            "\n==============================================");

        Console.WriteLine(
            "             ĐÃ CHẠY XONG");

        Console.WriteLine(
            "==============================================");

        Console.WriteLine(
            "\nNhấn phím bất kỳ để kết thúc...");

        Console.ReadKey();
    }
}
