using System;
class Program
{
    static void Main(string[] arg)
    {
        int p;
        do{
        Console.WriteLine("1. Bai 1");
        Console.WriteLine("2. Bai 2");
        Console.WriteLine("3. Bai 3");
        Console.WriteLine("4. Bai 4");
        Console.WriteLine("5. Bai 5");
        Console.WriteLine("6. Bai 6");
        Console.WriteLine("7. Bai 7");
        Console.WriteLine("8. Bai 8");
        Console.WriteLine("9. Bai 9");
        Console.WriteLine("10. Bai 10");
        Console.WriteLine("11. Bai 11");
        Console.WriteLine("12. Bai 12");
        Console.WriteLine("13. Bai 13");
        Console.WriteLine("14. Bai 14");
        Console.WriteLine("15. Bai 15");
        Console.WriteLine("16. Bai 16");
        Console.WriteLine("17. Bai 17");
        Console.WriteLine("0. thoat");
        Console.WriteLine("Nhap lua chon: ");
        p = int.Parse(Console.ReadLine()??string.Empty);
        switch (p)
        {
            case 1:
                {
                    bai1.HovaTen();
                }
                break;
            case 2:
                {
                    Bai2.NhapHoVaTen();
                }
                break;
            case 3:
                {
                    Console.WriteLine("ket qua x^y: "+ Bai3.TinhHaiSoNguyen());
                }
                break;
            case 4:
                {
                    Console.WriteLine("ket qua x^y: "+Bai4.TinhHaiSoNguyen());
                }
                break;
            case 5:
                {
                    Bai5.MENU();
                }
                break;
            case 6:
                    {
                        Console.WriteLine("so lon nhat la: "+Bai6.SolonNhat());
                    }
                    break;
            case 7:
                    {
                        int n;
                        Console.WriteLine("Nhap so: ");
                        n=int.Parse(Console.ReadLine()??string.Empty);
                        if(Bai7.KiemtraNguyenTo(n))
                        {
                            Console.WriteLine("n la so nguyen to");
                        }
                        else
                        {
                            Console.WriteLine("khong phai la so nguyen to");
                        }

                    }
                    break;
            case 8:
                    {
                        Console.WriteLine("Nhap so a: ");
                        int a=int.Parse(Console.ReadLine()??string.Empty);
                        Console.WriteLine("Nhap so b: ");
                        int b=int.Parse(Console.ReadLine()??string.Empty);
                        Console.WriteLine("truoc khi hoan vi:");
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                        Bai8.HoanVi(ref a, ref b);
                        Console.WriteLine("Sau khi hoan vi:");
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                    }
                    break;
            case 9:
                    {
                        float a,b,c;
                        float max,min;
                        Console.WriteLine("Nhap so a:  ");
                        a=float.Parse(Console.ReadLine()??string.Empty);
                        Console.WriteLine("Nhap so b: ");
                        b=float.Parse(Console.ReadLine()??string.Empty);
                        Console.WriteLine("Nhap so c: ");
                        c=float.Parse(Console.ReadLine()??string.Empty);
                        Bai9.MaxMin(out max, out min, a, b, c);
                        Console.WriteLine("max la: "+max);
                        Console.WriteLine("min la: "+min);

                    }
                    break;
            case 10:
                    {
                        Console.WriteLine("nhap chuoi: ");
                        string s = Console.ReadLine() ?? string.Empty;
                        if (Bai10.KiemTraDoiXung(s))
                        {
                            Console.WriteLine("chuoi doi xung");
                        }
                        else
                        {
                            Console.WriteLine("khong phai chuoi doi xung");
                        }
                    }
                    break;
            case 11:
                    {
                        Console.WriteLine("nhap chuoi: ");
                        string s = Console.ReadLine() ?? string.Empty;
                        Console.WriteLine("chuoi nghich dao la: "+Bai11.NghichDao(s));
                    }
                    break;
            case 12:
                    {
                        Console.WriteLine("nhap chuoi: ");
                        string s = Console.ReadLine() ?? string.Empty;
                        Bai12.XuLy(s);
                    }
                    break;
            case 13:
                    {
                        Bai13 sv = new Bai13();
                        sv.nhap();
                        Console.WriteLine("------------------------");
                        sv.xuat();
                    }
                    break;
            case 14:
                    {
                        Bai14 nv = new Bai14();
                        nv.nhap();
                        Console.WriteLine("------------------------");
                        nv.xuat();
                    }
                    break;
            case 15:
                    {
                        Bai15 b= new Bai15();
                        b.nhapmang();
                        Console.WriteLine("------------------------");
                        b.xuatmang();  
                    }
                    break;
            case 16:
                    {
                        Bai16 c = new Bai16();
                        c.nhapmanghoten();
                        c.sapxep();
                        Console.WriteLine("------------------------");
                        c.xuatmanghoten();
                    }
                    break;
            case 17:
                    {
                        int n,m;
                        Console.Write("Nhap n: ");
                        n = int.Parse(Console.ReadLine() ?? string.Empty);
                        Console.Write("Nhap m: ");
                        m = int.Parse(Console.ReadLine() ?? string.Empty);
                        Bai17 d = new Bai17(n,m);
                        d.TaoMang();
                        d.xuatmang();
                    }
                    break;
            case 0:
                    {
                        Console.WriteLine("ket thuc chuong trinh");
                    }
                    break;
            default:
            {
             Console.WriteLine("Lua chon khong hop le!");
            }
                    break;
        }
        Console.WriteLine();
        }while(p !=0);
    }
}