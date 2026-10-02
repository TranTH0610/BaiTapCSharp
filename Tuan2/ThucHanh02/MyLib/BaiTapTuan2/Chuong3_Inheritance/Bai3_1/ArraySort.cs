using MyLib.Chuong1_Basic.Bai1_1;

namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_1;

public class ArraySort : SinhVien, IComparable<ArraySort>
{
    public int CompareTo(ArraySort? other)
    {
        if (other == null)
            return 1;

        return this.SinhVienNamSinh.CompareTo(other.SinhVienNamSinh);
    }
}