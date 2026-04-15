/*
Viết chương trình tính tiền điện phải trả dựa vào số kWh tiêu thụ và bảng giá.

Bảng giá:
Số kWh <= 100: 2000 đ/kWh
Từ kWh thứ 101 đến 150: 2500 đ/kWh
Từ kWh thứ 151 trở đi 3000 đ/kWh
Nếu số kWh tiêu thụ vượt quá 300 thì cộng thêm 10% tiền phải trả.

Input: Số kWh tiêu thụ
Output: Số tiền phải thanh toán (VND)
*/

using System;

namespace TinhTienDien
{
    class Program
    {
        // Khai báo các hằng 
        int m1 = 100, m2 = 150, m3 = 300;
        int g1 = 2000, g2 = 2500, g3 = 3000;
        int kwh = 0;
        double sotien = 0;
        static void Main()
        {

            Program p = new Program();
            Console.WriteLine("nhap so kwh:");
            p.kwh = int.Parse(Console.ReadLine());
            if (p.kwh <= p.m1)
            {
                p.sotien = p.kwh * p.g1;
            }
            else if (p.kwh <= p.m2)
            {
                p.sotien = p.m1 * p.g1 + (p.kwh - p.m1) * p.g2;
            }
            else if (p.kwh <= p.m3)
            {
                p.sotien = p.m1 * p.g1 + (p.m2 - p.m1) * p.g2 + (p.kwh - p.m2) * p.g3;
            }
            if (p.kwh > p.m3)
            {
                p.sotien = (p.m1 * p.g1 + (p.m2 - p.m1) * p.g2 + (p.m3 - p.m2) * p.g3 + (p.kwh - p.m3) * p.g3) * 1.1;
            }
            // Output
            Console.WriteLine("So tien: " + p.sotien);
        }
    }
}