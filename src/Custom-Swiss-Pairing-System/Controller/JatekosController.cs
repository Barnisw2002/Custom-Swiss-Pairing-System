using Custom_Swiss_Pairing_System.DAO;
using Custom_Swiss_Pairing_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Swiss_Pairing_System.Controller
{
    public class JatekosController
    {
        private readonly IJatekosDao dao;
        internal JatekosController(IJatekosDao dao)
        {
            this.dao = dao;
        }

        internal bool addJatekos(Jatekos jatekos)
        {
            return dao.addJatekos(jatekos);
        }

        internal IEnumerable<Jatekos> getJatekosok()
        {
            return dao.getJatekosok();
        }

        internal bool modifyJatekos(Jatekos jatekos)
        {
            return dao.modifyJatekos(jatekos);
        }

        internal bool deleteJatekos(Jatekos jatekos)
        {
            return dao.deleteJatekos(jatekos);
        }
    }
}
