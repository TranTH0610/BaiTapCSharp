using Xunit;

namespace MyLib.Tests;

public class Bai1_2Test
{
    // =========================
    // 1. CONSTRUCTOR MẶC ĐỊNH
    // =========================
    [Fact]
    public void ConstructorMacDinh()
    {
        Point p = new Point();

        Assert.Equal(0, p.Pointx);
        Assert.Equal(0, p.Pointy);
    }

    // =========================
    // 2. CONSTRUCTOR CÓ THAM SỐ
    // =========================
    [Fact]
    public void ConstructorCoThamSo()
    {
        Point p = new Point(3, 4);

        Assert.Equal(3, p.Pointx);
        Assert.Equal(4, p.Pointy);
    }

    // =========================
    // 3. PROPERTY
    // =========================
    [Fact]
    public void TestProperty()
    {
        Point p = new Point();

        p.Pointx = 10;
        p.Pointy = 20;

        Assert.Equal(10, p.Pointx);
        Assert.Equal(20, p.Pointy);
    }

    // =========================
    // 4. TOSTRING
    // =========================
    [Fact]
    public void TestToString()
    {
        Point p = new Point(3, 4);

        Assert.Equal("(3, 4)", p.ToString());
    }

    // =========================
    // 5. PHÉP CỘNG +
    // =========================
    [Fact]
    public void CongHaiDiem()
    {
        Point A = new Point(2, 3);
        Point B = new Point(4, 5);

        Point C = A + B;

        Assert.Equal(6, C.Pointx);
        Assert.Equal(8, C.Pointy);
    }

    // =========================
    // 6. PHÉP TRỪ -
    // =========================
    [Fact]
    public void TruHaiDiem()
    {
        Point A = new Point(6, 8);
        Point B = new Point(2, 3);

        Point C = A - B;

        Assert.Equal(4, C.Pointx);
        Assert.Equal(5, C.Pointy);
    }

    // =========================
    // 7. LẤY ÂM ĐIỂM
    // =========================
    [Fact]
    public void LayAmDiem()
    {
        Point A = new Point(3, -4);

        Point B = -A;

        Assert.Equal(-3, B.Pointx);
        Assert.Equal(4, B.Pointy);
    }

    // =========================
    // 8. KHOẢNG CÁCH - MEMBER
    // =========================
    [Fact]
    public void KhoangCachThanhVien()
    {
        Point A = new Point(0, 0);
        Point B = new Point(3, 4);

        double ketQua = A.KhoangCach(B);

        Assert.Equal(5, ketQua);
    }

    // =========================
    // 9. KHOẢNG CÁCH - STATIC
    // =========================
    [Fact]
    public void KhoangCachTinh()
    {
        Point A = new Point(0, 0);
        Point B = new Point(3, 4);

        double ketQua = Point.KhoangCach(A, B);

        Assert.Equal(5, ketQua);
    }

    // =========================
    // 10. TRUNG ĐIỂM - MEMBER
    // =========================
    [Fact]
    public void TrungDiemThanhVien()
    {
        Point A = new Point(2, 4);
        Point B = new Point(6, 8);

        Point C = A.Trungdiem(B);

        Assert.Equal(4, C.Pointx);
        Assert.Equal(6, C.Pointy);
    }

    // =========================
    // 11. TRUNG ĐIỂM - STATIC
    // =========================
    [Fact]
    public void TrungDiemTinh()
    {
        Point A = new Point(2, 4);
        Point B = new Point(6, 8);

        Point C = Point.TrungDiem(A, B);

        Assert.Equal(4, C.Pointx);
        Assert.Equal(6, C.Pointy);
    }

    // =========================
    // 12. TEST KHOẢNG CÁCH ĐIỂM TRÙNG NHAU
    // =========================
    [Fact]
    public void KhoangCachHaiDiemTrungNhau()
    {
        Point A = new Point(5, 5);
        Point B = new Point(5, 5);

        double ketQua = A.KhoangCach(B);

        Assert.Equal(0, ketQua);
    }
}