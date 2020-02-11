using System;
using Game.Interface;


namespace GameProject
{
    class Player1 : iPlayer
    {
        public string _Name { get; set; }

        public Player1()
        {
        }
        public Player1(string nome)
        {
            _Name = nome;
        }

        public string Shot()
        {
           return $"\n {_Name} está chutando";
        }
        public string Run()
        {
            return $"\n {_Name} está correndo";
        } 
        public string Pass()
        {
            return $"\n {_Name} está passando";
        }
    }
}
