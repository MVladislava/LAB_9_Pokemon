using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_Pokemon
{
    public class Pokemon
    {
        private int attack; //закрытый атрибут
        private int defense;
        private int stamina;
        static int count = 0;
        public int Attack { get => attack;
            set
            {
                attack = (value >= 17 && value <= 414) ? value : 17; //тернарный оператор
            }
        }
        public int Defense { get => defense;
            set
            {
                defense = (value >= 32 && value <= 396) ? value : 32;
            }
        }

        public int Stamina { get => stamina;
            set
            {
                stamina = (value >= 1 && value <= 496) ? value : 1;
            }
        }
        public Pokemon() : this(17, 32, 1) { } //конструктор без параметров - дефолтные параметры покемона

        public Pokemon(int attack, int defense, int stamina) //конструктор с параметрами
        {
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
            count++;
        }
        public Pokemon(Pokemon pokemon) //констурктор копирования
        {
            Attack = pokemon.attack;
            Defense = pokemon.defense;
            Stamina = pokemon.stamina;
        }
        public void AddParam(int attack, int defense, int stamina)
        {
            this.Attack += attack;
            this.Defense += defense;
            this.Stamina += stamina;
        }
        public static void AddParam(Pokemon pokemon, int attack, int defense, int stamina)
        {
            pokemon.Attack += attack;
            pokemon.Defense += defense;
            pokemon.Stamina += stamina;
        }
        public static int GetCount => count; //подсчёт кол-ва объектов класса
        public double CombatPower // унарная операция - боевая мощь покемона
        {
            get => Math.Round((Math.Sqrt(stamina) * attack * Math.Sqrt(defense)) / 10, 2); //округление до сотых
        }
        public static double operator ~(Pokemon pokemon)
        {
            return pokemon.CombatPower;
        }
        public static Pokemon operator --(Pokemon pokemon) //унарная операция - уменьшение выносливости покемона на 1
        {
            pokemon.Stamina--;
            return pokemon;
        }

        public static explicit operator int(Pokemon pokemon) //явная операция приведения типа
        {
            return (pokemon.attack + pokemon.defense + pokemon.stamina);
        }
        public static implicit operator double(Pokemon pokemon) //неявная операция приведения типа
        {
            double meanValue = (pokemon.attack + pokemon.defense + pokemon.stamina) / 3.0 ;
            return  Math.Round(meanValue, 2);
        }
        // Перегруженые бинарные операции
        public static Pokemon operator >> (Pokemon p, int value)
        {
            p.stamina += value;
            return p;
        }
        public static Pokemon operator > (Pokemon p, int value)
        {
            p.defense += value;
            return p;
        }
        public static Pokemon operator < (Pokemon p, int value)
        {
            p.Attack += value;
            return p;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Pokemon other = (Pokemon)obj;
            return Attack == other.Attack && Defense == other.Defense && Stamina == other.Stamina;
        }
        public override string ToString()
        {
            return $@"Статы покемона:
Атака: {Attack}
Защита: {Defense}
Выносливость {Stamina}";
        }
    }
}
