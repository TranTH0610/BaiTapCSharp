using System;
using System.Data;
class Bai16
{
    // Bài 16
     // Tạo List để lưu danh sách họ tên
    List<string> Hoten = new List<string>();
    public void nhapmanghoten()
    {
        // Hàm nhập danh sách họ tên
        int n;
         // Nhập số lượng họ tên
        Console.WriteLine("nhap so ho ten: ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);
          // Nhập từng họ tên
        for(int i =0; i<n; i++)
        {
            // Thêm họ tên vào List
            Hoten.Add(Console.ReadLine()??string.Empty);
        }
    }
    // Hàm sắp xếp danh sách họ tên theo tên
    public void sapxep()
    {
        // Vòng lặp thứ nhất
       for(int i=0; i < Hoten.Count-1; i++)
        {
            // Vòng lặp thứ hai để so sánh với các phần tử phía sau
            for(int j = i + 1; j < Hoten.Count; j++)
            {
                 // Lấy tên của người thứ i
                // LastIndexOf(' ') tìm vị trí dấu cách cuối cùng
                string ten1 = Hoten[i].Substring(Hoten[i].LastIndexOf(' ')+1);
                  // Lấy tên của người thứ j
                string ten2 = Hoten[j].Substring(Hoten[j].LastIndexOf(' ')+1);
                 // So sánh hai tên
                // Nếu ten1 đứng sau ten2 thì đổi chỗ
                if(string.Compare(ten1,ten2) >0)
                {
                    // Tạo biến tạm để lưu họ tên thứ i
                    string temp = Hoten[i];
                     // Đưa họ tên thứ j vào vị trí i
                    Hoten[i] = Hoten[j];
                     // Đưa họ tên ban đầu thứ i vào vị trí j
                    Hoten[j] = temp;
                }
            }
        }
    }
     // Hàm xuất danh sách họ tên
    public void xuatmanghoten()
    {
        // Duyệt qua toàn bộ danh sách
        for(int i=0; i< Hoten.Count; i++)
        {
            // Xuất từng họ tên
            Console.WriteLine(Hoten[i]);
        }
    }
}