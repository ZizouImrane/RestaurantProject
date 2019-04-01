using System;
namespace RestaurantProject
{
    public class Restaurant
    {

        // Attributs
        protected string nom;
        protected string adresse;
        protected string heure_o;
        protected string heure_f;
        protected int nb_ouvrier;

        // Constructeurs
        public Restaurant(string nom, string adresse, string heure_o, string heure_f, int nb_ouvrier)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.heure_o = heure_o;
            this.heure_f = heure_f;
            this.nb_ouvrier = nb_ouvrier;
            
        }

        public Restaurant()
        {
            this.nom = "Default";
            this.adresse = "0 0 0";
            this.heure_o = "0000";
            this.heure_f = "9999";
            this.nb_ouvrier = 0;
        }

        // Methodes
        override
        public string ToString()
        {
            return "Le nom de mon restaurant est " + nom +", je suis situé au "+ adresse +", j'ouvre à "+ heure_o +" et je ferme à "+heure_f+". Je dispose de "+ nb_ouvrier+ " ouvriers.\n";
        }

        public virtual string ChargeSalariale()
        {
            return "Charge salariale du restaurant " + nom + " : " + 70 * nb_ouvrier+"€\n";
        }

        // Accesseurs Mutateurs

        public string Nom { get => nom; set => nom = value; }

        public string Adresse { get => adresse; set => adresse = value; }

        public string Heure_o { get => heure_o; set => heure_o = value; }

        public string Heure_f { get => heure_f; set => heure_f = value; }

        public int Nb_ouvrier { get => nb_ouvrier; set => nb_ouvrier = value; }


    }
}
