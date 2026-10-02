using System;
class Bai10
{
    // Bài 10
    // Hàm kiểm tra chuỗi có đối xứng hay không
     // Vị trí cuối của chuỗi
    public static bool KiemTraDoiXung(string s)
    {
         // Vị trí bắt đầu của chuỗi
        int dau = 0;
          // Vị trí cuối của chuỗi
        int cuoi = s.Length-1;
        // So sánh từ hai đầu vào giữa
        while (dau < cuoi)
        {
             // Nếu ký tự đầu và cuối khác nhau
            // thì chuỗi không đối xứng
            if (s[dau] != s[cuoi])
            {
                return false;
            }
              // Tăng vị trí đầu lên 1
            dau++;
              // Giảm vị trí cuối xuống 1
            cuoi--;
        }
          // Nếu không có ký tự nào khác nhau
        // thì chuỗi đối xứng
        return true;
    }
}