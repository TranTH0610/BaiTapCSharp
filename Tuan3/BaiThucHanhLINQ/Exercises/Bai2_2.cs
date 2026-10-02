using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BaiThucHanhLINQ.Exercises;

public class Bai2_2
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 2.2 - TRUY VẤN MẢNG CHUỖI");
        Console.WriteLine("========================================");

        string[] mangChuoi =
        {
            "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em",
            "là", "Thúy", "Vân"
        };
        Console.WriteLine(
          "\n--- Câu a: Chuỗi có 4 ký tự ---");
        var queryA =
        from x in mangChuoi
        where x.Length == 4
        orderby x[0]
        select x;

        foreach (var x in queryA)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine(
           "\n--- Câu b: Chữ thường - CHỮ HOA ---");
        var resultB = mangChuoi
        .Select(x => $"{x.ToLower()} - {x.ToUpper()}");
        foreach (var x in resultB)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine(
            "\n--- Câu c: Có chứa ký tự 'u' ---");

        var resultC = mangChuoi
            .Where(x => x.Contains(
                "u",
                StringComparison.OrdinalIgnoreCase));

        foreach (var x in resultC)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
        Console.WriteLine(
           "\n--- Câu d: Bắt đầu bằng chữ in hoa ---");

        var resultD = mangChuoi
            .Where(x =>
                !string.IsNullOrEmpty(x) &&
                char.IsUpper(x[0]));

        foreach (var x in resultD)
        {
            Console.Write($"{x} ");
        }

        Console.WriteLine();
    }
}