

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Yatzy.MVVM
{
    public class ScoreCardViewModel : BaseViewModel
    {
        //private IPlayer player;
        public IPlayer Player { get; set; }

        #region Public properties
        //public string Name { get; set; } = "Yasmine";
        //public string ButtonName { get; set; } = "Kasta tärningar"; 


        public string ButtonName { get; set; } = "Kasta tärningar";
       
        #endregion

        
        public ICommand RollDiceCommand { get; set; }

        public ScoreCardViewModel(IPlayer player)
        {
            

            Player = player;
            Player.Name = "Yasmine";
            RollDiceCommand = new RelayCommand(RollDice);
        }


        public void RollDice()
        {
            ButtonName = "Tärningen är kastad";
            Player.Name = "Erik";
        }

        
    }
}
