using System;
using System.Collections.Generic;
public class Printer
{
    private string hangsx;
    private double gia;
    
public string Hangsx { get => hangsx; set => hangsx = value; }
    public double Gia { get => gia; set => gia = value; }

    

    public Printer(string hangsx = "", double gia = 0)
    {
        this.hangsx = hangsx;
        this.gia = gia;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap hang san xuat: ");
        hangsx = Console.ReadLine();

        Console.Write("Nhap gia: ");
        gia = double.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.WriteLine("Hang: " + hangsx);
        Console.WriteLine("Gia: " + gia);
    }

    
}

public class LaserPrinter : Printer
{
    private string dophangiai;

    public LaserPrinter(string hangsx = "", double gia = 0, string dophangiai = "")
        : base(hangsx, gia)
    {
        this.dophangiai = dophangiai;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap do phan giai (vd 1200x1200): ");
        dophangiai = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Do phan giai: " + dophangiai);
    }
}
class Program
{
    static void Main()
    {
        List<Printer> ds = new List<Printer>();

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"--- May in {i + 1} ---");
            Printer p = new LaserPrinter();
            p.Nhap();
            ds.Add(p);
        }

        Console.WriteLine("\nDANH SACH MAY IN:");
        foreach (var p in ds)
        {
            p.Xuat();
        }

        
        Printer min = ds[0], max = ds[0];
        foreach (var p in ds)
        {
            if (p.Gia < min.Gia)
                min = p;
            if (p.Gia > max.Gia)
                max = p;
        }

        Console.WriteLine("\nMay in gia thap nhat:");
        min.Xuat();

        Console.WriteLine("\nMay in gia cao nhat:");
        max.Xuat();

        
        Console.Write("\nNhap hang can tim: ");
        string h = Console.ReadLine();

        Console.WriteLine("Ket qua loc:");
        bool found = false;

        foreach (var p in ds)
        {
            if (p.Hangsx.ToLower() == h.ToLower())
            {
                p.Xuat();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay!");
        }

       
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (ds[i].Gia > ds[j].Gia)
                {
                    var temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
            }
        }

        Console.WriteLine("\nDANH SACH TANG DAN THEO GIA:");
        foreach (var p in ds)
        {
            p.Xuat();
        }
    }
}