using System;
namespace RestaurantProject
{
    public class Restaurant_B : Restaurant
    {

        // Attributs
        protected int nb_chef;

        public Restaurant_B(string nom, string adresse, string heure_o, string heure_f, int nb_ouvrier) : base(nom, adresse, heure_o, heure_f, nb_ouvrier)
        {
        }

        public Restaurant_B()
        {
            this.nom = "Default_B";
            this.adresse = "1 1 1";
            this.heure_o = "1111";
            this.heure_f = "8888";
            this.nb_ouvrier = 0;
            this.nb_chef = 0;
        }
        // Methodes
        override
        public string ToString()
        {
            return "Le nom de mon restaurant est " + nom + ", je suis situé au " + adresse + ", j'ouvre à " + heure_o + " et je ferme à " + heure_f + ". Je dispose de " + nb_ouvrier + " ouvriers. Il y a "+nb_chef+" chefs dans mon restaurant.\n";
        }

        override
        public string ChargeSalariale()
        {
            return "Charge salariale du restaurant " + nom + " : " + (70 * nb_ouvrier+110*nb_chef) + "€\n";
        }




        // Accesseurs Mutateurs
        public int Nb_chef { get => nb_chef; set => nb_chef = value; }
    }
}
