using System.Dynamic;
using System.Diagnostics;
using Game.Interface;

namespace GameProject
{
    public class Player3 : iPlayer
    {
        public string _Name { get; set; }

        public Player3()
        {
        }
        public Player3(string nome)
        {
            _Name = nome;
        }
        public string Pass()
        {
            return $"\n {_Name} no Passe";
        }

        public string Run()
        {
            return $"\n {_Name} no Corre";
        }

        public string Shot()
        {
            return $"\n {_Name} no chute";
        }
    }
}