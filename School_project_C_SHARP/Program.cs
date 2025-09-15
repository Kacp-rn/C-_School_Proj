namespace School_project_C_SHARP;

class Program
{
    static void Main(string[] args)
    {
        bool should_brake = false;
        while(should_brake != true)
        {
            
            
       
            Console.WriteLine("Podaj liczbe odpowiadajaca wybranemu działaniu");
            Console.WriteLine("1.Dodawanie");
            Console.WriteLine("2.Odejmowanie");
            Console.WriteLine("3.Mnożenie");
            Console.WriteLine("4.Dzielenie");
            double wynik;
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 1:
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    wynik = a + b;
                    Console.WriteLine($"{a}+{b} = {wynik}");
                    break;
                }
                case 2:
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    wynik = a - b;
                    Console.WriteLine($"{a}-{b} = {wynik}");
                    break;
                }
                case 3:
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    wynik = a * b;
                    Console.WriteLine($"{a}*{b} = {wynik}");
                    break;
                }
                case 4:
                {
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("Nie dziel przez 0");
                        break;
                    }

                    wynik = a / b;
                    Console.WriteLine($"{a}/{b} = {wynik}");
                    break;
                }
            }
            Console.WriteLine("czy chcesz zakonczyc dzialanie programu?"); 
            should_brake = bool.Parse(Console.ReadLine());
        }
        }
}