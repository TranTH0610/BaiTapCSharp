using System;
class Bai8
{
    // Bài 8
     // Hàm hoán vị 2 số nguyên a và b
    // ref giúp thay đổi trực tiếp giá trị của a và b bên ngoài hàm
    public static void HoanVi(ref int a, ref int b)
    {
         // Tạo biến tạm để lưu giá trị của a
        int temp =a;
        // Gán giá trị của b cho a
        a=b;
        // Gán giá trị ban đầu của a từ temp cho b
        b=temp;
    }
}