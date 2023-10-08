// See https://aka.ms/new-console-template for more information
Console.WriteLine(" BienVenu au Jeu \"NombreMystere!\"");
const int NbreMystere = 20;
int nbSaisie;
bool gagne = false;
List<int> chiffresJoues = new List<int>();
string resultat = "";
Console.WriteLine("Prénom du Joueur !");
string prenom = Console.ReadLine();

while (!gagne)
{
     Console.Clear();
     Console.Write("Nombre déjà Joué ! ");
     foreach (var n in chiffresJoues)
     {
          Console.Write($" {n} ");
     }
     Console.WriteLine("");
     Console.WriteLine(resultat);
     Console.WriteLine($"{prenom} vous pouvez deviner le nombre mystère entre 1 et 30 !");

     nbSaisie = int.Parse(Console.ReadLine());

     chiffresJoues.Add(nbSaisie);
     if (nbSaisie == NbreMystere)
     {
          Console.WriteLine("vous avez gagné !");
          gagne = true;
     }
     else
     {


          if (nbSaisie > NbreMystere)
          {
               resultat = $"le nombre mystère est plus petit que {nbSaisie}";
          }
          else
          {
              resultat= $"le nombre mystere est plus grand que {nbSaisie}";
          }
     }
}