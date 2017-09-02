using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuMonstreÉquipe
{
    class Joueur
    {
        public De deAttaque = new De();
        public bool estVivant;
        public int pointDeVie{get { return this.pointDeVie; } set { this.pointDeVie = value; }}

        // Constructeur sans argument
        public Joueur()
        {
            this.estVivant = true;
            this.pointDeVie = 150;
        }
        // Méthode

        public bool Attaque(MonstreFacile monstre)
        // Retourne true si l'attaque du joueur fonctionne
        {
            int attaqueJoueur = this.deAttaque.LancerLeDe();
            int attaqueMonstre = monstre.deAttaque.LancerLeDe();
            if (attaqueJoueur >= attaqueMonstre) return true;
            else return false;
        }

        public void SubitDegats(int degat)
        //Retourne true si le joueur subit des dégats
        {
            if (!this.DefenceBouclier())
            {
                this.pointDeVie -= degat;
                if (this.pointDeVie <= 0) this.estVivant = false;
            }
        }
        public bool DefenceBouclier()
        // Retourne true si le bouclier réussi a défendre l'attaque
        {
            int tirage = this.deAttaque.LancerLeDe();
            if (tirage <= 2) return true;
            else return false;
        }
    }
}
