﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект_5._6._1__HW_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowData(EnterData());
        }
        static (string Name, string LastName, int Аge, string[] PetNames, string[] Colors) EnterData()
        {
            (string Name, string LastName, int Аge, string[] PetNames, string[] Colors) User;

            string stringName;
            int Name;
            do
            {
                Console.WriteLine("Введите имя: ");
                stringName = Console.ReadLine();

            }
            while (!CheckNum(stringName, out Name));
            User.Name = stringName;
            string stringLastName;
            int LastName;
            do
            {
                Console.WriteLine("Введите фамилию: ");
                stringLastName = Console.ReadLine();

            }
            while (!CheckNum(stringLastName, out LastName));
            User.LastName = stringLastName;
            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами: ");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            User.Аge = intage;



            bool isOpen = true;
            do
            {

                Console.WriteLine("У вас есть домашние животные? Введите \"да\" или \"нет\" ");
                string hasPet = Console.ReadLine();
                bool isNumber = int.TryParse(hasPet, out int number);


                if (!isNumber && hasPet == "да")
         
                bool isOpen = true;
            do 
            {

                Console.WriteLine("У вас есть домашние животные? Введите \"да\" или \"нет\" ");
                string hasPet = Console.ReadLine();
                bool isNumber = int.TryParse(hasPet, out int number);
               

                if (!isNumber  && hasPet == "да")
                {
                    int intPetCount;
                    string petCount;
                    do
                    {
                        Console.WriteLine("Напишите их количество");
                        petCount = Console.ReadLine();
                    }
                    while (CheckNum(petCount, out intPetCount));
                    User.PetNames = PetName(intPetCount);
                    break;
                }
                else if ((!isNumber == true && number > 0) && hasPet == "нет")
                {
                    User.PetNames = null;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите \"да\" или \"нет\" ");
                    User.PetNames = null;
                }

                
            }
            while (isOpen);

            string colorCount;
            int intcolorCount;
            do
            {
                Console.WriteLine("Введите количество любимых цветов");
                colorCount = Console.ReadLine();
            }
            while (CheckNum(colorCount, out intcolorCount));
            User.Colors = Colors(intcolorCount);


            return User;



        }
        static string[] PetName(int petCount)
        {
            string[] Pets = new string[petCount];
            for (int i = 0; i < Pets.Length; i++)
            {
                Console.WriteLine($"Введите кличку {i + 1}-го питомца");
                Pets[i] = Console.ReadLine();
            }
            return Pets;
        }
        static string[] Colors(int colorCount)
        {
            string[] Colors = new string[colorCount];
            for (int i = 0; i < Colors.Length; i++)
            {
                Console.WriteLine($"Введите название {i + 1}-го цвета");
                Colors[i] = Console.ReadLine();
            }
            return Colors;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }

        }
        static void ShowData((string Name, string LastName, int Аge, string[] PetNames, string[] Colors) User)
        {
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine($"Ваши данные:\nИмя: {User.Name}\nФамилия: {User.LastName}\nВозраст: {User.Аge}\n");
            Console.WriteLine("Питомцы:");
            for (int i = 0; i < User.PetNames.Length; i++)
            {
                Console.WriteLine(User.PetNames[i]);
            }
            Console.WriteLine("\nЛюбимые цвета:");
            for (int i = 0; i < User.Colors.Length; i++)
            {
                Console.WriteLine(User.Colors[i]);
            }
        }

    }

}
