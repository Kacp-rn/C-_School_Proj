namespace School_project_C_SHARP;

class Program
{
    static void Main(string[] args)
    {
        int poziomy = int.Parse(Console.ReadLine());

        for (int i = 1; i <= poziomy; i++)
        {
            for (int j = 0; j <= ((((poziomy * 2) - 1) / 2)-i); j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (i*2-1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        // Random rnd = new Random();
        // int rand_numb  = rnd.Next(0, 101);
        //
        // int gues = 0;
        // while (gues != rand_numb)
        // {
        //     Console.WriteLine("podaj liczbę");
        //     gues = int.Parse(Console.ReadLine());
        //     if (gues < rand_numb)
        //     {
        //         Console.WriteLine("liczba jest za mała");
        //     }
        //     else if (gues > rand_numb)
        //     {
        //         Console.WriteLine("liczba jest za duża");
        //     }
        //     else
        //     {
        //         Console.WriteLine("brawo użytkowniku!!!");
        //     }
        // }
        // Console.WriteLine("podaj ilość liczb");
        // int a = int.Parse(Console.ReadLine());
        // int suma = 0;
        // for (int i = 0; i <= a; i++) suma += i;
        // Console.WriteLine($"{suma}");
        // Console.WriteLine("podawaj dłogości boków trójkąta w kolejności od najmniejszego do największego");
        // double a = double.Parse(Console.ReadLine());
        // double b = double.Parse(Console.ReadLine());
        // double c = double.Parse(Console.ReadLine());
        //
        // if (a + b < c)
        // {
        //     Console.WriteLine("Nie da rady narysować trójkąta");
        // }
        // else if (a + b >= c)
        // {
        //     Console.WriteLine("Da rady narysować trójkąt");
        // }
        //-----------------------------------------------------------------------------------------------------------------------------
        // bool should_brake = false;
        // while(should_brake != true)
        // {
        //     Console.WriteLine("Podaj liczbe odpowiadajaca wybranemu działaniu");
        //     Console.WriteLine("1.Dodawanie");
        //     Console.WriteLine("2.Odejmowanie");
        //     Console.WriteLine("3.Mnożenie");
        //     Console.WriteLine("4.Dzielenie");
        //     double wynik;
        //     int liczba = int.Parse(Console.ReadLine());
        //     switch (liczba)
        //     {
        //         case 1:
        //         {
        //             double a = double.Parse(Console.ReadLine());
        //             double b = double.Parse(Console.ReadLine());
        //             wynik = a + b;
        //             Console.WriteLine($"{a}+{b} = {wynik}");
        //             break;
        //         }
        //         case 2:
        //         {
        //             double a = double.Parse(Console.ReadLine());
        //             double b = double.Parse(Console.ReadLine());
        //             wynik = a - b;
        //             Console.WriteLine($"{a}-{b} = {wynik}");
        //             break;
        //         }
        //         case 3:
        //         {
        //             double a = double.Parse(Console.ReadLine());
        //             double b = double.Parse(Console.ReadLine());
        //             wynik = a * b;
        //             Console.WriteLine($"{a}*{b} = {wynik}");
        //             break;
        //         }
        //         case 4:
        //         {
        //             double a = double.Parse(Console.ReadLine());
        //             double b = double.Parse(Console.ReadLine());
        //             if (b == 0)
        //             {
        //                 Console.WriteLine("Nie dziel przez 0");
        //                 break;
        //             }
        //
        //             wynik = a / b;
        //             Console.WriteLine($"{a}/{b} = {wynik}");
        //             break;
        //         }
        //     }
        //     Console.WriteLine("czy chcesz zakonczyc dzialanie programu?"); 
        //     should_brake = bool.Parse(Console.ReadLine());
        // }
    }
}