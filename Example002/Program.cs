// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Метод получения числа от пользователя
int InputUser(string str)
{
    Console.Write($"{str}  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

(double x, double y) IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    return (x, y);
}

double b1 = InputUser("Введите значение b1");
double k1 = InputUser("Введите значение k1");
double b2 = InputUser("Введите значение b2");
double k2 = InputUser("Введите значение k2");
(double x, double y) intersection = IntersectionPoint(b1, k1, b2, k2);

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {intersection.x}, Y: {intersection.y}");