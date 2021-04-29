/*jeu du unombre cache*/

using System;

namespace NombreCache
{
    class Program
    {

        static int essai;

        /* Création d'un module pour simplifié et aére donc eviter la repetition de code */
        static void saisie()
        {
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
        }

        static void Main(string[] args)
        {

            /* déclaration des variables*/
            int valeur = 0, nbre = 1;
            essai = 0;
            bool correct = false;
            /* saisie du nombre à chercher*/
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
            Console.Clear();

            /*saisie du premier essai en appellant le module "saisie"*/
            saisie();

            /* boucle sur les essais*/
            while (essai != valeur)
            {
                /* test de l'essai par rapport à la valeur à chercher*/
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }

                /*saisie d'un nouvel essai en appellant encore une fois le module "saisie"*/
                saisie();

                /*compteur d'essais*/
                nbre++;

            }

            /*valeur trouvée*/
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}
