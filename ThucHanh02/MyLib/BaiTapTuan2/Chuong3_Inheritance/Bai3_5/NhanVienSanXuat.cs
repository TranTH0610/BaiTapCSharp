namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_5;

public class NhanVienSanXuat : NhanVien3_5
{
    private int soSanPham;

    public NhanVienSanXuat()
        : base()
    {
        soSanPham = 0;
    }

    public NhanVienSanXuat(
        string maNV,
        string hoTen,
        int soSanPham)
        : base(maNV, hoTen)
    {
        this.soSanPham = soSanPham;
    }

    public int SoSanPham
    {
        get { return soSanPham; }
        set { soSanPham = value; }
    }

    // Tính lương nhân viên sản xuất
    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        // Nếu trên 3000 sản phẩm
        // được thưởng thêm 5%
        if (soSanPham > 3000)
        {
            luong = luong * 1.05;
        }

        return luong;
    }
}