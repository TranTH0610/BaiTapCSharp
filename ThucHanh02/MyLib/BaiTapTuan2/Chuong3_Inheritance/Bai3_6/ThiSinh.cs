namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_6;

public abstract class ThiSinh
{
    // Thông tin chung
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    public ThiSinh()
    {
        sbd = "";
        hoTen = "";
        bai1 = 0;
        bai2 = 0;
        bai3 = 0;
    }

    public ThiSinh(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3)
    {
        this.sbd = sbd;
        this.hoTen = hoTen;
        this.bai1 = bai1;
        this.bai2 = bai2;
        this.bai3 = bai3;
    }

    public string SBD
    {
        get { return sbd; }
        set { sbd = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double Bai1
    {
        get { return bai1; }
        set { bai1 = value; }
    }

    public double Bai2
    {
        get { return bai2; }
        set { bai2 = value; }
    }

    public double Bai3
    {
        get { return bai3; }
        set { bai3 = value; }
    }

    // Mỗi loại thí sinh có cách tính điểm khác nhau
    public abstract double TinhTongDiem();
}