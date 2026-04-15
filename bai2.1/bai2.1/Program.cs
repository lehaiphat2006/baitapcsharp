using System;
using System.Drawing;
using System.Net.NetworkInformation;
namespace bai2_1
{

    public class PhanSo
    {
        private int _tuSo, _mauSo;
       
        public int TuSo { get => _tuSo; set => _tuSo = value; }
        public int MauSo { get => _mauSo; set => _mauSo = value; }

        public PhanSo(int ts, int ms)
        {
            _tuSo = ts;
            _mauSo = ms;
        }
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;
        }
        public void Nhap()
        {
            Console.Write("nhap tu so:");
            _tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("nhap mau so:");
                _mauSo = int.Parse(Console.ReadLine());
            } while (MauSo == 0);


        }
        public void Xuat()
        {
            Console.Write(+_tuSo + "/" + _mauSo + " ");
        }
        private int ucln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public void ToiGian()
        {

            int u = ucln(_tuSo, _mauSo);
            _tuSo /= u;
            _mauSo /= u;
        }
        public PhanSo Cong(PhanSo p)
        {
            int ts = _tuSo * p._mauSo + p._tuSo * _mauSo;
            int ms = _mauSo * p._mauSo;
            return new PhanSo(ts, ms);
        }
        public PhanSo Tru(PhanSo p)
        {
            int ts = _tuSo * p._mauSo - p._tuSo * _mauSo;
            int ms = _mauSo * p._mauSo;
            return new PhanSo(ts, ms);
        }


    }
    //danh sach phan so
    public class DSPhanSo
    {
        private PhanSo[] _dsPS;
        private int _size;
        public PhanSo[] DSPS
        {
            get { return _dsPS; }
            set { _dsPS = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public void Nhap()
        {
            Console.WriteLine("nhap so phan tu:");
            _size = int.Parse(Console.ReadLine());
            _dsPS = new PhanSo[_size];
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine("a[" + i + "]=");
                _dsPS[i] = new PhanSo(0, 1);
                _dsPS[i].Nhap();

            }
        }
        public void Xuat()
        {
            Console.WriteLine("xuat :");
            for (int i = 0; i < _size; i++)
            {
                _dsPS[i].Xuat();
            }

        }
        private double Gt(PhanSo p)
        {
            return (double)p.TuSo / p.MauSo;
        }
        public PhanSo max()
        {
            PhanSo Max = new PhanSo(_dsPS[0]);
            for (int i = 0; i < _size; i++)
            {
                if (Gt(_dsPS[i]) > Gt(Max))
                {
                    Max = _dsPS[i];

                }

            }
            return Max;
        }
        public void sx()
        {
            for(int i=0; i < _size-1; i++)
            {
                for(int j = i + 1; j < _size; j++)
                {
                    if (Gt(_dsPS[i]) > Gt(_dsPS[j]))
                    {
                        PhanSo d = _dsPS[i];
                        _dsPS[i] = _dsPS[j];
                        _dsPS[j] = d;   
                    }
                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*PhanSo ps1 = new PhanSo(3,4);
            PhanSo ps2 =new PhanSo(2,5);

            //nhap phan so
            ps1.Nhap();
            ps2.Nhap();
            //xuat phan so
            ps1.Xuat();
            ps2.Xuat();
            //cong
            Console.WriteLine("cong phan so:");
            PhanSo kq1=ps1.Cong(ps2);
            kq1.ToiGian();
            kq1.Xuat();
            //tru
            Console.WriteLine("tru phan so:");
            PhanSo kq2 =ps1.Tru(ps2);
            kq2.ToiGian();
            kq2.Xuat();
            */

            //danh sach phan so
            DSPhanSo ds = new DSPhanSo();
            ds.Nhap();
            ds.Xuat();
            
            PhanSo m=ds.max();
            Console.WriteLine("phan so lon nhat:");
            m.Xuat();

            ds.sx();
            ds.Xuat();

        }
    }
}
