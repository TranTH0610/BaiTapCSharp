namespace MyLib.Tests;

using Xunit;


public class Bai1_4Test
{
    [Fact]
    public void TuBang0_KetQuaBang0()
    {
        PhanSo p = new PhanSo(0, 5);

        string ketQua = p.ToString();

        Console.WriteLine("Input: 0/5");
        Console.WriteLine("Kết quả: " + ketQua);
        Console.WriteLine("Mong đợi: 0");

        Assert.Equal("0", ketQua);
    }

    [Fact]
    public void MauAm_DuaDauAmLenTu()
    {
        PhanSo p = new PhanSo(1, -2);

        string ketQua = p.ToString();

        Console.WriteLine("Input: 1/-2");
        Console.WriteLine("Kết quả: " + ketQua);
        Console.WriteLine("Mong đợi: -1/2");

        Assert.Equal("-1/2", ketQua);
    }

    [Fact]
    public void TuVaMauDeuAm_KetQuaDuong()
    {
        PhanSo p = new PhanSo(-2, -4);

        string ketQua = p.ToString();

        Console.WriteLine("Input: -2/-4");
        Console.WriteLine("Kết quả: " + ketQua);
        Console.WriteLine("Mong đợi: 1/2");

        Assert.Equal("1/2", ketQua);
    }

    [Fact]
    public void PhanSoChuaToiGian_TuDongRutGon()
    {
        PhanSo p = new PhanSo(10, 20);

        string ketQua = p.ToString();

        Console.WriteLine("Input: 10/20");
        Console.WriteLine("Kết quả: " + ketQua);
        Console.WriteLine("Mong đợi: 1/2");

        Assert.Equal("1/2", ketQua);
    }
}
