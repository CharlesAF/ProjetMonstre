using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonstre
{
    class MonstreFacile
    {
        public bool EstVivant { get; private set; }
        private const int FORCE = 10;   //Dégats qu'un monstreFacile inflige lorsqu'il attaque

        public MonstreFacile()
        {
            this.EstVivant = true;
        }

        public void Attaque(Joueur joueur)
        {
            int lanceJoueur = joueur.LanceLeDe();
            int lanceMonstre = this.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
            {
                joueur.SubitDegats(FORCE);
            }

        }

        public void SubitDegats()
        {
            this.EstVivant = false;
        }

        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }
    }
}
