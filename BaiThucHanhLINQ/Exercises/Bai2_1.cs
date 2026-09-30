using System;
using System.Linq;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai2_1
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 2.1 - TRUY VẤN MẢNG SỐ NGUYÊN");
        Console.WriteLine("========================================");

        int[] mangSo =
        {
            50, 42, 16, 3, 9,
            8, 12, 7, 24, 0
        };
        Console.WriteLine("\n--- Câu a: Chia hết cho 4 và 3 ---");
        var queryA =
        from x in mangSo
        where x % 4 == 0 && x % 3 == 0
        select x;
        foreach (var x in queryA)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
        var methodA = mangSo
        .Where(x => x % 4 == 0 && x % 3 == 0);
        foreach (var x in methodA)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
        Console.WriteLine("\n--- Câu b: Phần tử nhỏ hơn hoặc bằng 3 ---");
           var queryB =
            from x in mangSo
            where x <= 3
            select x;
        foreach (var x in queryB)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
           Console.WriteLine(
            "\n--- Câu c: Chẵn chia đôi, lẻ giữ nguyên ---");

        var queryC =
            from x in mangSo
            select x % 2 == 0 ? x / 2 : x;

        foreach (var x in queryC)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
    }
}