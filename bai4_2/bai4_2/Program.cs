using System;
public abstract class Shape
{
    private string name;

  public string Name { get => name; set => name = value; }
    public Shape(string name)
    {
        this.name = name;
    }
    public abstract double Area(); 
}
public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double w, double h) : base("Rectangle")
    {
        this.width = w;
        this.height = h;
    }

    public double Width { get => width; set => width = value; }
    public double Height { get => height; set => height = value; }

    public override double Area()
    {
        return width * height;
    }
}
public class Square : Rectangle
{
    public Square(double w) : base(w, w)
    {
        Name = "Square";
    }
}
public class Circle : Shape
{
    private double radius;

    public Circle(double r) : base("Circle")
    {
        this.radius = r;
    }

    public double Radius { get => radius; set => radius = value; }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
public class Triangle : Shape
{
    private double a, b, c;

    public Triangle(double a, double b, double c) : base("Triangle")
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
    }
}
class Program
{
    static void Main()
    {
        List<Shape> ds = new List<Shape>();

        Console.Write("Nhap so luong hinh: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Chon loai hinh (1-Rect, 2-Square, 3-Circle, 4-Triangle): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("nhap width: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.WriteLine("nhap height:");
                    double h = double.Parse(Console.ReadLine());
                    Shape h1 = new Rectangle(w, h);
                    ds.Add(h1);
                    break;

                case 2:
                    Console.Write("canh: ");
                    double canh = double.Parse(Console.ReadLine());
                    Shape h2 = new Square(canh);
                    ds.Add(h2);
                    break;

                case 3:
                    Console.Write("ban kinh: ");
                    double r = double.Parse(Console.ReadLine());
                    Shape h3 = new Circle(r);
                    ds.Add(h3);
                    break;

                case 4:
                    Console.Write("nhap a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("nhap b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("nhap c: ");
                    double c = double.Parse(Console.ReadLine());
                    Shape h4 = new Triangle(a, b, c);
                    ds.Add(h4);
                    break;
                default:
                    Console.WriteLine("nhap sai,xin moi nhap lai.");
                    i--;
                    break;
            }
        }
        Shape max = ds[0];
        foreach (var x in ds)
        {
            if (x.Area() > max.Area())
                max = x;
        }

        Console.WriteLine("\nhinh co dien tich lon nhat: " + max.Name + " : " + max.Area());
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (ds[i].Area() < ds[j].Area()) 
                {
                    
                    Shape temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
            }
        }
        Console.WriteLine("\ndanh sach sau sap xep:");
        foreach (var x in ds)
        {
            Console.WriteLine(x.Name + " : " + x.Area());
        }
    }
}