using System;
using System.Security.Cryptography.X509Certificates;
public class Stack
{
    private int max;
    private int top;
    private int [] data;


    public Stack(int size)
    {
        max = size;
        top = -1;
        Data = new int[max];
    }

    public int Max { get => max; set => max = value; }
    public int Top { get => top; set => top = value; }
    public int[] Data { get => data; set => data = value; }

    public  int Push(int value)
    {
        if (top == max - 1)
        {
            Console.WriteLine("stack day:");
            return -1;
        }
        top++;
        Data[top]=value;
        return value;

    }
    public  int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack rỗng!");
            return -1;
        }
        return Data[top--];
    }
    public virtual void Print()
    {
        Console.Write("Stack: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(Data[i] + " ");
        }
    }
}
public class PrimeStack:Stack
{
    public override void Print()
    {
        Console.WriteLine("thua so nguyen to:");
        for(int i = 0; i <= Top; i++)
        {
            Console.Write(Data[i]);
            if (i < Top)
                Console.Write("*");

        }

    }
    public PrimeStack(int size = 100) : base(size)
    {

    }
    
    public void thuasonguyento()
    {
        Console.WriteLine("nhap so:");
        int n=int.Parse(Console.ReadLine());
        int temp = n;
        for (int i = 2; i <= temp; i++)
        {
            while (temp % i == 0)
            {
                Push(i);
                temp /= i;
                
            }
        }
    }

}
public class HexaStack : Stack
{
    public HexaStack(int size = 100) : base(size) { }

    public void DoiSo()
    {
        Console.WriteLine("nhap so de doi:");
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        while (temp > 0)
        {
            Push(temp % 16);  
            temp /= 16;
        }
    }
    public override void Print()
    {
        Console.Write("He 16: ");
        for (int i = Top; i >= 0; i--)
        {
            if (Data[i] < 10)
                Console.Write(Data[i]);
            else
                Console.Write((char)(+Data[i] - 10 + 'A')); 
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        
        PrimeStack ps = new PrimeStack(100);
        ps.thuasonguyento();
        ps.Print();
        Console.WriteLine();

        
        HexaStack hs = new HexaStack();
        hs.DoiSo();
        hs.Print();
    }
}
