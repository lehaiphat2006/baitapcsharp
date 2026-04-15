/*
Một loại vi trùng cứ sau mỗi giờ lại nhân đôi. Hỏi ban đầu có n con vi trùng thì sau h giờ số lượng là bao nhiêu?

Input:
- Số lượng vi trùng ban đầu (con)
- Khoảng thời gian (giờ).

Output: Số lượng vi trùng sau khoảng thời gian đã cho.
*/
using System;
namespace bt3
{
    class vt
    {
        double n, h;
        static void Main()
        {
            int kq;
            vt p = new vt();
            Console.Write("nhap n:");
            p.n = int.Parse(Console.ReadLine());
            Console.Write("nhap h:");
            p.h = int.Parse(Console.ReadLine());
            for (int i = 0; i < p.h; i++)
            {
                p.n = p.n * 2;
            }
            Console.Write("so luong vi trung sau khoang thoi gian da cho:" + p.n);
        }
    }
}