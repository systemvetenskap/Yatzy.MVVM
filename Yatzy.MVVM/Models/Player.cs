

using System.ComponentModel;
using System.Net.Http.Headers;

namespace Yatzy.MVVM
{
    public class Player : BaseViewModel, IPlayer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
