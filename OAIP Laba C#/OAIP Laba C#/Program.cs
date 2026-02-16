
using OAIP_Laba_C_;

class Uravnenie
{
    static void Main()
    {
        Linear linear = new Linear();
        Console.WriteLine("Введите число А");
        linear.first = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число В");
        linear.second = double.Parse(Console.ReadLine());
        double x = linear.Function();
        Console.WriteLine("Корень:" + x);
    }


}
