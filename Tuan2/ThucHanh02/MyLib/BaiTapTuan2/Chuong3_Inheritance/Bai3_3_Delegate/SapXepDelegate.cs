namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_3;

// Delegate dùng để so sánh 2 đối tượng
public delegate int HamSoSanh(object a, object b);

public class SapXepDelegate
{
    // Hàm sắp xếp mảng tổng quát
    public static void Sort(object[] arr, HamSoSanh compare)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                // Gọi hàm so sánh được truyền vào
                if (compare(arr[i], arr[j]) > 0)
                {
                    object temp = arr[i];

                    arr[i] = arr[j];

                    arr[j] = temp;
                }
            }
        }
    }
}