using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame_Simran
{
// the below given method are abtract method that inherits from the main class
    public class simm {

        public int increment(int budget, int amunt)
        {
            return budget + amunt;
        }
        public int deccrement(int budget, int amunt)
        {
            return budget - amunt;
        }
    }

    //inheirtn the pri class to increment or decrement format 
   public class Prii:simm
    {
        public int increment(int budget, int amunt)
        {
            return budget + amunt;
        }
        public int deccrement(int budget, int amunt)
        {
            return budget - amunt;
        }

    }

    //abtract methods

    public class mann:Prii
    {
        public  int increment(int budget, int amunt)
        {
            return budget + amunt;
        }
        public  int deccrement(int budget, int amunt)
        {
            return budget - amunt;
        }


    }
}
