using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Player
    {
        byte PlayerId;
        String Name;
        byte positionaId;
        String joinYear;
        double height;
        double weidth;
        String dateBirth;
        String country;
        String gender;

        public void Set(byte PlayerId, String Name, byte positionaId, String joinYear, double height, double weigth, String dateBirth, String country, String gender)
        {
            this.PlayerId = PlayerId;
            this.Name = Name;
            this.positionaId = positionaId;
            this.joinYear = joinYear;
            this.height = height;
            this.weidth = weigth;
            this.dateBirth = dateBirth;
            this.country = country;
            this.gender = gender;
        }

    }
}
