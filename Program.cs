// *****************************************************************
// Домашняя работа №2                                              *
// Выполнил: Матченко М.С., группа 2-ИСП-оКФ                       *
// Вариант №1                                                      *
// *****************************************************************
using System;
namespace DZ_2
{
    // Задание №1 Маршруты междугородних автобусов.
    public struct BusRoute
    {
        public string routeNumber; // Номер маршрута
        public string departureCity; // Город отправления
        public string arrivalCity; // Город прибытия
        public double ticketPrice; // Стоимость билета
        public BusRoute(string _routeNumber, string _departureCity, string _arrivalCity, double _ticketPrice)
        {
            routeNumber = _routeNumber;
            departureCity = _departureCity;
            arrivalCity = _arrivalCity;
            ticketPrice = _ticketPrice;
        }
        // Метод для изменения стоимости билета
        public void UpdateTicketPrice(double newPrice)
        {
            ticketPrice = newPrice;
        }
        // Метод для получения цены со скидкой 10% в январе
        public double GetPriceWithJanuaryDiscount()
        {
            const double discountRate = 0.10; // 10% скидка
            return ticketPrice * (1 - discountRate);
        }
        // Метод для вывода информации о маршруте
        public void PrintRouteInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Задание №1 Маршруты междугородних автобусов.");
            Console.WriteLine(new string('-', 46));
            Console.WriteLine($"Автобусный рейс№:              {routeNumber}");
            Console.WriteLine($"Отправление:                   {departureCity}");
            Console.WriteLine($"Прибытие:                      {arrivalCity}");
            Console.WriteLine($"Цена билета:                   {ticketPrice:F2} руб.");
        }
        // метод для вывода цены со скидкой
        public void PrintPriceWithJanuaryDiscount()
        {
            double discountedPrice = GetPriceWithJanuaryDiscount();
            Console.WriteLine($"Цена билета в январе (-10%):   {discountedPrice:F2} руб.");
            Console.WriteLine(new string('-', 46));
        }
    }
    // Задание №2 Птица.
    public struct Bird
    {
        public string species; // Вид птицы
        public double wingspan; // Размах крыльев в метрах
        public double weight; // Вес птицы в килограммах
        public bool isMigratory; // Является ли перелетной
        public Bird(string _species, double _wingspan, double _weight, bool _isMigratory)
        {
            species = _species;
            wingspan = _wingspan;
            weight = _weight;
            isMigratory = _isMigratory;
        }
        // Условный метод расчёта «возраста» птицы по размаху крыльев        
        public int CalculateAgeByWingspan()
        {
            const double factor = 5.0; // Условный коэффициент: 1 метр ≈ 5 лет
            return (int)(wingspan * factor);// Формула: возраст (лет) = размах (м) * 5 (цифра условная)
        }
        // Метод для расчета суточной нормы корма на основе веса
        public double CalculateDailyFood()
        {
            return weight * 0.1;
        }
        // Метод для вывода характеристик птицы
        public void PrintBirdInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Задание №2 Птица.");
            Console.WriteLine(new string('-', 46));
            Console.WriteLine($"Вид птицы:                     {species}");
            Console.WriteLine($"Размах крыльев:                {wingspan} м");
            Console.WriteLine($"Вес птицы:                     {weight} кг");
            Console.WriteLine($"Перелетная:                    {(isMigratory ? "Да" : "Нет")}");
            Console.WriteLine($"Суточная норма корма:          {CalculateDailyFood():F2} кг");
            Console.WriteLine($"Условный возраст (по размаху): {CalculateAgeByWingspan()} лет");
            Console.WriteLine(new string('-', 46));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "Домашнее задание № 2.";
            Console.Clear();
            Console.WriteLine("Здравствуйте!");
            //Console.WriteLine("--- Автобус и Птицы ---\n");
            BusRoute route = new BusRoute("128", "25 км", "Апатиты", 200.00);
            route.PrintRouteInfo();
            route.PrintPriceWithJanuaryDiscount(); // Выводим цену со скидкой
            Bird bird = new Bird("Сапсан", 1.1, 1.0, true);
            bird.PrintBirdInfo();
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}