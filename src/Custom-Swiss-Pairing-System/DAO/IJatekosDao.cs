using Custom_Swiss_Pairing_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Swiss_Pairing_System.DAO
{
    internal interface IJatekosDao
    {
        bool addJatekos(Jatekos jatekos);

        IEnumerable<Jatekos> getJatekosok();

        bool modifyJatekos(Jatekos jatekos);

        bool deleteJatekos(Jatekos jatekos);

        Jatekos getJatekosById(long id);
        int countJatekos();
    }
}
