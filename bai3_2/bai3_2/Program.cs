using System;
using System.Collections.Generic;
public class NhanVien
{
    private string hoten;
    private string ngaysinh;
    
    public string Hoten { get => hoten; set => hoten = value; }
    public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    public NhanVien(string hoten=" ", string ngaysinh=" ")
    {
        this.hoten = hoten;
        this.ngaysinh = ngaysinh;
        
      
    }
    public virtual void Nhap()
    {
        Console.WriteLine("nhap ho ten:");
        hoten = Console.ReadLine();
        Console.WriteLine("nhap ngay sinh:");
        ngaysinh = Console.ReadLine();
        
    } 
    public virtual void Xuat()
    {
        Console.WriteLine("ho ten:"+hoten);
        Console.WriteLine("ngay sinh:" + ngaysinh);
        
    }
    public virtual double TinhLuong() {
        return 0;
    }
    
   
}
public class NhanVienSX : NhanVien
{
    private double sosanpham;
    private double luongcb;
    public double Sosanpham { get => sosanpham; set => sosanpham = value; }
    public Double Luongcb { get => luongcb; set => luongcb = value; }

    public NhanVienSX(string hoten = " ", string ngaysinh = " ", double sosanpham = 0, double luongcb = 0) : base(hoten, ngaysinh )
    {
        this.sosanpham = sosanpham;
        this.luongcb = luongcb;
    }
    public override void Nhap()
    {

        base.Nhap();
        Console.WriteLine("nhap so san pham:");
        sosanpham = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap luong co ban:");
        luongcb = double.Parse(Console.ReadLine());
    }

    public override double TinhLuong()
    {
        return luongcb + sosanpham * 5000;
    }
    
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("so san pham:" + sosanpham);
        Console.WriteLine("luong co ban:" + luongcb);
        Console.WriteLine("luong theo nhan vien san xuat:" + TinhLuong());

    }
}
    public class NhanVienVP : NhanVien
    {
        private double songaylamviec;
        public double Songaylamviec { get { return songaylamviec; } set { songaylamviec = value; } } 
            public NhanVienVP(string hoten = " ", string ngaysinh = " ", double songaylamviec=0) : base(hoten, ngaysinh)
        {
            this.songaylamviec = songaylamviec;
        }
        public override void Nhap()
        {

            base.Nhap();
            Console.WriteLine("nhap so ngay lam viec:");
            songaylamviec = double.Parse(Console.ReadLine());
           
        }
        public override double TinhLuong()
        {
        return songaylamviec * 100000;
        }
        public override void Xuat()
        {
            base.Xuat();
            
            Console.WriteLine("luong theo nhan vien van phong:" + TinhLuong());

        }

    }
public class Program
{
    public static void Main()
    {
        List<NhanVien> dsnv = new List<NhanVien>();
        Console.WriteLine("nhap danh sach n nhan vien:");
        int n = int.Parse(Console.ReadLine());
        int chon;
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.WriteLine("nhap lua chon:1.Nhan vien san xuat/2.Nhan vien van phong:");
                chon = int.Parse(Console.ReadLine());
            } while (chon != 1 && chon != 2);
            if (chon == 1)
            {
                NhanVien x=new NhanVienSX();
                dsnv.Add(x);
                x.Nhap();
            }
            if(chon == 2)
            {
                NhanVien x = new NhanVienVP();
                dsnv.Add(x);
                x.Nhap();
            }
        }
        Console.WriteLine("DANH SACH NHAN VIEN:");
        foreach (NhanVien x in dsnv)
        {
            
            x.Xuat();
        }
        Console.WriteLine("DANH SACH NHAN VIEN GIAM DAN THEO LUONG:");
        for(int i = 0; i < n-1;i++) 
        {
            for (int j = i+1;j < n; j++)
            {
                if (dsnv[i].TinhLuong() < dsnv[j].TinhLuong())
                {
                    NhanVien temp = dsnv[i];
                    dsnv[i] = dsnv[j];
                    dsnv[j] = temp;

                }
            }
            
        }
        foreach (NhanVien x in dsnv)
        {
            x.Xuat();
        }
    }
}