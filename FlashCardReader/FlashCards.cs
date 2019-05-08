using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardReader
{
    public class FlashCard
    {
        public string Front { get; set; }
        public string Back { get; set; }

        public FlashCard(string f, string b)
        {
            Front = f;
            Back = b;
        }
    }
}
