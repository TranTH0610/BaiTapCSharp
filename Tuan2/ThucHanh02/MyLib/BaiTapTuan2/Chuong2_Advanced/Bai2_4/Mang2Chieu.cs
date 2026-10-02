using System;
using System.Drawing;
public class Mang2Chieu
{
    private int [,]a;
    public Mang2Chieu()
    {
        a = new int[0,0];
    }
    public Mang2Chieu(int n, int m)
    {
        a = new int[n,m];
    }
    public Mang2Chieu( Mang2Chieu other)
    {
        int n = other.a.GetLength(0);
        int m = other.a.GetLength(1);
         a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = other.a[i, j];
            }
        }
    }
    public int this[int i, int j]
    {
        get
        {
            return a[i,j];
        }
        set
        {
            a[i,j]= value;
        }
    }
    public int Dong
    {
        get
        {
            return a.GetLength(0);
        }
    }
    public int cot
    {
        get
        {
            return a.GetLength(1);
        }
    }
    public void nhap()
    {
        for(int i=0; i < Dong; i++)
        {
            for(int j=0; j< cot; j++)
            {
                 Console.Write("Nhap a[" + i + "," + j + "]: ");
                a[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }
    }
    public void xuat()
    {
        for (int i = 0; i < Dong; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
    private bool SoNguyenTo(int x)
    {
        if (x < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }
    public void TimSoNguyenTo()
    {
        Console.Write("Cac so nguyen to trong mang: ");
        bool LaSoNguyenTo = false;
        for (int i = 0; i < Dong; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                if (SoNguyenTo(a[i, j]))
                {
                    Console.Write(a[i, j] + " ");
                    LaSoNguyenTo = true;
                }
            }
        }
        if (!LaSoNguyenTo)
        {
            Console.Write("Khong co");
        }

        Console.WriteLine();
    }

}