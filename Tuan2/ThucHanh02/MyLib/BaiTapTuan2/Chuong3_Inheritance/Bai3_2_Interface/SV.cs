using MyLib.Chuong1_Basic.Bai1_1;

namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_2;
public class SV : SinhVien, IComparableObject
{
    public int CompareTo(object other)
    {
        SV sv = (SV)other;
        return this.SinhVienNamSinh.CompareTo(sv.SinhVienNamSinh);
    }
     public override string ToString()
    {
        return SinhVienHoten + " - " + SinhVienNamSinh;
    }
}