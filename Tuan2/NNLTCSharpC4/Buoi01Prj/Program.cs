using Mylib;
namespace Buoi01Prj;
public class GiaiPTBac2
{
public static void Main(string[] args)
{
double x1 = 0, x2 = 0;
int sn = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
Console.WriteLine($"So nghiem: {sn}");
Console.WriteLine($"x1 = {x1}");
Console.WriteLine($"x2 = {x2}");
}
}
public class Program1
{
public static void Main(string[] args)
{
Console.WriteLine("Main 1");
}
}
public class Program2
{
public static void Main(string[] args)
{
Console.WriteLine("Main 2");
}
class Program
{
static void Main(string[] args)
{
Bai1.Run();
// Bai2.Run();
}
}
class Bai1
{
public static void Run()
{
Console.WriteLine("Chay bai 1");
}
}
}
