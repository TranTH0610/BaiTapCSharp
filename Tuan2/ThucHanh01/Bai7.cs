using System;
class Bai7
{
    //Bài 7
    // phương thức trả về kiểu bool
    public static bool KiemtraNguyenTo( int n)
    {
        // n nhỏ hơn 2 thì trả về false
        if(n<2) return false;
        // 2 là số nguyên tố
        if(n==2) return true;
         // Kiểm tra các ước từ 2 đến căn bậc 2 của n
        for(int i=2; i<=Math.Sqrt(n); i++)
        {
             // Nếu n chia hết cho i thì n không phải số nguyên tố
            if(n%i==0) return false;
        }
         // Không tìm thấy ước nào nên n là số nguyên tố
        return true;
    }
}