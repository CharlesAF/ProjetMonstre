using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonstre
{
    //classe de service
    static class De
    {
        private static Random valeurAleatoire = new Random();
        

        //Retourne une valeur aléatoire à chaque fois que la méthode statique est appelée
        public static int LanceLeDe()
        {
            return valeurAleatoire.Next(1,7);
        }

    }
}
