using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myJukebox
{
    public class Genre
    {
        public string Name { get; set; }
        public List<string> Tracks { get; } = new List<string>();
    }
}
