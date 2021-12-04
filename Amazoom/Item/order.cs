using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    public class order
    {
        public volatile List<goods> which = new List<goods>();
        public volatile List<int> timeorder = new List<int>();
        public volatile List<int> howmany = new List<int>();

        public order(List<goods> which, List<int> timeorder, List<int> howmany)
        {

            this.which = which;
            this.timeorder = timeorder;
            this.howmany = howmany;
        }



    }
}
