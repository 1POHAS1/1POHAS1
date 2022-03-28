using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Player
    {
        byte Playerld;
        String Name;
        byte positionald;
        String joinYear;
        double height;
        double weidth;
        String dateBirth;
        String country;
        String gender;

        public void Set(byte Playerld, String Name, byte positionald, String joinYear, double height, double weigth, String dateBirth, String country, String gender)
        {
            this.Playerld = Playerld;
            this.Name = Name;
            this.positionald = positionald;
            this.joinYear = joinYear;
            this.height = height;
            this.weidth = weigth;
            this.dateBirth = dateBirth;
            this.country = country;
            this.gender = gender;
        }

    }
}
