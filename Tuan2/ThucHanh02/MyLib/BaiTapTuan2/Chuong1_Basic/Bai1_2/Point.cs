using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Point
{
    private double x;
    private double y;
    public Point()
    {
        x =0;
        y =0;
    }
    public Point(double x, double y)
    {
        this.x =x;
        this.y =y;
    }

    public double Pointx
    {
        get{return x;}
        set{x=value;}
    }
     // PROPERTY
    public double Pointy
    {
        get{return y;}
        set{y=value;}
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap x: ");
        x=int.Parse(Console.ReadLine()??string.Empty);
         Console.WriteLine("Nhap y: ");
        y=int.Parse(Console.ReadLine()??string.Empty);
    }
    public void Xuat()
    {
         Console.WriteLine(x + "," + y);
    }
    // OVERRIDE TOSTRING
    public override string ToString()
    {
         return "(" + x + ", " + y + ")";
    }
    // PHÉP +
    public static Point operator +(Point A, Point B)
    {
        return new Point(A.Pointx + B.Pointx, A.Pointy + B.Pointy);
    }
    // PHÉP -
    public static Point operator -(Point A, Point B)
    {
        return new Point(A.Pointx -B.Pointx, A.Pointy - B.Pointy);
    }
    // LẤY ÂM
    public static Point operator -(Point A)
    {
        return new Point (-A.Pointx,-A.Pointy);
    }
    // Tính khoảng cách
    // Phương thức thành viên
    public double KhoangCach(Point A)
    {
        double dx = x- A.x;
        double dy = y - A.y;
        return Math.Sqrt(dx*dx +dy*dy);
    }
    // Phương thức tĩnh
    public static double KhoangCach(Point A, Point B)
    {
        double dx = A.x- B.x;
        double dy = A.y - B.y;
        return Math.Sqrt(dx*dx +dy*dy);
    }
    // Tính trung điểm
    // Phương thức thành viên
    public Point Trungdiem(Point A)
    {
        return new Point ((x+A.x)/2, (y+A.y)/2);
    }
    // Phương thức tĩnh
    public static Point TrungDiem(Point A, Point B)
    {
        return new Point ((A.x+B.x)/2, (A.y+B.y)/2);
    }
}