using System;
using System.Linq;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai3_1
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 3.1 - THỐNG KÊ MẢNG SỐ");
        Console.WriteLine("========================================");

        int[] mangSo =
        {
            50, 42, 12, 3, 9,
            8, 1, 50, 3, 42, 85
        };
        int tongSoPhanTu = mangSo.Count();
        int SoPhanTuChan = mangSo.Count(x => x % 2 == 0);
        int SoPhanTuLe = mangSo.Count(x => x % 2 != 0);
        Console.WriteLine(
          $"Tổng số phần tử: {tongSoPhanTu}");

        Console.WriteLine(
            $"Số phần tử chẵn: {SoPhanTuChan}");

        Console.WriteLine(
            $"Số phần tử lẻ: {SoPhanTuLe}");
        int tong = mangSo.Sum();
        int max = mangSo.Max();
        int min = mangSo.Min();
        Console.WriteLine($"Tổng giá trị: {tong}");
        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
        Console.WriteLine("\n--- Câu c ---");
        int soGiaTriKhacNhau = mangSo
            .Distinct()
            .Count();

        Console.WriteLine(
            $"Có {soGiaTriKhacNhau} giá trị khác nhau.");
        Console.WriteLine(
            "\n--- Câu d: Phân nhóm theo số dư khi chia 5 ---");
        var nhomTheoDu = mangSo
       .GroupBy(x => x % 5)
       .OrderBy(g => g.Key);

        foreach (var group in nhomTheoDu)
        {
            Console.WriteLine(
                $"Số dư {group.Key}:");

            foreach (var x in group)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine();
        }
    }
}