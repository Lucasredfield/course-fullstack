using System;

namespace GameConsole
{
    class Player
    {
        public string _Name { get; set; }

        public Player(string name){
            _Name = name;    
        }

        public void Shot()
        {
            Console.Write($"{_Name} está chutando");
        }
        public void Run()
        {
            Console.Write($"{_Name} está correndo");
        }
        public void Pass()
        {
            Console.Write($"{_Name} está passando");
        }
    }
}
