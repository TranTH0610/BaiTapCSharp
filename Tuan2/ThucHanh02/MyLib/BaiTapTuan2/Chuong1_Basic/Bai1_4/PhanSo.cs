using System;
public class PhanSo
{
    private int Mau;
    private int Tu;
    public PhanSo()
    {
        Mau = 1;
        Tu = 0;
    }
    public PhanSo(int Tu, int Mau)
    {
        if (Mau == 0)
        {
            throw new ArgumentException("Mau so khong duoc bang 0!");
        }
        this.Tu = Tu;
        this.Mau = Mau;
        RutGon();
    }
    public PhanSo(PhanSo p)
    {
        Mau = p.Mau;
        Tu = p.Tu;
    }
    private void RutGon()
    {
        int a = Math.Abs(Tu);
        int b = Math.Abs(Mau);
        while (b != 0)
        {
            int t = a % b;
            a = b;
            b = t;
        }
        if (a != 0)
        {
            Tu /= a;
            Mau /= a;
        }
        if (Mau < 0)
        {
            Tu = -Tu;
            Mau = -Mau;

        }
    }
    // OVERRIDE TOSTRING()
    // Override ToString() 
    public override string ToString()
    {
        if (Mau == 1)
        { return Tu.ToString(); }
        return $"{Tu}/{Mau}";
    }
}