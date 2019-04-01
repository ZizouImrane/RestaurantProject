using System;
namespace RestaurantProject
{
    public class Restaurant_C : Restaurant_B
    {

        // Attributs
        protected int nb_serveur;

        // Constructeur

        public Restaurant_C(string nom, string adresse, string heure_o, string heure_f, int nb_ouvrier) : base(nom, adresse, heure_o, heure_f, nb_ouvrier)
        {
        }

        public Restaurant_C()
        {
            this.nom = "Default_C";
            this.adresse = "2 2 2";
            this.heure_o = "2222";
            this.heure_f = "7777";
            this.nb_ouvrier = 0;
            this.nb_chef = 0;
            this.nb_serveur = 0;
        }

        // Méthodes
        override
        public string ToString()
        {
            return "Le nom de mon restaurant est " + nom + ", je suis situé au " + adresse + ", j'ouvre à " + heure_o + " et je ferme à " + heure_f + ". Je dispose de " + nb_ouvrier + " ouvriers. Il y a " + nb_chef + " chefs et "+nb_serveur+" serveurs dans mon restaurant.\n";
        }

        override
        public string ChargeSalariale()
        {
            return "Charge salariale du restaurant " + nom + " : " + (70 * nb_ouvrier + 110 * nb_chef+85*nb_serveur) + "€\n";
        }


        // Accesseur Mutateur
        public int Nb_serveur { get => nb_serveur; set => nb_serveur = value; }

    }
}
