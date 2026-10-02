using System;
using System.Linq;
using BaiThucHanhLINQ.Data;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai5_1
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 5.1 - TRUY VẤN CƠ BẢN LIST<MONHOC>");
        Console.WriteLine("========================================");

        var dsMon = DuLieu.DS_Mon();
        Console.WriteLine(
           "\n--- Câu a: Tên môn bắt đầu bằng 'Lập trình' ---");
        var queryA =
        from mon in dsMon
        where mon.TenMon.StartsWith(
            "Lập Trình", StringComparison.OrdinalIgnoreCase)
        select mon;
        foreach (var mon in queryA)
        {
            Console.WriteLine(
                $"{mon.MaMon} - {mon.TenMon}");
        }
        Console.WriteLine(
          "\n--- Câu b: Hệ CD ---");
        var resultB =
        from mon in dsMon
        where mon.He == "CD"
        orderby mon.SoTiet descending, mon.MaMon
        select mon;
        foreach (var mon in resultB)
        {
            Console.WriteLine(mon);
        }
        Console.WriteLine(
            "\n--- Câu c: Tên môn chứa 'web' ---");
        var resultC = dsMon
        .Where(mon => mon.TenMon.Contains("web", StringComparison.OrdinalIgnoreCase))
        .Select(mon => new
        {
            mon.TenMon,
            mon.He
        });
        foreach (var mon in resultC)
        {
            Console.WriteLine(
                $"Tên môn: {mon.TenMon} | Hệ: {mon.He}");
        }
        Console.WriteLine(
            "\n--- Câu d: Hệ KTV ---");
        var queryD =
        from mon in dsMon
        where mon.He == "KTV"
        orderby mon.MaMon
        select mon;
            foreach (var mon in queryD)
        {
            Console.WriteLine(mon);
        }
    }
}