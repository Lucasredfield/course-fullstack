using System;
using GameProject;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(
                new Player1("Lucas"),
                new Player2("Teste")
            );

            game.StartGame();
            Console.Read();
        }
    }
}