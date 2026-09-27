using System;
public class DaThuc
{
    private double[] a;
    public DaThuc()
    {
        a = new double[0];
    }
    public DaThuc(int n)
    {
        a = new double[n + 1];
    }
    public DaThuc(DaThuc other)
    {
        a = new double[other.a.Length];

        for (int i = 0; i < other.a.Length; i++)
        {
            a[i] = other.a[i];
        }
    }
     public double this[int i]
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
     public int Bac
    {
        get
        {
            return a.Length - 1;
        }
    }
     public void Nhap()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Nhap he so a[" + i + "]: ");
            a[i] = double.Parse(Console.ReadLine() ?? "0");
        }
    }
      public void Xuat()
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (i == 0)
            {
                Console.Write(a[i]);
            }
            else
            {
                Console.Write(" + " + a[i] + "x^" + i);
            }
        }

        Console.WriteLine();
    }
    public double TinhGiaTri(double x)
    {
        double ketQua = 0;

        for (int i = 0; i < a.Length; i++)
        {
            ketQua += a[i] * Math.Pow(x, i);
        }

        return ketQua;
    }
}