using Game.Interface;

namespace GameProject
{
    class Player2 : iPlayer
    {
        public string _Name { get; set; }

        public Player2()
        {
        }
        public Player2(string nome)
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
