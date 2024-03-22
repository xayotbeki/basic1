//1
decimal pi = (decimal)Math.PI;
Console.Write("Radius: ");
decimal R = Convert.ToDecimal(Console.ReadLine());
decimal S = pi * (R*R);
decimal L = 2 * pi * R;
Console.WriteLine("S=" + S + "\nL=" + L);
//2
Console.Write("Summa: ");
decimal summa = Convert.ToDecimal(Console.ReadLine());
Console.Write("Valyuta(so'm): ");
decimal valyuta = Convert.ToDecimal(Console.ReadLine());
decimal qiymat = valyuta * summa;
Console.WriteLine("Qiymat: "+qiymat+" so'm");
//3
Console.Write("Yil: ");
int x = Convert.ToInt32(Console.ReadLine());
int nowYear = 2024;
int age = nowYear - x;
int day = age * 365;
Console.WriteLine("Qiymat = "+day);