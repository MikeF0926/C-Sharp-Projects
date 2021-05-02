using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_twentyone
{
    public class TwentyOneDealer : Dealer //inherit from Dealer class
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
