using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_zach
{
    public class Groups
    {
       public byte StudentId;
        public string Shifr;
       public string Napravl;

        public void Set(byte StudentId, string Shifr, string Napravl)
        {
            this.StudentId = StudentId;
            this.Shifr = Shifr;
            this.Napravl = Napravl;
        }
    }
}
