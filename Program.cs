using System;
using GameProject;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameProject.Game(new Player1("Dan"),new Player2("Teste"), new Player3("Jorge"));              
        
            game.StartGame();
            Console.Read();
        }
    }
}