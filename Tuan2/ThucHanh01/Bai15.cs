using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Collections.Generic;

class Bai15
{
    // Bài 15
      // Tạo List để lưu các phần tử của mảng
    List<int> a = new List<int>();
      // Hàm nhập các phần tử vào mảng
    public void nhapmang()
    {
        int n;
        // Nhập số lượng phần tử
        Console.WriteLine("nhap so phan tu: ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);
         // Nhập từng phần tử
        for(int i=0; i < n; i++)
        {
             // Thêm phần tử vào List
            a.Add(int.Parse(Console.ReadLine() ?? string.Empty));
        }
    }
     // Hàm xuất mảng và các kết quả
    public void xuatmang()
    {
          // Duyệt qua từng phần tử trong List
        for(int i=0; i<a.Count; i++)
        {
            Console.WriteLine(a[i] + " ");
        }
        // Tìm và xuất giá trị lớn nhất
        Console.WriteLine("max cua mang: "+TimMax());
           // Tìm và xuất giá trị nhỏ nhất
        Console.WriteLine("min cua mang: "+TimMin());
        // Tạo mảng chứa các số nguyên tố
        int[] nguyenTo = MangNguyenTo();
         // Xuất các số nguyên tố
        Console.Write("Mang so nguyen to: ");
         // Duyệt qua mảng số nguyên tố
        for(int i =0; i<nguyenTo.Length; i++)
        {
            Console.WriteLine(nguyenTo[i] + " ");
        }
        Console.WriteLine();
    }
     // Hàm tìm giá trị lớn nhất trong mảng
    public int TimMax()
    {
         // Lấy phần tử đầu tiên làm giá trị lớn nhất ban đầu
        int max=a[0];
        // Duyệt qua các phần tử trong List
        for(int i=0; i<a.Count; i++)
        {
              // Nếu phần tử hiện tại lớn hơn max
            if (a[i] > max)
            {
                // Cập nhật max
                max=a[i];
            }
        }
        // Trả về giá trị lớn nhất
        return max;
    }
      // Hàm tìm giá trị nhỏ nhất trong mảng
    public int TimMin()
    {
        // Lấy phần tử đầu tiên làm giá trị nhỏ nhất ban đầu
        int min=a[0];
        // Duyệt qua các phần tử trong List
        for(int i=0; i<a.Count; i++)
        {
              // Nếu phần tử hiện tại nhỏ hơn min
            if (a[i] < min)
            {
                 // Cập nhật min
                min=a[i];
            }
        }
          // Trả về giá trị nhỏ nhất
        return min;
    }
    // Hàm kiểm tra số nguyên tố
    public bool SoNguyenTo(int n)
    {
        if(n<2) return false;
        if(n==2) return true;
        for(int i=2; i <= Math.Sqrt(n); i++)
        {
            if(n%i==0)
            return false;
        }
        return true;
    }
      // Hàm tạo mảng chỉ chứa các số nguyên tố
    public int [] MangNguyenTo()
    {
         // Tạo List để lưu các số nguyên tố
        List<int> Ketqua = new List<int>();
          // Duyệt qua tất cả phần tử của mảng a
        for(int i=0; i < a.Count; i++)
        {
             // Kiểm tra phần tử có phải số nguyên tố không
            if (SoNguyenTo(a[i]))
            {
                // Nếu là số nguyên tố thì thêm vào Ketqua
                Ketqua.Add(a[i]);
            }
        }
         // Chuyển List thành mảng int[]
        return Ketqua.ToArray();
    }
}