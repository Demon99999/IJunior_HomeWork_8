﻿using System;

namespace IJunior_HomeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople;
            int receptionTimeOfOnePerson = 10;
            Console.WriteLine("Сколько человек в очереди ?");
            countPeople = Convert.ToInt32(Console.ReadLine());
            int totalTime = countPeople * receptionTimeOfOnePerson;
            int minutesInHour = 60;
            int countHoursInQueue = totalTime/ minutesInHour;
            int countMinutesInQueue = totalTime % minutesInHour;
            Console.WriteLine($"Вы должны стоять в очереди {countHoursInQueue} часа и {countMinutesInQueue} минут.");
        }
    }
}
