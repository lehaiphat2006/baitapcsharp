using System;
using System.Collections.Generic;
public abstract class Book
{
    private string tensach;
    private int nsx;
    private int sotrang;

    public string Tensach { get => tensach; set => tensach = value; }
    public int Nsx { get => nsx; set => nsx = value; }
    public int Sotrang { get => sotrang; set => sotrang = value; }
    public abstract void Nhap();
    public abstract void Xuat();
    public abstract double Giaban();
    public Book(string tensach = " ", int nsx=0,int sotrang=0){
        this.tensach = tensach;
        this.nsx = nsx;
        this.sotrang = sotrang;
    }
}
public class PaperBook : Book
{
    private string tennhain;

    public string Tennhain { get => tennhain; set => tennhain = value; }
    public PaperBook(string tennhain=" ",string tensach=" ",int nsx=0,int sotrang=0):base(tensach,nsx,sotrang)
    {
        this.tennhain = tennhain;
        

        
    }
    public override void Nhap()
    {
        Console.WriteLine("nhap ten sach:");
        Tensach = Console.ReadLine();
        Console.WriteLine("nhap nam san xuat:");
        Nsx=int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so trang");
        Sotrang=int.Parse(Console.ReadLine());
        Console.WriteLine("nhap ten nha in:");
        tennhain = Console.ReadLine();
    }
    public override void Xuat()
    {
        Console.WriteLine("=====Xuat=======");
        Console.WriteLine("ten sach:" + Tensach);
        Console.WriteLine("nam san xuat:"+Nsx);
        Console.WriteLine("so trang:" + Sotrang);
        Console.WriteLine("ten nha in:" + tennhain);

    }
    public override double Giaban()
    {
        return Sotrang * 400;
    }

}
public class EBook: Book
{
    private string dinhdang;

    public EBook(string dinhdang=" ", string tensach = " ", int nsx = 0, int sotrang = 0):base(tensach,nsx,sotrang) { 
        this.dinhdang = dinhdang;
    }

    public string Dinhdang { get => dinhdang; set => dinhdang = value; }
    public override void Nhap()
    {
        Console.WriteLine("nhap ten sach:");
        Tensach = Console.ReadLine();
        Console.WriteLine("nhap nam san xuat:");
        Nsx = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so trang");
        Sotrang = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap dinh dang:");
        dinhdang = Console.ReadLine();
    }
    public override void Xuat()
    {
        Console.WriteLine("=====Xuat=======");
        Console.WriteLine("ten sach:" + Tensach);
        Console.WriteLine("nam san xuat:" + Nsx);
        Console.WriteLine("so trang:" + Sotrang);
        Console.WriteLine("dinh dang:" + dinhdang);

    }
    public override double Giaban()
    {
        return Sotrang * 100;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine(" nhap danh sach n:");
            n = int.Parse(Console.ReadLine());
        } while (n < 0 || n > 100);
        List<Book> dss= new List<Book>();
        int chon;
        for(int i=0; i<n; i++)
        {
            Console.WriteLine("nhap kieu sach 1:ppbook,2:ebook >");
            chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Book x = new PaperBook();
                x.Nhap();
                dss.Add(x);
            }
            else if (chon == 2) {
                Book x = new EBook();
                x.Nhap();
                dss.Add(x);
            }
            else
            {
                Console.WriteLine(" chua chon kieu sach! ");
                i--;
            }
            
        }
        foreach (Book x in dss) { 
            x.Xuat(); 
        }
        //tim sach paperbook co gia cao nhat
        PaperBook max1 =  null;
        foreach (Book x in dss) {
            if (x is PaperBook pb) {
                if (max1 == null || x.Giaban() > max1.Giaban()) {
                    max1 = pb;
                }
            }

        }
        //tim sach ebook co gia cao nhat
        EBook max2 = null;
        foreach (Book x in dss)
        {
            if (x is EBook eb)
            {
                if (max2 == null || x.Giaban() > max2.Giaban())
                {
                    max2 = eb;
                }
            }

        }
        //xuat gia paperbook
        if (max1 != null)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("paperbook co gia cao nhat:");
            max1.Xuat();
        }
        //xuat gia ebook
        if (max2 != null)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("ebook co gia cao nhat:");
            max2.Xuat();
        }
        // Xóa các sách có thời gian lưu hành lớn hơn 10 năm, xuất lại danh sách sau khi xóa
        int tg = DateTime.Now.Year;
        
            dss.RemoveAll(x => tg - x.Nsx > 10);
        
        foreach (Book x in dss)
        {
            Console.WriteLine("==============");
            Console.WriteLine("danh sach sau khi xoa:");
            x.Xuat();
        }

    }
}
