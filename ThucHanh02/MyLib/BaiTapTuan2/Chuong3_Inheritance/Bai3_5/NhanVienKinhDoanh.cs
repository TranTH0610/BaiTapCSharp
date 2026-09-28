namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_5;

public class NhanVienKinhDoanh : NhanVien3_5
{
    private double luongCoBan;
    private int soHopDong;

    public NhanVienKinhDoanh()
        : base()
    {
        luongCoBan = 0;
        soHopDong = 0;
    }

    public NhanVienKinhDoanh(
        string maNV,
        string hoTen,
        double luongCoBan,
        int soHopDong)
        : base(maNV, hoTen)
    {
        this.luongCoBan = luongCoBan;
        this.soHopDong = soHopDong;
    }

    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value; }
    }

    public int SoHopDong
    {
        get { return soHopDong; }
        set { soHopDong = value; }
    }

    // Tính lương nhân viên kinh doanh
    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }
}