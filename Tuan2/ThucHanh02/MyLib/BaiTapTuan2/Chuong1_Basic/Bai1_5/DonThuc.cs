using System;
public class DonThuc
{
    private double a;
    private int n;
    public DonThuc()
    {
        a = 0;
        n =0;
    }
     public DonThuc(double a, int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Số mũ phải >= 0");
        }

        this.a = a;
        this.n = n;
    }
    public double TinhDonThuc(double x )
    {
        return a*Math.Pow(x,n);
    }
    public DonThuc DaoHam()
    {
        if (n == 0)
        {
            return new DonThuc(0,0);
        }
        return new DonThuc(a*n,n-1);
 
    }
    public override string ToString()
    {
        return $"{a}x^{n}";
    }
}