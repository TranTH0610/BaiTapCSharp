using System;
using System.Linq;
using BaiThucHanhLINQ.Data;

namespace BaiThucHanhLINQ.Exercises;

public static class Bai6_2
{
    public static void Run()
    {
        Console.WriteLine("\n========================================");
        Console.WriteLine("BÀI 6.2 - JOIN HAI NGUỒN DỮ LIỆU");
        Console.WriteLine("========================================");

        var dsMon = DuLieu.DS_Mon();
        var dsHe = DuLieu.DS_He();
         Console.WriteLine(
            "\n--- Câu a: INNER JOIN ---");
        var resultA = 
        from he in dsHe
        join mon in dsMon
        on he.MaHe equals mon.He
        select new
        {
            he.TenHe,
            mon.MaMon,
            mon.TenMon
        };
          foreach (var item in resultA)
        {
            Console.WriteLine(
                $"Hệ: {item.TenHe} | " +
                $"Mã môn: {item.MaMon} | " +
                $"Tên môn: {item.TenMon}");
        }
         Console.WriteLine(
            "\n--- Câu b: LEFT OUTER JOIN ---");

        var resultB =
            from he in dsHe
            join mon in dsMon
                on he.MaHe equals mon.He
                into danhSachMon
            from mon in danhSachMon.DefaultIfEmpty()
            select new
            {
                he.MaHe,
                he.TenHe,
                Mon = mon
            };
              foreach (var item in resultB)
        {
            if (item.Mon == null)
            {
                Console.WriteLine(
                    $"Hệ: {item.MaHe} - {item.TenHe} " +
                    $"| Chưa có môn học");
            }
            else
            {
                Console.WriteLine(
                    $"Hệ: {item.MaHe} - {item.TenHe} " +
                    $"| {item.Mon.MaMon} - {item.Mon.TenMon}");
            }
        }
         Console.WriteLine(
            "\n--- Câu c: Hệ chưa có môn + môn chưa khai báo hệ ---");

        // Các hệ có môn
        var heCoMon = dsMon
            .Where(mon => !string.IsNullOrEmpty(mon.He))
            .Select(mon => mon.He)
            .Distinct();

        // Hệ chưa có môn
        var heChuaCoMon = dsHe
            .Where(he => !heCoMon.Contains(he.MaHe));

        Console.WriteLine("\nCác hệ chưa có môn:");

        foreach (var he in heChuaCoMon)
        {
            Console.WriteLine(
                $"- {he.MaHe} - {he.TenHe}");
        }

        // Mã hệ đã khai báo
        var maHe = dsHe
            .Select(he => he.MaHe);

        // Môn chưa khai báo hệ
        var monChuaKhaiBaoHe = dsMon
            .Where(mon =>
                string.IsNullOrEmpty(mon.He) ||
                !maHe.Contains(mon.He));

        Console.WriteLine(
            "\nCác môn chưa khai báo hệ:");

        foreach (var mon in monChuaKhaiBaoHe)
        {
            Console.WriteLine(
                $"- {mon.MaMon} - {mon.TenMon}");
        }
         Console.WriteLine(
            "\n--- Câu d: Chỉ lấy các đối tượng không ghép được ---");

        Console.WriteLine("\nHệ chưa có môn:");

        foreach (var he in heChuaCoMon)
        {
            Console.WriteLine(
                $"- {he.MaHe} - {he.TenHe}");
        }

        Console.WriteLine(
            "\nMôn chưa khai báo hệ:");

        foreach (var mon in monChuaKhaiBaoHe)
        {
            Console.WriteLine(
                $"- {mon.MaMon} - {mon.TenMon}");
        }
        Console.WriteLine(
            "\n--- Câu e: 5 môn có số tiết cao nhất ---");

        var top5 =
            (from mon in dsMon
             join he in dsHe
                 on mon.He equals he.MaHe
             orderby mon.SoTiet descending
             select new
             {
                 TenHe = he.TenHe,
                 mon.MaMon,
                 mon.TenMon,
                 mon.SoTiet
             })
            .Take(5);

        foreach (var item in top5)
        {
            Console.WriteLine(
                $"Hệ: {item.TenHe} | " +
                $"Mã: {item.MaMon} | " +
                $"Môn: {item.TenMon} | " +
                $"Số tiết: {item.SoTiet}");
        }
        Console.WriteLine(
            "\n--- Câu f: Tổng số môn mỗi hệ ---");

        var tongMonMoiHe =
            from he in dsHe
            join mon in dsMon
                on he.MaHe equals mon.He
                into danhSachMon
            select new
            {
                he.MaHe,
                he.TenHe,
                TongSoMon = danhSachMon.Count()
            };

        foreach (var item in tongMonMoiHe)
        {
            Console.WriteLine(
                $"Mã hệ: {item.MaHe} | " +
                $"Tên hệ: {item.TenHe} | " +
                $"Tổng số môn: {item.TongSoMon}");
        }
         Console.WriteLine(
            "\n--- Câu g: Số loại Số tiết khác nhau ---");

        int soLoaiTiet = dsMon
            .Select(mon => mon.SoTiet)
            .Distinct()
            .Count();

        Console.WriteLine(
            $"Có {soLoaiTiet} loại số tiết khác nhau.");

        // In ra các loại số tiết
        var cacLoaiTiet = dsMon
            .Select(mon => mon.SoTiet)
            .Distinct()
            .OrderBy(x => x);

        Console.WriteLine("Các loại số tiết:");

        foreach (var tiet in cacLoaiTiet)
        {
            Console.Write($"{tiet} ");
        }

        Console.WriteLine();

        Console.WriteLine(
            "\n--- Câu h: Môn đầu tiên bắt đầu bằng 'Lập trình' ---");

        var monDauTien = dsMon
            .FirstOrDefault(mon =>
                mon.TenMon.StartsWith(
                    "Lập trình",
                    StringComparison.OrdinalIgnoreCase));

        if (monDauTien != null)
        {
            Console.WriteLine(monDauTien);
        }
        else
        {
            Console.WriteLine(
                "Không tìm thấy môn học.");
        }
         Console.WriteLine(
            "\n--- Câu i: Đánh số thứ tự trong từng hệ ---");

        var nhomTheoHe = dsHe
            .GroupJoin(
                dsMon,
                he => he.MaHe,
                mon => mon.He,
                (he, danhSachMon) => new
                {
                    he.MaHe,
                    he.TenHe,
                    DanhSachMon = danhSachMon
                        .OrderBy(mon => mon.MaMon)
                        .Select((mon, index) => new
                        {
                            STT = index + 1,
                            Mon = mon
                        })
                });

        foreach (var group in nhomTheoHe)
        {
            Console.WriteLine(
                $"\n===== {group.MaHe} - {group.TenHe} =====");

            foreach (var item in group.DanhSachMon)
            {
                Console.WriteLine(
                    $"{item.STT}. {item.Mon.MaMon} - " +
                    $"{item.Mon.TenMon} - " +
                    $"{item.Mon.SoTiet} tiết");
            }
        }
    }
}