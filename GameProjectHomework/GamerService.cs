using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectHomework
{
    class GamerService
    {
        public void GamerAdd(GamerProfile addGamer)
        {
            Console.WriteLine(addGamer.GamerName + "  " + addGamer.GamerLastName + "  " + "Gamer added succesfully!");
        }

        public void GamerUptade(GamerProfile uptadeProfile)
        {
            Console.WriteLine(uptadeProfile.GamerName + "  " + uptadeProfile.GamerLastName + "  " + "uptaded succesfully!");
        }

        public void GamerDelete(GamerProfile deleteProfile)
        {
            Console.WriteLine(deleteProfile.GamerName + "  " + deleteProfile.GamerLastName + "  " + "deleted succesfully!");
        }
    }
}
