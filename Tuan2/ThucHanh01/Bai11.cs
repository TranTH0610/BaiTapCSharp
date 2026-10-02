using System;
class Bai11
{
    // Bài 11
    // Hàm nghịch đảo chuỗi
     // Trả về chuỗi sau khi được đảo ngược
    public static string NghichDao(string s)
    {
        // Tạo chuỗi kết quả ban đầu là chuỗi rỗng
        string ketqua ="";
         // Duyệt chuỗi từ ký tự cuối về ký tự đầu
        for(int i = s.Length-1;i>=0; i--)
        {
               // Thêm từng ký tự vào chuỗi kết quả
            ketqua += s[i];
        }
         // Trả về chuỗi đã được nghịch đảo
        return ketqua;
    }
}