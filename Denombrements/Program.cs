using System;

namespace Denombrements
{
    /// <summary>
    /// Ce code permet d'effectuer trois types de calcul (permutation, arrangement, combinaison).
    /// </summary>
    class Program
    {
        /// <summary>
        /// Fonction qui calcule le produit d'une suite d'entiers de 'début' jusqu'à 'total'
        /// </summary>
        /// <param name="debut">Valeur correspondant au début du calcul</param>
        /// <param name="total">Valeur correspondant à la fin du calcul</param>
        /// <returns>Retourne le résultat du produit</returns>
        static long MultiplierPourSuite(long debut, long total)
        {
            long r = 1;
            for (long k = debut; k <= total; k++)
            {
                r *= k;
            }
            return r;
        }

        /// <summary>
        /// Menu permettant de choisir entre les trois calculs puis de les effectuer
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());

                        if (choix == "1")
                        {
                            long permutation = MultiplierPourSuite(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int sousEnsemble = int.Parse(Console.ReadLine());

                            long arrangement = MultiplierPourSuite(nbTotal - sousEnsemble + 1, nbTotal);

                            if (choix == "2")
                            {
                                // Correction ici : on affiche bien 'arrangement' et non 'nbTotal'
                                Console.WriteLine("A(" + nbTotal + "/" + sousEnsemble + ") = " + arrangement);
                            }
                            else
                            {
                                long combinaison = arrangement / MultiplierPourSuite(1, sousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + sousEnsemble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible, les valeurs sont incorrectes.");
                    }
                }
            }
        }
    }
}
