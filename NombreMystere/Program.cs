// See https://aka.ms/new-console-template for more information
Console.WriteLine(" BienVenu au Jeu \"NombreMystere!\"");
const int  NbreMystere = 20;
int nbSaisie; 
bool gagne = false;
Console.WriteLine("Prénom du Joueur !");
string prenom = Console.ReadLine();

while(!gagne)
{
       Console.WriteLine($"{prenom} vous pouvez deviner le nombre mystère entre 1 et 30 !");
       nbSaisie  = int.Parse(Console.ReadLine());
       if(nbSaisie == NbreMystere)
       {
          Console.WriteLine("vous avez gagné !");
          gagne = true;
       }else
       {
  
            if(nbSaisie >NbreMystere)
            {
                 Console.WriteLine("le nombre mystère est plus petit");
            }else
            {
                Console.WriteLine("le nombre mystere est plus grand");
            }
       }
}