using System;
using System.IO;
using Xunit;
using MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_4;

namespace MyLib.Tests;

public class Bai3_4Test
{
    // ==========================================
    // TEST 1: KIỂM TRA KẾ THỪA
    // ==========================================

    [Fact]
    public void KiemTraKeThua()
    {
        PTBac2Console app = new PTBac2Console();

        Assert.IsAssignableFrom<ConsoleMenu>(app);
    }


    // ==========================================
    // TEST 2: KIỂM TRA EVENT ĐƯỢC GỌI
    // ==========================================

    [Fact]
    public void KiemTraEventDuocGoi()
    {
        PTBac2Console app = new PTBac2Console();

        bool daGoi = false;

        void TestHandler(int choice)
        {
            daGoi = true;
        }

        app.Choose += TestHandler;

        // Gọi Event
        app.XuLyLuaChon(1);

        Assert.True(daGoi);

        app.Choose -= TestHandler;
    }


    // ==========================================
    // TEST 3: EVENT NHẬN ĐÚNG GIÁ TRỊ
    // ==========================================

    [Fact]
    public void KiemTraEventNhanDungChoice()
    {
        PTBac2Console app = new PTBac2Console();

        int choiceNhanDuoc = 0;

        void TestHandler(int choice)
        {
            choiceNhanDuoc = choice;
        }

        app.Choose += TestHandler;

        app.XuLyLuaChon(5);

        Assert.Equal(5, choiceNhanDuoc);

        app.Choose -= TestHandler;
    }


    // ==========================================
    // TEST 4: PHƯƠNG TRÌNH CÓ 2 NGHIỆM
    // x² - 3x + 2 = 0
    // x1 = 2, x2 = 1
    // ==========================================

    [Fact]
    public void KiemTraHaiNghiem()
    {
        PTBac2Console app = new PTBac2Console();

        // Giả lập:
        // a = 1
        // b = -3
        // c = 2
        Console.SetIn(
            new StringReader("1\n-3\n2\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains("x1 = 2", ketQua);
        Assert.Contains("x2 = 1", ketQua);
    }


    // ==========================================
    // TEST 5: NGHIỆM KÉP
    // x² - 2x + 1 = 0
    // x = 1
    // ==========================================

    [Fact]
    public void KiemTraNghiemKep()
    {
        PTBac2Console app = new PTBac2Console();

        Console.SetIn(
            new StringReader("1\n-2\n1\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains(
            "Phương trình có nghiệm kép: x1 = x2 = 1",
            ketQua
        );
    }


    // ==========================================
    // TEST 6: VÔ NGHIỆM
    // x² + x + 1 = 0
    // Delta < 0
    // ==========================================

    [Fact]
    public void KiemTraVoNghiem()
    {
        PTBac2Console app = new PTBac2Console();

        Console.SetIn(
            new StringReader("1\n1\n1\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains(
            "Phương trình vô nghiệm.",
            ketQua
        );
    }


    // ==========================================
    // TEST 7: a = 0
    // 2x - 4 = 0
    // x = 2
    // ==========================================

    [Fact]
    public void KiemTraPhuongTrinhBacNhat()
    {
        PTBac2Console app = new PTBac2Console();

        Console.SetIn(
            new StringReader("0\n2\n-4\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains(
            "Phương trình có một nghiệm: x = 2",
            ketQua
        );
    }


    // ==========================================
    // TEST 8: a = 0, b = 0, c != 0
    // VÔ NGHIỆM
    // ==========================================

    [Fact]
    public void KiemTraVoNghiemKhiABang0()
    {
        PTBac2Console app = new PTBac2Console();

        Console.SetIn(
            new StringReader("0\n0\n5\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains(
            "Phương trình vô nghiệm.",
            ketQua
        );
    }


    // ==========================================
    // TEST 9: a = 0, b = 0, c = 0
    // VÔ SỐ NGHIỆM
    // ==========================================

    [Fact]
    public void KiemTraVoSoNghiem()
    {
        PTBac2Console app = new PTBac2Console();

        Console.SetIn(
            new StringReader("0\n0\n0\n")
        );

        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.GiaiPhuongTrinhBac2();

        string ketQua = output.ToString();

        Assert.Contains(
            "Phương trình có vô số nghiệm.",
            ketQua
        );
    }


    // ==========================================
    // TEST 10: CHỨC NĂNG KHÔNG TỒN TẠI
    // ==========================================

    [Fact]
    public void KiemTraChucNangKhongTonTai()
    {
        PTBac2Console app = new PTBac2Console();

        // Chuyển Console output sang bộ nhớ
        StringWriter output = new StringWriter();
        Console.SetOut(output);

        app.XuLyChucNang(99);

        string ketQua = output.ToString();

        Assert.Contains(
            "Chức năng không tồn tại!",
            ketQua
        );
    }
}