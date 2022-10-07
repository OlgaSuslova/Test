//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//A(3,6,8); B(2,1, -7) -> 15,84
//A(7,-5,0); B(1,-1,9) -> 11,53

Console.Clear();
int ax, ay, az, bx, by, bz;

ax = Koords("Введите координату x первого числа: ");
ay = Koords("Введите координату y первого числа: ");
az = Koords("Введите координату z первого числа: ");
bx = Koords("Введите координату x второго числа: ");
by = Koords("Введите координату y второго числа: ");
bz = Koords("Введите координату z второго числа: ");

double distanse = Distanse(ax, ay, az, bx, by, bz);
Console.WriteLine(distanse);

static int Koords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}


static double Distanse(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow( bx - ax, 2 ) + Math.Pow( by-ay, 2 ) + Math.Pow( bz - az, 2 ));
    return result;
}
