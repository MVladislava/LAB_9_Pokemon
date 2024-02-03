using LAB_9_Pokemon;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace LAB_9_Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon();
            PokemonArray pokemonArray1 = new PokemonArray();
            pokemonArray1.Show();
            Console.WriteLine(pikachu.ToString());
            Menu choise = new Menu();
            Pokemon eevee = new Pokemon(20, 20, 56);
            Console.WriteLine(eevee.ToString());
            while (true)
            {
                choise.MenuChoise();
                var str = Console.ReadLine();
                int i = int.Parse(str);
                Console.Clear();
                switch (i)
                {
                    case 1: // увеличение параметров с помощью не статического метода класса - привязан к объекту и требует его создания для вызова
                        Console.WriteLine(pikachu.ToString());
                        pikachu.AddParam(103, 200, 10);
                        Console.WriteLine("\nНовые статы Пикачу:");
                        Console.WriteLine(pikachu.ToString());
                        break;
                    case 2: //увеличение параметров с помощью статической функции - привязан к классу, следовательно может быть вызван без создания экземпляра класса
                        Console.WriteLine(pikachu.ToString());
                        Pokemon.AddParam(pikachu, 10, 10, 10);
                        Console.WriteLine("\nНовые статы Пикачу:");
                        Console.WriteLine(pikachu.ToString());
                        break;
                    case 3: //вывод количества объектов типа покемон
                        Console.WriteLine(Pokemon.GetCount);
                        break;
                    case 4: // унарный оператор боевой мощи покемона
                        double comPower = ~eevee;
                        Console.WriteLine($"\nБоевая мощь Eevee: {comPower}");
                        Console.WriteLine($"Стамина Eevee: {eevee.Stamina}");
                        --eevee;
                        Console.WriteLine($"\nУменьшаем выносливось Eevee на 1: {eevee.Stamina}");

                        break;
                    case 5:
                        Console.WriteLine(pikachu.ToString());
                        int totalStats = (int)pikachu;
                        Console.WriteLine(totalStats);
                        break;
                    case 6:
                        Console.WriteLine(pikachu.ToString());
                        double meanStats = pikachu;
                        Console.WriteLine(meanStats);
                        break;
                    case 7:
                        Console.WriteLine(pikachu.ToString());
                        pikachu = pikachu >> 10; //увеличиваем стамину на 10 
                        pikachu = pikachu > 5; //увеличивает защиту на 5
                        pikachu = pikachu < 20; //увеличивает атаку на 10
                        Console.WriteLine("Новые статы покемона: ");
                        Console.WriteLine(pikachu.ToString());
                        break;
                    case 8: //глубокое копирование
                        PokemonArray myPokemons = new PokemonArray(2); //покемоны с рандомными статами
                        myPokemons.Show();

                        Console.WriteLine("\nПростое копирование объектов");
                        PokemonArray psyduck = new PokemonArray(myPokemons); //копирование статов 
                        psyduck.Show();

                        Console.WriteLine("\nГлубокое копирование объектов");
                        myPokemons[0] = new Pokemon(18, 100, 50);
                        Console.WriteLine("\nСтаты Джиглипуфа:");
                        myPokemons.Show();
                        Console.WriteLine("\nСтаты Псайдака:");
                        psyduck.Show();
                        break;
                    case 9:
                        Console.WriteLine("Введите количество покемонов:");
                        int length = int.Parse(Console.ReadLine());

                        PokemonArray pok = new PokemonArray(length,true);
                        pok.Show();
                        try //используем индексатор для отлова ошибок
                        {
                            Console.WriteLine("Характеристики покемона с индексом 1:");
                            Console.WriteLine(pok[1]); // получение значения по индексу

                            // изменение значения по индексу
                            pok[1] = new Pokemon(100, 200, 300);
                            Console.WriteLine("Новые характеристики покемона с индексом 1:");
                            Console.WriteLine(pok[1]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Создаём массив на 4 покемона");
                        PokemonArray pokemonArray = new PokemonArray(4);
                        
                        Console.WriteLine("Запись объекта с существующим индексом 2:");
                        try
                        {
                            pokemonArray[2] = new Pokemon();
                            pokemonArray.Show();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка: {e.Message}");
                        }

                        Console.WriteLine("\nЗапись объекта с несуществующим индексом 6:");
                        try
                        {
                            pokemonArray[6] = new Pokemon();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка: {e.Message}");
                        }

                        Console.WriteLine("\nПолучение объекта с существующим индексом 3:");
                        try
                        {
                            Console.WriteLine(pokemonArray[3]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка: {e.Message}");
                        }

                        Console.WriteLine("\nПолучение объекта с несуществующим индексом 10:");
                        try
                        {
                            Console.WriteLine(pokemonArray[10]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Ошибка: {e.Message}");
                        }

                        break;
                }
            }
            
        }
    }
}