using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJarApi.Model
{
    public class Coin
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
