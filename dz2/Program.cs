using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //------------- 1 ---------------
            //int[] A = new int[5];
            //double[,] B = new double[3, 4];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++)
            //    {
            //        B[i, j] = Convert.ToDouble(rand.Next(1, 100)) / 10.0;
            //    }
            //}

            //foreach (var item in A) { Console.Write($"{item} \t| "); }
            //Console.WriteLine("\n");
            //PrintMatrix(B);
            //Console.WriteLine();

            //Console.WriteLine($"A Max: {A.Max()}\nA Min: {A.Min()}\nA Sum: {A.Sum()}");
            //int r = 1;
            //foreach (var item in A) { r *= item; }
            //Console.WriteLine($"A Prod: {r}");
            //r = 0;
            //foreach (var item in A) { if (item % 2 == 0) { r += item; } }
            //Console.WriteLine($"A Sum of even: {r}\n");

            //double r2 = 0.0;
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++) { if (B[i, j] > r2) { r2 = B[i, j]; } }
            //}
            //Console.WriteLine($"B Max: {r2}");
            //r2 = B[0, 0];
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++) { if (B[i, j] < r2) { r2 = B[i, j]; } }
            //}
            //Console.WriteLine($"B Min: {r2}");
            //r2 = 0.0;
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++) { r2 += B[i, j]; }
            //}
            //Console.WriteLine($"B Sum: {r2}");
            //r2 = 1.0;
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++) { r2 *= B[i, j]; }
            //}
            //Console.WriteLine($"B prod: {r2}");
            //r2 = 0.0;
            //for (int i = 0; i <= B.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= B.GetUpperBound(1); j++) { if (i % 2 == 0) { r2 += B[i, j]; } }
            //}
            //Console.WriteLine($"B Sum of even columns {r2}");

            //------------- 2 ---------------
            //int[,] a = new int[5, 5];
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        a[i, j] = rand.Next(-100, 101);
            //    }
            //}
            //PrintMatrix(a);
            //Console.WriteLine();
            //int[] min = new int[] { 0, 0 };
            //int[] max = new int[] { 0, 0 };
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        if (a[i, j] < a[min[0], min[1]]) { min = [i, j]; }
            //        if (a[i, j] > a[max[0], max[1]]) { max = [i, j]; }
            //    }
            //}
            //int r = 0;
            //if (min[0] > max[0] || min[0] == max[0] && min[1] > max[1]) { int[] t = min; min = max; max = t; }
            //for (int i = min[0]; i <= max[0]; i++)
            //{
            //    for (int j = min[1]; j <= max[1]; j++)
            //    {
            //        Console.Write($"{a[i, j]} \t| ");
            //        r += a[i, j];
            //    }
            //}
            //Console.WriteLine($"\nSum: {r}");

            //-------------3-------------- -
            //string s;
            //Console.Write("Enter text: ");
            //s = Console.ReadLine();
            //int c, shift = 0;
            //Console.Write("Choose option (0 - Encode, 1 - Decode): ");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Shift: ");
            //shift = Convert.ToInt32(Console.ReadLine()) % 26;
            //char[] r = s.ToCharArray();
            //if (c == 0)
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i] >= 'A' && s[i] <= 'Z')
            //        {
            //            r[i] = Convert.ToChar(r[i] + shift);
            //            if (r[i] > 'Z') { r[i] = (char)(r[i] - 26); }
            //        }
            //        else if (s[i] >= 'a' && s[i] <= 'z')
            //        {
            //            r[i] = Convert.ToChar(r[i] + shift);
            //            if (r[i] > 'z') { r[i] = Convert.ToChar(r[i] - 26); }
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        if (s[i] >= 'A' && s[i] <= 'Z')
            //        {
            //            r[i] = Convert.ToChar(r[i] - shift);
            //            if (r[i] < 'A') { r[i] = (char)(r[i] + 26); }
            //        }
            //        else if (s[i] >= 'a' && s[i] <= 'z')
            //        {
            //            r[i] = Convert.ToChar(r[i] - shift);
            //            if (r[i] < 'a') { r[i] = Convert.ToChar(r[i] + 26); }
            //        }
            //    }
            //}
            //Console.WriteLine(r);

            //------------- 4 ---------------
            //int[,] a = new int[,] {
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {7, 8, 9 }
            //};
            //int[,] b = new int[,] {
            //    {9, 8, 7 },
            //    {6, 5, 4 },
            //    {3, 2, 1 }
            //};
            //Console.WriteLine("Matrix a:");
            //PrintMatrix(a);
            //Console.WriteLine("Matrix b:");
            //PrintMatrix(b);
            //int[,] c = new int[a.GetUpperBound(0)+1, a.GetUpperBound(1)+1];
            //Console.Write("Enter number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++) { c[i, j] = a[i, j] * n; }
            //}
            //PrintMatrix(c);
            //Console.WriteLine("Matrix a+b:");
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++) { c[i, j] = a[i, j] + b[i, j]; }
            //}
            //PrintMatrix(c);
            //Console.WriteLine("Matrix a*b:");
            //for (int i = 0; i <= a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++) { c[i, j] = a[i, j] * b[i, j]; }
            //}
            //PrintMatrix(c);

            //------------- 5 ---------------
            //Console.Write("Enter expression (- and + only): ");
            //string[] e = Console.ReadLine().Replace(".", ",").Split();
            //double r = Convert.ToDouble(e[0]);
            //for (int i = 1; i < e.Length; i+=2)
            //{
            //    if (i%2 != 0)
            //    {
            //        if (e[i] == "+") { r += Convert.ToDouble(e[i + 1]); }
            //        else if (e[i] == "-") { r -= Convert.ToDouble(e[i + 1]); }
            //        else { Console.WriteLine("Error"); }
            //    }
            //}
            //foreach (var item in e) { Console.Write($"{item} "); }
            //Console.WriteLine($"= {r}");

            //------------- 6 ---------------
            //Console.Write("Enter text: ");
            //string txt = Console.ReadLine();
            //char[] t = txt.ToCharArray();
            //bool c = true;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (char.IsLetter(t[i]) && c)
            //    {
            //        t[i] = char.ToUpper(t[i]);
            //        c = false;
            //    }
            //    else if (t[i] == '.' || t[i] == '?' || t[i] == '!')
            //    {
            //        c = true;
            //    }
            //}
            //Console.WriteLine(t);

            //------------- 7 ---------------
            //Console.Write("Enter text: ");
            //string txt = Console.ReadLine();
            //int c = 0, i = 0;
            //StringBuilder r = new StringBuilder(txt);
            //while ((i = txt.ToLower().IndexOf("die", i)) != -1)
            //{
            //    bool st = (i == 0 || !char.IsLetter(txt[i - 1]));
            //    bool end = (i + 3 == txt.Length || !char.IsLetter(txt[i + 3]));
            //    if (st && end)
            //    {
            //        r.Remove(i, 3);
            //        r.Insert(i, "***");
            //        c++;
            //    }
            //    i += 3;
            //}
            //Console.WriteLine(r.ToString());
            //Console.WriteLine($"Banned words: {c}");

            //------------- 8 ---------------
            //char[] r = args[0].ToCharArray();
            //int shift = Convert.ToInt32(args[1]) % 26;
            //for (int i = 0; i < r.Length; i++)
            //{
            //    if (r[i] >= 'A' && r[i] <= 'Z')
            //    {
            //        r[i] = Convert.ToChar(r[i] + shift);
            //        if (r[i] > 'Z') { r[i] = (char)(r[i] - 26); }
            //    }
            //    else if (r[i] >= 'a' && r[i] <= 'z')
            //    {
            //        r[i] = Convert.ToChar(r[i] + shift);
            //        if (r[i] > 'z') { r[i] = Convert.ToChar(r[i] - 26); }
            //    }
            //}
            //Console.WriteLine(r);

            //------------- 9 ---------------
            int[,] a = new int[Convert.ToInt32(args[0]), Convert.ToInt32(args[1])];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] = rand.Next(0, 10);
                }
            }
            PrintMatrix(a);
            Console.WriteLine("After multiplication :");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] *= Convert.ToInt32(args[2]);
                }
            }
            PrintMatrix(a);

        }

        static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++) { Console.Write($"{a[i, j]} \t| "); }
                Console.WriteLine();
            }
        }
        static void PrintMatrix(double[,] a)
        {
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++) { Console.Write($"{a[i, j]} \t| "); }
                Console.WriteLine();
            }
        }
    }
}
