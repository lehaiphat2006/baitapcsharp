using System;
namespace bt2_4 {
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
        public void Xuat()
        {
            Console.WriteLine(+ x + ", " + y + ", "+color);
        }
        public void Nhap()
        {
            Console.WriteLine("nhap x:");
            X = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap y:");
            Y = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap color:");
            Color = Console.ReadLine();

        }
    }
    public class Circle
    {
        private double r;
        private Point c;

        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public Point C
        {
            get { return c; }
            set { c = value; }
        }
        public Circle(double r, Point c)
        {
            this.r = r; this.c = c;
        }
        public Double Area()
        {
            return Math.PI * r * r;
        }
        public void move(double dx, double dy)
        {
            c.Move(dx, dy);
        }
        public void Xuat()
        {
            Console.Write("Tam: ");
            c.Xuat();
            Console.WriteLine("Ban kinh: " + R);
        }
        public void Nhap()
        {   
            Console.WriteLine("nhap ban kinh:");
            R=Double.Parse(Console.ReadLine());
           
            c.Nhap();
            
        }
    }
        class Program {
            static void Main()
            {
            Circle p = new Circle(0,new Point(0,0,""));
            
            p.Nhap();
            p.Xuat();
            Console.WriteLine("tinh dien tich:");
            double a=p.Area();
            Console.WriteLine("dien tich la:" + a);
            Console.WriteLine("di chuyen:");
            Console.Write("Nhap dx: ");
            double dx = double.Parse(Console.ReadLine());

            Console.Write("Nhap dy: ");
            double dy = double.Parse(Console.ReadLine());
            p.move(dx,dy);
            Console.WriteLine("sau khi di chuyen:");
            p.Xuat();
            
            } 
        }
        
    
    
}

