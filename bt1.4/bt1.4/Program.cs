using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt4
{
    class Program

    {

        static void Nhapmang(int[] a, int n)
        {


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "]:");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void inmang(int[] a, int n)
        {
            Console.Write("Mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static int Max(int[] a, int n)
        {
            Console.Write("Max:");
            int max = a[0];

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];

            }
            return max;

        }
        static bool tang(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {

                if (a[i] > a[i + 1])
                {
                    return false;
                }


            }
            return true;

        }
        static void sapxepT(int[] a, int n)
        {
            int temp = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }


        }
        static void mangcl(int[] a, int n, int[] chan, int[] le, ref int c, ref int l)
        {

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    chan[c] = a[i];
                    c++;
                }
                else
                {
                    le[l] = a[i];
                    l++;
                }
            }
            Console.Write("Mang chan: ");
            for (int i = 0; i < c; i++)
            {
                Console.Write(chan[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Mang le: ");
            for (int i = 0; i < l; i++)
            {
                Console.Write(le[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhapmang(a, n);
            inmang(a, n);

            int m = Max(a, n);
            Console.Write("max:" + m);
            if (tang(a, n))
            {
                Console.WriteLine("Mang da sap xep");
            }
            else
            {
                Console.WriteLine("Mang chua sap xep");
            }
            Console.ReadKey();
            sapxepT(a, n);
            Console.WriteLine("mang sap xep tang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int c = 0, l = 0;
            int[] chan = new int[n];
            int[] le = new int[n];
            Console.WriteLine("2 mang:");
            mangcl(a, n, chan, le, ref c, ref l);
        }
    }
}