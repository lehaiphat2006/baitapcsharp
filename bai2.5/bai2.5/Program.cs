using System;
namespace bai2_5
{
class Stack
{
    private int top;
    private int Max;
    private int[] stack;

    public Stack(int size)
    {
        Max = size;
        stack = new int[Max];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public void Push(int data)
    {
        if (top == Max - 1)
        {
            Console.WriteLine("Stack day");
            return;
        }

        top++;
        stack[top] = data;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack rong");
            return -1;
        }

        int value = stack[top];
        top--;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack rong");
            return -1;
        }

        return stack[top];
    }

    public void Print()
    {
        for (int i = top; i >= 0; i--)
        {
            Console.Write(stack[i] + " ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen: ");
        int n = int.Parse(Console.ReadLine());

        Stack s = new Stack(100);
        int temp = n;

        for (int i = 2; i <= temp; i++)
        {
            while (temp % i == 0)
            {
                s.Push(i);
                temp /= i;
            }
        }

        Console.Write(n + " = ");
        while (!s.IsEmpty())
        {
            Console.Write(s.Pop());
            if (!s.IsEmpty()) Console.Write(" * ");
        }

        Console.WriteLine();

        Stack s2 = new Stack(100);
        int num = n;

        while (num > 0)
        {
            s2.Push(num % 2);
            num /= 2;
        }

        Console.Write("Nhi phan: ");
        while (!s2.IsEmpty())
        {
            Console.Write(s2.Pop());
        }

        Console.WriteLine();

        Stack s3 = new Stack(100);
        num = n;

        while (num > 0)
        {
            s3.Push(num % 16);
            num /= 16;
        }

        Console.Write("Thap luc phan: ");
        while (!s3.IsEmpty())
        {
            int x = s3.Pop();

            if (x < 10)
                Console.Write(x);
            else
                Console.Write((char)(x - 10 + 'A'));
        }

        Console.WriteLine();
    }
}
}