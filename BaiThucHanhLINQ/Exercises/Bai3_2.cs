using System;
using System.Linq;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai3_2
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 3.2 - THỐNG KÊ MẢNG CHUỖI");
        Console.WriteLine("========================================");

        string[] monAn =
        {
            "Bún bò Huế",
            "Hủ tiếu heo",
            "Bánh canh",
            "Bánh mì",
            "Nước Cà phê",
            "Mì quảng",
            "Cơm tấm",
            "Nước Chanh dây",
            "Mì xào",
            "Bún riêu",
            "Bánh cuốn",
            "Mì gói",
            "Bún chả",
            "Hủ tiếu Nam vang"
        };
        Console.WriteLine(
           "\n--- Câu a: Ngắn nhất và dài nhất ---");
        int DoDaiLonNhat = monAn
        .Max(x => x.Length);
        int DoDaiNhoNhat = monAn
        .Min(x => x.Length);
        var monNganNhat = monAn
            .Where(x => x.Length == DoDaiNhoNhat);

        var monDaiNhat = monAn
            .Where(x => x.Length == DoDaiLonNhat);

        Console.WriteLine(
            $"Độ dài ngắn nhất: {DoDaiNhoNhat}");

        foreach (var x in monNganNhat)
        {
            Console.WriteLine($"- {x}");
        }

        Console.WriteLine(
            $"Độ dài dài nhất: {DoDaiLonNhat}");

        foreach (var x in monDaiNhat)
        {
            Console.WriteLine($"- {x}");
        }
        Console.WriteLine(
          "\n--- Câu b: Phân nhóm theo từ đầu tiên ---");
        var nhomTheoTuDau = monAn
           .GroupBy(x => x.Split(
               ' ',
               StringSplitOptions.RemoveEmptyEntries)[0])
           .OrderBy(g => g.Key);

        foreach (var group in nhomTheoTuDau)
        {
            Console.WriteLine(
                $"\nNhóm: {group.Key}");

            foreach (var mon in group)
            {
                Console.WriteLine($"  - {mon}");
            }
        }
        Console.WriteLine(
           "\n--- Câu c: Số món bắt đầu bằng 'Bánh' ---");

        int soMonBanh = monAn
            .Count(x => x.StartsWith(
                "Bánh",
                StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(
            $"Có {soMonBanh} món bắt đầu bằng 'Bánh'.");
    }
}
