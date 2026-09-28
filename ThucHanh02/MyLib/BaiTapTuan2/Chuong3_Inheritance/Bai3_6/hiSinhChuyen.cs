namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_6;

public class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public ThiSinhChuyen()
        : base()
    {
        tiengAnh = 0;
    }

    public ThiSinhChuyen(
        string sbd,
        string hoTen,
        double bai1,
        double bai2,
        double bai3,
        double tiengAnh)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.tiengAnh = tiengAnh;
    }

    public double TiengAnh
    {
        get { return tiengAnh; }
        set { tiengAnh = value; }
    }

    public override double TinhTongDiem()
    {
        double tong = bai1 + bai2 + bai3;

        if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            tong += 1;
        }
        else if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            tong += 2;
        }

        return tong;
    }
}