using System;

namespace Bai1
{
    internal class GiaiPhuongTrinhBac2
    {public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Giải phương trình bậc nhất: ax + b = 0
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    return "Phương trình có vô số nghiệm.";
                }
                else
                {
                    return "Phương trình vô nghiệm.";
                }
            }

            double x = -B / A;

            return "Phương trình có nghiệm x = " + x;
        }

        // Giải phương trình bậc hai: ax² + bx + c = 0
        public string GiaiBacHai()
        {
            // Nếu a = 0 thì phương trình trở thành bậc nhất
            if (A == 0)
            {
                return GiaiBacNhat();
            }

            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return "Phương trình vô nghiệm.";
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);

                return "Phương trình có nghiệm kép x = " + x;
            }
            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);

                return "Phương trình có 2 nghiệm:"
                     + Environment.NewLine
                     + "x1 = " + x1
                     + Environment.NewLine
                     + "x2 = " + x2;
            }
        }
    }
}