namespace MyLib.BaiTapTuan2.Chuong3_Inheritance.Bai3_2;
public class SapXep
{
    public static void Sort(object[] arr)
    {
        for(int i =0; i < arr.Length - 1; i++)
        {
            for(int j =i+1; j < arr.Length; j++)
            {
                IComparableObject a =(IComparableObject)arr[i];
                if (a.CompareTo(arr[j]) > 0)
                {
                    object t = arr[i];
                    arr[i] = arr[j];
                    arr[j] =t;
                }
            }
        }
    }
}