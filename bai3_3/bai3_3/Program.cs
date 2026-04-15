using System;
using System.Collections.Generic;
public class HinhVe
{
    public virtual double DienTich()
    {
        return 0;
    }

    public virtual void Nhap()
    {
    }

    public virtual void Xuat()
    {
    }
}
public class HinhChuNhat : HinhVe
{
    private  double dai, rong;
    
public double Dai { get => dai; set => dai = value; }
public double Rong { get => rong; set => rong = value; }

    

    public override void Nhap()
    {
        Console.Write("Nhap chieu dai: ");
        dai = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        rong = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return dai * rong;
    }

    public override void Xuat()
    {
        Console.WriteLine("Hinh chu nhat - Dien tich: " + DienTich());
    }
}
public class HinhVuong : HinhChuNhat
{
    public override void Nhap()
    {
        Console.Write("Nhap canh: ");
        Dai = Rong = double.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        Console.WriteLine("Hinh vuong - Dien tich: " + DienTich());
    }
}
public class HinhTron : HinhVe
{
    private double banKinh;
    
public double BK { get => banKinh; set => banKinh = value; }

    public override void Nhap()
    {
        Console.Write("Nhap ban kinh: ");
        banKinh = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return Math.PI * banKinh * banKinh;
    }

    public override void Xuat()
    {
        Console.WriteLine("Hinh tron - Dien tich: " + DienTich());
    }
}
class Program
{
    static void Main()
    {
        HinhVe h=new HinhVe();
        int chon;

        do
        {
            Console.WriteLine("1. Hinh chu nhat");
            Console.WriteLine("2. Hinh vuong");
            Console.WriteLine("3. Hinh tron");
            Console.Write("Chon hinh: ");
            chon = int.Parse(Console.ReadLine());
        } while (chon < 1 || chon > 3);

        if (chon == 1)
             h = new HinhChuNhat();
        else if (chon == 2)
             h = new HinhVuong();
        else
             h = new HinhTron();

            h.Nhap();
            h.Xuat();
    }
}