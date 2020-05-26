using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_16
{
    public class Class1
    {
        public Class1()
        {
            n = 0;
        }
        public Class1(int a)
        {
            n = a;
            d = "";
        }
        int n;
        string d;
        public int convert_to_ten(string Text, int Length)
        {
            int ten = 0, k = 0, nn;
            nn = n;
            for (int i = 0; i < Length; i++)
            {
                if (n % 10 == 1) ten += (int)Math.Pow(2, k);
                k++;
                n = n / 10;
            }
            if (int.Parse(Text) < 0) ten *= -1;
            n = nn;
            return ten;
        }
        public int convert_to_eight (int n, string Text, int Length)
        {
            int ten = 0, k = 0, nn;
            nn = n;
            while (n > 0)
            {
                ten = ten * 10 + n % 8;
                n = n / 8;
            }
            k = ten;
            ten = 0;
            for (int i = 0; i < Length; i++)
            {
                if (k != 0) ten = ten * 10 + k % 10;
                k = k / 10;
            }
            if (int.Parse(Text) < 0) ten  *= -1;
            n = nn;
            return ten;
        }
        public string convert_to_six(int n, string Text)
        {
            string ei;
            n = (int)Math.Abs(n);
            if (n == 0) d = "0";
            while (n > 0)
            {
                if (n % 16 == 10) ei = "A";
                else if (n % 16 == 11) ei = "B";
                else if (n % 16 == 12) ei = "C";
                else if (n % 16 == 13) ei = "D";
                else if (n % 16 == 14) ei = "E";
                else if (n % 16 == 15) ei = "F";
                else ei = (n % 16).ToString();
                d += ei;
                n = n / 16;
            }
            ei = "";
            for (int i = d.Length - 1; i >=0; i--)
            {
                ei += d[i];
            }
            if (int.Parse(Text) < 0) ei = "-" + ei;
            return ei;
        }
    }
}
