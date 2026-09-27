using System;

public class DayPhanSo
{

    private PhanSo[] ds;
    public DayPhanSo()
    {
        ds = new PhanSo[0];
    }
    public DayPhanSo(int n)
    {
        ds = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            ds[i] = new PhanSo();
        }
    }

    public DayPhanSo(DayPhanSo other)
    {
        ds = new PhanSo[other.ds.Length];

        for (int i = 0; i < other.ds.Length; i++)
        {
            ds[i] = new PhanSo(other.ds[i]);
        }
    }


    public PhanSo this[int i]
    {
        get
        {
            return ds[i];
        }

        set
        {
            ds[i] = value;
        }
    }

    public int Count
    {
        get
        {
            return ds.Length;
        }
    }

    public void Xuat()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.Write(ds[i] + " ");
        }

        Console.WriteLine();
    }

    // Tính tổng
    public PhanSo Tong()
    {
        int tuSo = 0;
        int mauSo = 1;

        for (int i = 0; i < ds.Length; i++)
        {
            string s = ds[i].ToString();

            int tu;
            int mau;
            if (!s.Contains("/"))
            {
                tu = int.Parse(s);
                mau = 1;
            }
            else
            {
                string[] parts = s.Split('/');

                tu = int.Parse(parts[0]);
                mau = int.Parse(parts[1]);
            }
            tuSo = tuSo * mau + tu * mauSo;
            mauSo = mauSo * mau;
        }

        return new PhanSo(tuSo, mauSo);
    }
}