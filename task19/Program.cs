//принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if(number < 10000 || number > 99999)
{
 Console.WriteLine("не корректное число");
}
else
{
    int pal = 0, num = number; 
        while (number > 0)
        {
            pal = pal * 10 + number % 10; number /= 10;
        } 
    if(num==pal)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
      Console.WriteLine("не палиндром");  
    }
}