using System;


namespace GameProject
{
    class Game
    {
        public readonly iPlayer _player1;
        public readonly iPlayer _player2;

        public Game(iPlayer player1, iPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void StartGame()
        {
            Console.Write(_player1.Pass());
            Console.Write(_player1.Shot());
            Console.Write(_player1.Run());

            System.Console.WriteLine("\n Próximo Jogador \n");
            
            Console.Write(_player2.Pass());
            Console.Write(_player2.Shot());
            Console.Write(_player2.Run());
        }
    }
}