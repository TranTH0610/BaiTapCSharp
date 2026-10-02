using System;
class Bai9
{
    // Bài 9
    // Hàm tìm giá trị lớn nhất và nhỏ nhất trong 3 số
     // out dùng để trả về 2 kết quả: max và min
    public static void MaxMin( out float max, out float min,
        float a,float b, float c)
    {
          // Gán a làm giá trị lớn nhất ban đầu
        max =a;
         // Gán a làm giá trị nhỏ nhất ban đầu
        min =a;
         // Nếu b lớn hơn max thì gán b cho max
        if(b>max) max=b;
         // Nếu c lớn hơn max thì gán c cho max
        if(c>max) max=c;
         // Nếu b nhỏ hơn min thì gán b cho min
        if(b<min) min =b;
         // Nếu c nhỏ hơn min thì gán c cho min
        if(c<min) min =c;
    }
}