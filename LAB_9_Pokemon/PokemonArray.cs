using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_Pokemon
{
    public class PokemonArray
    {
        static Random rnd = new Random();
        Pokemon[] pokemons;
        public int Length
        {
            get=> pokemons.Length;
        }
        public PokemonArray() //конструктор без параметров по умолчанию создаёт одного покемона
        {
            pokemons = new Pokemon[1];
        }
        public PokemonArray(int length) //конструктор с параметром, заполняет статы рандомно
        {
            pokemons = new Pokemon[length];
            for (int i = 0; i < length; i++)
                pokemons[i] = new Pokemon(rnd.Next(7,414), rnd.Next(32,396), rnd.Next(1,496));
        }
        public PokemonArray(int length, bool input) //конструктор с параметрами, статы заполняются с клавиатуры
        {
            pokemons = new Pokemon[length];
            int[] attack = new int[length]; //инициализация массива атаки для записи 
            int[] defense = new int[length];
            int[] stamina = new int[length];

            for (int i = 0; i < length; i++)
            {                
                Console.WriteLine($"Введите характеристики для покемона {i + 1}:");
                Console.Write("Атака: ");
                attack[i] = int.Parse(Console.ReadLine());

                Console.Write("Защита: ");
                defense[i] = int.Parse(Console.ReadLine());

                Console.Write("Выносливость: ");
                stamina[i] = int.Parse(Console.ReadLine());

                pokemons[i] = new Pokemon(attack[i], defense[i], stamina[i]);
            }
        }
        public PokemonArray(PokemonArray other) //конструктор глубокого копирования
        {
            this.pokemons = new Pokemon[other.Length];
            for (int i = 0; i < other.Length; i++)
                pokemons[i] = new Pokemon(other.pokemons[i]);
        }
        public void Show()
        {
            Console.WriteLine("Покемоны в коллекции:");
            for (int i = 0; i < pokemons.Length; i++)
                Console.WriteLine(pokemons[i].ToString());
        }
        public Pokemon this[int index]
        {
            get
            {
                if (0 <= index && index < pokemons.Length)
                    return pokemons[index];
                else
                    throw new Exception();
            }

            set
            {
                if (0 <= index && index < pokemons.Length)
                    pokemons[index] = value;
                else
                    throw new Exception();
            }
        }
    }
}
