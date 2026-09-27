using System;
public class Mang1Chieu
{
    private int [] a;
    public Mang1Chieu()
    {
        a = new int[0];
    }
    public Mang1Chieu(int n)
    {
        a = new int[n];
    }
    public Mang1Chieu(Mang1Chieu x)
    {
        a = new int[x.a.Length];
        for(int i =0; i< x.a.Length; i++)
        {
            a[i] = x.a[i];
        }
    }
    public int this[int i]
    {
        get
        {
            return a[i];
        }
        set
        {
            a[i] = value;
        }

    }
    public int Count
    {
        get
        {
            return a.Length;
        }
    }
    public void nhap()
    {
        for(int i=0;i<a.Length;i++)
        {
            Console.Write("Nhap a[" + i + "]: ");
            a[i] = int.Parse(Console.ReadLine() ?? "0");
        }
    }
    public void Xuat()
    {
         for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }
    public Mang1Chieu TimSoChan()
    {
        Mang1Chieu ketqua = new Mang1Chieu();
        for(int i =0 ; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                ketqua.Them(a[i]);
            }
        }
        return ketqua;
    }
    public void Them(int x)
    {
        int[] temp = new int[a.Length + 1];

        for (int i = 0; i < a.Length; i++)
        {
            temp[i] = a[i];
        }

        temp[a.Length] = x;

        a = temp;
    }
}