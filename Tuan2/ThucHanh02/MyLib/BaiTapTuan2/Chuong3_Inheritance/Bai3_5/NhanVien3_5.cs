namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_5;
public abstract class NhanVien3_5
{
    // Field
    protected string maNV;
    protected string hoTen;

    // Constructor
    public NhanVien3_5()
    {
        maNV = "";
        hoTen = "";
    }

    public NhanVien3_5(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    // Property
    public string MaNV
    {
        get { return maNV; }
        set { maNV = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    // Phương thức trừu tượng
    public abstract double TinhLuong();
}
