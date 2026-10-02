using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using BaiThucHanhLINQ.Data;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai5_2
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 5.2 - THỐNG KÊ LIST<MONHOC>");
        Console.WriteLine("========================================");

        var dsMon = DuLieu.DS_Mon();

        Console.WriteLine(
            "\n--- Câu a: Tổng số môn ---");

        Console.WriteLine(
            $"Tổng số môn: {dsMon.Count()}");
        Console.WriteLine(
       "\n--- Câu b: Môn bắt đầu bằng 'Lập trình' ---");
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
          "\n--- Câu c: Tổng số tiết hệ KTV ---");

        int tongTietKTV = dsMon
        .Where(mon => mon.He == "KTV")
        .Sum(mon => mon.SoTiet);
        Console.WriteLine(
         $"Tổng số tiết KTV: {tongTietKTV}");
        Console.WriteLine(
        "\n--- Câu d: Tổng số môn của mỗi hệ ---");
        var thongKeHe = dsMon
        .GroupBy(mon => mon.He)
        .Select(group => new
        {
            He = group.Key,
            TongSoMon = group.Count()
        } )
        .OrderBy (x => x.He );
        foreach (var item in thongKeHe)
        {
            Console.WriteLine(
                $"Hệ: {item.He} | Tổng số môn: {item.TongSoMon}");
        }
          Console.WriteLine(
            "\n--- Câu e: Nhóm theo Số tiết ---");

        var thongKeSoTiet = dsMon
            .GroupBy(mon => mon.SoTiet)
            .Select(group => new
            {
                SoTiet = group.Key,
                TongSoMon = group.Count()
            })
            .OrderByDescending(x => x.SoTiet);

        foreach (var item in thongKeSoTiet)
        {
            Console.WriteLine(
                $"Số tiết: {item.SoTiet} | " +
                $"Tổng số môn: {item.TongSoMon}");
        }
          Console.WriteLine(
            "\n--- Câu f: Môn có số tiết cao nhất ---");

        byte maxTiet = dsMon
            .Max(mon => mon.SoTiet);

        var monMaxTiet = dsMon
            .Where(mon => mon.SoTiet == maxTiet);

        foreach (var mon in monMaxTiet)
        {
            Console.WriteLine(mon);
        }
          Console.WriteLine(
            "\n--- Câu g: Thống kê theo Hệ ---");

        var thongKeTheoHe = dsMon
            .GroupBy(mon => mon.He)
            .Select(group => new
            {
                He = group.Key,
                TongSoMon = group.Count(),
                TongSoTiet = group.Sum(mon => mon.SoTiet),
                SoTietCaoNhat = group.Max(mon => mon.SoTiet),
                SoTietThapNhat = group.Min(mon => mon.SoTiet)
            })
            .OrderBy(x => x.He);

        foreach (var item in thongKeTheoHe)
        {
            Console.WriteLine(
                $"Hệ: {item.He}");

            Console.WriteLine(
                $"  Tổng số môn: {item.TongSoMon}");

            Console.WriteLine(
                $"  Tổng số tiết: {item.TongSoTiet}");

            Console.WriteLine(
                $"  Cao nhất: {item.SoTietCaoNhat}");

            Console.WriteLine(
                $"  Thấp nhất: {item.SoTietThapNhat}");
        }
         Console.WriteLine(
            "\n--- Câu h: Các môn phân nhóm theo Hệ ---");

        var nhomTheoHe = dsMon
            .GroupBy(mon => mon.He)
            .OrderBy(group => group.Key);

        foreach (var group in nhomTheoHe)
        {
            Console.WriteLine(
                $"\nHệ: {group.Key}");

            foreach (var mon in group)
            {
                Console.WriteLine($"  {mon}");
            }
        }
          Console.WriteLine(
            "\n--- Câu i: Phân nhóm theo Số tiết ---");

        var nhomTheoTiet = dsMon
            .GroupBy(mon => mon.SoTiet)
            .OrderBy(group => group.Key);

        foreach (var group in nhomTheoTiet)
        {
            Console.WriteLine(
                $"\nSố tiết: {group.Key}");

            foreach (var mon in group)
            {
                Console.WriteLine($"  {mon}");
            }
        }

        Console.WriteLine(
            "\n--- Câu j: Hệ KTV theo HP2, HP3, HP4, HP5 ---");

        var nhomHocPhan = dsMon
            .Where(mon => mon.He == "KTV")
            .Where(mon =>
                mon.MaMon.StartsWith("HP2") ||
                mon.MaMon.StartsWith("HP3") ||
                mon.MaMon.StartsWith("HP4") ||
                mon.MaMon.StartsWith("HP5"))
            .GroupBy(mon => mon.MaMon.Substring(0, 3))
            .OrderBy(group => group.Key);

        foreach (var group in nhomHocPhan)
        {
            Console.WriteLine(
                $"\nHọc phần: {group.Key}");

            var danhSach = group
                .OrderBy(mon => mon.MaMon);

            foreach (var mon in danhSach)
            {
                Console.WriteLine($"  {mon}");
            }
        }
         Console.WriteLine(
            "\n--- Câu k: Nhóm theo Hệ, Số tiết > 40 ---");

        var nhomHeHon40 = dsMon
            .Where(mon => mon.SoTiet > 40)
            .GroupBy(mon => mon.He)
            .OrderBy(group => group.Key);

        foreach (var group in nhomHeHon40)
        {
            Console.WriteLine(
                $"\nHệ: {group.Key}");

            foreach (var mon in group.OrderBy(
                mon => mon.MaMon))
            {
                Console.WriteLine($"  {mon}");
            }
        }
    }
}
