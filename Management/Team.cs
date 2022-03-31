using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Team
    {
        byte Teamid;
        string Name;
        string Abbr;
        string Logo;

        public void Set(byte Teamid)
        {
            this.Teamid = Teamid;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetAbbr(string Abbr)
        {
            this.Abbr = Abbr;
        }

        public void SetLogo(string Logo)
        {
            this.Logo = Logo;
        }
    }
}
