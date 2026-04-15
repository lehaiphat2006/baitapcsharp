using System;
using System.Collections.Generic;
public class Xe
{
    private string bienso;
    private double namSX;
    private double gia;
    
    public string BienSo { get => bienso; set => bienso = value; }
    public double NamSX { get => namSX; set => namSX = value; }
    public double Gia { get => gia; set => gia = value; }
    public Xe(String bs=" ",double nsx=0,double giatien=0) {
        this.bienso = bs;
        this.namSX = nsx;
        this.gia = giatien;
    }
    public virtual void Nhap()
    {
        Console.WriteLine("nhap bien so xe:");
        bienso = Console.ReadLine();
        Console.WriteLine("nhap nam san xuat xe:");
        namSX = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap gia xe:");
        gia = double.Parse(Console.ReadLine());

    }
    public virtual void Xuat()
    {
        Console.WriteLine(" bien so xe:"+bienso);
        Console.WriteLine("nam san xuat:"+namSX);
        Console.WriteLine("gia tien:"+gia);
    }
    
}
public class XeCon : Xe 
{
    private int socho;
    private string loaixe;
    
public int SoCho { get => socho; set => socho = value; }
public string LoaiXe { get => loaixe; set => loaixe = value; }
    public XeCon(string BienSo=" ",double NamSX=0,double Gia=0,int socho=0, string loaixe=" " ):base(BienSo,NamSX,Gia)
    {
        this.socho = socho;
        this.loaixe = loaixe;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("nhap so cho ngoi:");
        socho=int.Parse(Console.ReadLine());
        Console.WriteLine(" nhap loai xe:");
        loaixe = Console.ReadLine();
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("so cho ngoi:" + socho);
        Console.WriteLine("loai xe:" + loaixe);
    }
    
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("nhap so danh sach cac xe:");
        int n = int.Parse(Console.ReadLine());
        List<Xe> dsxe = new List<Xe>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("nhap xe thu " + (i + 1) + ":");
            Xe x = new XeCon();
            x.Nhap();
            dsxe.Add(x);

        }

        Console.WriteLine("DANH SACH CAC XE:");
        for (int i = 0; i < n; i++)
        {
            dsxe[i].Xuat();
        }
        double max = dsxe[0].Gia, min = dsxe[0].Gia;
        foreach (Xe x in dsxe)
        {
            if (x.Gia > max)
            {
                max = x.Gia;
            }
            else if(x.Gia < min)
            {
                min = x.Gia;
            }
        }
        Console.WriteLine("gia xe cao nhat:" + max);
        Console.WriteLine("gia xe thap nhat:"+min);
        Console.WriteLine("nhap chu so co dau so can tim:");
        string chuso=Console.ReadLine();
        foreach(Xe x in dsxe)
        {
            if (x.BienSo==chuso)
            {
                x.Xuat();
            }
        }
        Console.WriteLine("sap xep xe tang dan theo nam san xuat:");
        double nam = 0;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = i+1;j < n; j++)
            {
                if (dsxe[i].NamSX > dsxe[j].NamSX)
                {
                    nam = dsxe[i].NamSX;
                    dsxe[i].NamSX = dsxe[j].NamSX;
                    dsxe[j].NamSX = nam;
                }
            }
        }
        foreach(Xe x in dsxe)
        {
            x.Xuat();
        }
        
    }
}