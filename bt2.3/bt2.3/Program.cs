using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Bai2_3
{
    public class Point
    {
        private double x;
        private double y;
        private string color;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Point(double x, double y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public void Move(double dx, double dy)
        {
            this.x += dx; this.y += dy;
        }
        public double kcgoc()
        {
            return Math.Sqrt(x * x + y * y);
        }

      
        public double kc(Point p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }
    }
    public class Program
    {

        private Point[] _ds;
        private int _size;
        public Point[] DS
        {
            get { return _ds; }
            set { _ds = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        static void Main()
        {
            Program p = new Program();
            Console.WriteLine("nhap so doi tuong diem:");
            p.Size = int.Parse(Console.ReadLine());
            p.DS = new Point[p.Size];
            for (int i = 0; i < p.Size; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                Console.WriteLine("nhap x:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("nhap y:");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("nhap mau sac:");
                string color = Console.ReadLine();
                p.DS[i] = new Point(x, y, color);
            }
            Console.WriteLine("Xuat:");
            for (int i = 0; i < p.Size; i++)
            {
                Console.WriteLine(+p.DS[i].X + "," + p.DS[i].Y + "," + p.DS[i].Color);
            }
            //tim diem cach xa goc toa do
            
            Point max = p.DS[0];
            for (int i = 1; i < p.Size; i++)
            {
                if (p.DS[i].kcgoc() > max.kcgoc())
                {
                    max = p.DS[i];
                }
            }
            Console.WriteLine("diem cach xa goc nhat:"+max.X+","+max.Y);
            //tim cap diem gan nhau nhat
            double min = p.DS[0].kc(p.DS[1]);
            Point p1=p.DS[0];
            Point p2=p.DS[1];
            for (int i = 0; i < p.Size - 1; i++) {
                for (int j = i + 1; j < p.Size; j++) {
                    double d = p.DS[i].kc(p.DS[j]);
                    if (d < min)
                    {
                        min = d;
                        p1 = p.DS[i];
                        p2 = p.DS[j];
                    }
                }
            }
            Console.WriteLine("cap diem gan nhau nhat:("+p1.X+","+p1.Y+"/"+p2.X+","+p2.Y+")");

        }
    }
}
           
        
      





   