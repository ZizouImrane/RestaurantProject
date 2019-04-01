using System;

namespace RestaurantProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre programme pour gérer vos 3 restaurants.\n");

            Restaurant r = new Restaurant
            {
                Nom = "L'Élysée",
                Adresse = "40 rue du Faubourg, 75010",
                Heure_o = "10h",
                Heure_f = "23h",
                Nb_ouvrier = 34
            };

            Restaurant p = new Restaurant_B
            {
                Nom = "Mozaik",
                Adresse = " 20 rue Pierre, 93380",
                Heure_o = "9h",
                Heure_f = "5h",
                Nb_ouvrier = 13,
                Nb_chef = 2
            };

            Restaurant h = new Restaurant_C
            {
                Nom = "La Rue",
                Adresse="6 rue d'Herbeval, 60100",
                Heure_o="12h",
                Heure_f="00h",
                Nb_ouvrier=17,
                Nb_chef=3,
                Nb_serveur=10
            };

            Console.WriteLine(r.ToString());
            Console.WriteLine(r.ChargeSalariale());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.ChargeSalariale());
            Console.WriteLine(h.ToString());
            Console.WriteLine(h.ChargeSalariale());

        }
    }
}
