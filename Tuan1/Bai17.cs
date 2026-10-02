using System;
using System.Collections.Generic;
using System.Threading.Channels;
class Bai17
{
    // Bài 17
     // Khai báo mảng 2 chiều
    int [,] A;
     // n là số dòng, m là số cột
    int n,m;
      // Constructor nhận số dòng và số cột
    public Bai17(int n, int m)
    {
         // Gán số dòng
        this.n = n;
         // Gán số cột
        this.m = m;
         // Tạo mảng 2 chiều có n dòng và m cột
        A = new int[n,m];
    }
     // Hàm tạo các phần tử ngẫu nhiên cho mảng
    public void TaoMang()
    {
         // Tạo đối tượng Random để sinh số ngẫu nhiên
        Random rd = new Random();
         // Duyệt qua từng dòng
        for(int i= 0; i< n; i++)
        {
             // Duyệt qua từng cột
            for(int j =0; j<m; j++)
            {
                // Sinh số ngẫu nhiên từ 10 đến 100
                A[i,j]=rd.Next(10,101);
            }
        }
    }
     // Hàm lấy các số chẵn trong mảng
    public int [] mangChan()
    {
         // Tạo List để lưu các số chẵn
        List<int> chan = new List<int>();
          // Duyệt qua từng dòng
        for(int i=0; i<n; i++)
        {
             // Duyệt qua từng cột
            for(int j=0; j < m; j++)
            {
                 // Kiểm tra số hiện tại có phải số chẵn
                if (A[i, j] % 2 == 0)
                {
                     // Nếu là số chẵn thì thêm vào List
                    chan.Add(A[i,j]);
                }
            }
        }
         // Chuyển List thành mảng int[]
        return chan.ToArray();
    }
     // Hàm lấy các số lẻ trong mảng
    public int [] mangLe()
    {
        // Tạo List để lưu các số lẻ
        List<int> Le = new List<int>();
        // Duyệt qua từng dòng
        for(int i=0; i<n; i++)
        {
             // Duyệt qua từng cột
            for(int j=0; j < m; j++)
            {
                 // Kiểm tra số hiện tại có phải số lẻ
                if (A[i, j] % 2 != 0)
                {
                     // Nếu là số lẻ thì thêm vào List
                    Le.Add(A[i,j]);
                }
            }
        }
         // Chuyển List thành mảng int[]
        return Le.ToArray();
    }
    // Hàm xuất mảng
    public void xuatmang()
    {
        // Duyệt qua từng dòng
        for(int i =0; i < n; i++)
        {
             // Duyệt qua từng cột
            for(int j =0; j<m; j++)
            {
                // Xuất phần tử trong mảng
                Console.WriteLine(A[i,j]+" ");
            }
        }
        Console.WriteLine("-------------------------------------- ");
         // Lấy mảng các số chẵn
        int [] chan = mangChan();
         // Xuất tiêu đề mảng chẵn
         Console.WriteLine("Mang Chan:  ");
          // Duyệt và xuất các số chẵn
        for(int i =0; i < chan.Length; i++)
        {
        Console.WriteLine(chan[i]+" ");
        }
        Console.WriteLine("-------------------------------------- ");
         // Xuất tiêu đề mảng lẻ
        Console.WriteLine("Mang Le: ");
        // Lấy mảng các số lẻ
        int [] le = mangLe();
            // Duyệt và xuất các số lẻ
        for(int i =0; i < le.Length; i++)
        {
        Console.WriteLine(le[i]+" ");
        }

    }
}