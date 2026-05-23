using System;
using System.Collections.Generic;
public class Xe
{
    private string dongxe;
    private int cho;
    private DateTime ngaysx;
    public static double giasan = 400;
    public string Dongxe { get => dongxe; set => dongxe = value; }
    public int Cho { get => cho; set => cho = value; }
    public DateTime Ngaysx { get => ngaysx; set => ngaysx = value; }

    public Xe(string dongxe=" ", int cho=0, DateTime ngaysx=default)
    {
        this.dongxe = dongxe;
        this.cho = cho;
        this.ngaysx = ngaysx;
    }
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap dong xe:");
        dongxe = Console.ReadLine();
        Console.WriteLine("Nhap so cho:");
        cho=int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("nhap ngay san xuat(dd/mm/yy):");
            ngaysx = DateTime.Parse(Console.ReadLine());
        }while(ngaysx.Year>DateTime.Now.Year);
        
    }
    public virtual void Xuat()
    {
        Console.WriteLine("dong xe:"+dongxe);
        Console.WriteLine("so cho:"+cho);
        Console.WriteLine("ngay san xuat:"+ ngaysx);


    }
    public virtual double TinhGiaBan()
    {
        int nam = DateTime.Now.Year - ngaysx.Year;
        double gs=0;
        if (nam > 2)
        {
             gs = giasan * 1.15;
        }else if(nam>1&&nam<=2)
        {
            gs = giasan * 1.3;
        }
        else
        {
            gs = giasan * 1.5;
        }
        return gs;
    }
}
interface Phi
{
    double PhiTruocBa { get; set; }

    double TinhPhiTruocBa();
}
public class XeVinfast : Xe, Phi
{
    private double phitruocba;

    public double PhiTruocBa { get => phitruocba; set => phitruocba = value; }
    public string Noidangki { get => noidangki; set => noidangki = value; }

    private string noidangki;
    public XeVinfast(string dongxe=" ",int cho=0,DateTime ngaysx=default, string noidangki=" ",double phitruocba=0):base(dongxe,cho,ngaysx) 
    { 
        this.noidangki= noidangki;
        this.phitruocba= phitruocba;
    }
    public override void Nhap()
    {
        
        base.Nhap();
        Console.WriteLine("nhap noi dang ki:");
        noidangki = Console.ReadLine();
        Console.WriteLine("nhap phi truoc ba:");
        phitruocba=double.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        Console.WriteLine("================================");
        base.Xuat();
        Console.WriteLine("noi dang ki:"+ noidangki);
        Console.WriteLine("phi truoc ba:"+ phitruocba);
        Console.WriteLine("Tinh phi truoc ba:" + TinhPhiTruocBa());
        Console.WriteLine(" phi dang ki:" + PhiDangKi());
        Console.WriteLine("Gia lan banh:" + GiaLanBanh() );
    }
    public double TinhPhiTruocBa()
    {
        return phitruocba*TinhGiaBan(); 
    }
    public double PhiDangKi()
    {
        if(noidangki.ToLower().Trim()=="ha noi")
        {
            return TinhGiaBan() * 0.12;
        }
        else
        {
            return TinhGiaBan() * 0.1;
        }
    }
    public double GiaLanBanh()
    {
        return TinhGiaBan()+TinhPhiTruocBa()+PhiDangKi();
    }
}
public class Program
{

    public static void Main(string[] args)
    {
        List<XeVinfast> dsxe = new List<XeVinfast>();
        int n;
        do
        {
            Console.WriteLine("nhap so luong danh sach xe:");
            n = int.Parse(Console.ReadLine());
        } while (n < 0 || n > 20);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("nhap xe thu " + (i + 1) + ":");
            XeVinfast x = new XeVinfast();
            x.Nhap();
            dsxe.Add(x);
        }
        foreach (XeVinfast x in dsxe)
        {
            x.Xuat();
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (dsxe[i].GiaLanBanh() < dsxe[j].GiaLanBanh())
                {
                    XeVinfast temp = dsxe[i];
                    dsxe[i] = dsxe[j];
                    dsxe[j] = temp;
                }
            }
        }
        Console.WriteLine("================================");
        Console.WriteLine("danh sach xe sau khi sap xep giam dan:");
        foreach (XeVinfast x in dsxe) { x.Xuat(); }

        //Thêm 1 xe VINFAST vào vị trí thứ p trong danh sách.
        //cach 1
        int them;
        do
        {
            Console.WriteLine("nhap vi tri can them:");
            them = int.Parse(Console.ReadLine());
        } while (them < 0 || them > dsxe.Count);
        XeVinfast xeMoi = new XeVinfast();

        Console.WriteLine("Nhap xe moi:");
        xeMoi.Nhap();

        // thêm phần tử rỗng cuối list
        dsxe.Add(new XeVinfast());

        // dời các phần tử sang phải
        for (int i = dsxe.Count - 1; i > them; i--)
        {
            dsxe[i] = dsxe[i - 1];
        }

        // gán xe mới vào vị trí p
        dsxe[them] = xeMoi;
        foreach (XeVinfast x in dsxe)
        {
            x.Xuat();
        }
        //cach 2
        // Thêm xe vào vị trí p
        //Console.Write("\nNhap vi tri can them: ");
        //int p = int.Parse(Console.ReadLine());

        //XeVinfast xeMoi = new XeVinfast();

        //Console.WriteLine("Nhap thong tin xe moi:");
        //xeMoi.Nhap();

        //dsxe.Insert(p, xeMoi);

        //xoa phan tu theo dong xe
        //cach 1
        Console.WriteLine("Nhap dong xe can xoa:");
        string xoa = Console.ReadLine();

        for (int i = 0; i < dsxe.Count; i++)
        {
            if (dsxe[i].Dongxe.ToLower().Trim() == xoa.ToLower().Trim())
            {
                dsxe.RemoveAt(i);
                //PHAI I-- vi cac phan tu se don len nen se bo quen 1 phan tu chua kiem tra
                i--;
            }
        }
        foreach (XeVinfast x in dsxe)
        {
            x.Xuat();
        }
        //cach 2
        //Console.Write("\nNhap dong xe can xoa: ");
        //string xoa = Console.ReadLine();

        //dsxe.RemoveAll(x => x.Dongxe.ToLower().Trim() == xoa.ToLower().Trim());
    }
}