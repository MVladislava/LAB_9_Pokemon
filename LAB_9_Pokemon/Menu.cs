using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LAB_9_Pokemon
{
    public class Menu
    {
        public void MenuChoise()
        {
            Console.WriteLine($@" Меню:
1. Увеличить параметры покемона с помощью не статического метода
2. Увеличить статы покемона с помощью статического метода
3. Количество объектов типа Pokemon
4. Боевая мощь покемона
5. Сумма всех статов покемона
6. Среднее значение статов покемона
7. Бинарные операции увеличения статов покемона
8. Глубокое копирование
9. Статы с клавиатуры
10. 4 варианта работы индексатора");
        }
    }
}
