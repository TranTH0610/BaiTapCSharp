namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_6;

public class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public ThiSinhSieuCup()
        : base()
    {
        csdl = 0;
    }

    public ThiSinhSieuCup(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double csdl)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.csdl = csdl;
    }

    public double CSDL
    {
        get { return csdl; }
        set { csdl = value; }
    }

    public override double TinhTongDiem()
    {
        return bai1 + bai2 + bai3 + csdl;
    }
}