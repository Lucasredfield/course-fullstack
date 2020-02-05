using System;

namespace GameConsole
{
    class Program
    {
        class Game
        {
            private readonly string _Name;

            public Game(string name)
            {
                _Name = name;
            }

            public void StartGame()
            {
                Console.WriteLine($"{_Name} deu um passe");
            }
        }
        static void Main(string[] args)
        {
            var game = new Game("Lucas");
            game.StartGame();
        }
    }


}