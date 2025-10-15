using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class ChangedEventArgs : EventArgs
    {
        public string Verbijzondering { get; set; } = "";
    }
    public class CountEventArgs : EventArgs
    {
        public int Count { get; set; }
        public bool IsEven => Count % 2 == 0;
    }
}
