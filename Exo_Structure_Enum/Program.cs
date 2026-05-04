using Exo_Structure_Enum.CustomEnums;
using Exo_Structure_Enum.Models;

// Exercice 1 — Encodage de pokemon
/*
{
    Console.WriteLine("Exo - Pokemon");
    Console.WriteLine("*************");
    Pokemon pokemon;

    // Encodage des données par l'utilisateur
    Console.WriteLine("Veuillez encoder votre pokemon : ");

    Console.Write("Nom : ");
    pokemon.Name = Console.ReadLine()!;

    Console.Write("Surnom : ");
    string surname = Console.ReadLine() ?? "";
    pokemon.Surname = (surname != "") ? surname : null;

    Console.Write("Id pokedex : ");
    pokemon.Id = int.Parse(Console.ReadLine()!);

    Console.Write("Point de vie : ");
    pokemon.Stats.HP = int.Parse(Console.ReadLine()!);

    Console.Write("Attaque : ");
    pokemon.Stats.Attack = int.Parse(Console.ReadLine()!);

    Console.Write("Défense : ");
    pokemon.Stats.Defence = int.Parse(Console.ReadLine()!);

    Console.Write("Attaque spécial : ");
    pokemon.Stats.AttackSpe = int.Parse(Console.ReadLine()!);

    Console.Write("Défense spécial : ");
    pokemon.Stats.DefenceSpe = int.Parse(Console.ReadLine()!);

    Console.Write("Vitesse : ");
    pokemon.Stats.Speed = int.Parse(Console.ReadLine()!);

    // Calculer la catégorie
    int statsTotal = pokemon.Stats.HP + pokemon.Stats.Attack + pokemon.Stats.Defence
                    + pokemon.Stats.AttackSpe + pokemon.Stats.DefenceSpe + pokemon.Stats.Speed;

    // - Définition de la categorie
    if(statsTotal < 400)
    {
        pokemon.Category = "Faible";
    }
    else if (statsTotal < 550)
    {
        pokemon.Category = "Moyen";
    }
    else if (statsTotal < 600)
    {
        pokemon.Category = "Fort";
    }
    else
    {
        pokemon.Category = "Très fort";
    }

    // - Ecriture alternative via une chaine de ternaire
    pokemon.Category = (statsTotal < 400) ? "Faible"
        : (statsTotal < 550) ? "Moyen"
        : (statsTotal < 600) ? "Fort"
        : "Très fort";

    // Affichage des données du pokemon
    Console.BackgroundColor = ConsoleColor.White;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Résumé de votre pokemon {pokemon.Surname ?? pokemon.Name}");

    Console.Write("- Pdv : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.HP);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("- Attaque : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.Attack);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("- Défense : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.Defence);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("- Attaque Spécial : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.AttackSpe);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("- Défense Spécial : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.DefenceSpe);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("- Vitesse : ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(pokemon.Stats.Speed);
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"La categorie de votre {pokemon.Name} est {pokemon.Category}");
    Console.ForegroundColor = ConsoleColor.Black;
}
*/

// Exercice 4 — Jeu de carte
{
    // Creation du deck de carte
    // - Initilisation d'un tableau de 52 carte
    Carte[] deck = new Carte[52];

    // - Parcours des valeurs de l'enum "CouleurCarte" (Attention au doublon)
    int i = 0;
    foreach (CouleurCarte couleur in Enum.GetValues<CouleurCarte>())
    {
        // - Parcours des valeurs de l'enum "ValeurCarte"
        foreach (ValeurCarte val in Enum.GetValues<ValeurCarte>())
        {
            // - Création de la carte
            Carte carte;
            carte.Valeur = val;
            carte.Couleur = couleur;

            // - Ajout de la carte dans le deck
            deck[i] = carte;
            i++;
        }
    }

    // Affichage du jeu de carte généré
    Console.WriteLine("Jeu de carte (Etat initial)");
    foreach (Carte carte in deck)
    {
        Console.WriteLine($" - {carte.Valeur} de {carte.Couleur}");
    }

    // Mélange des cartes (Non réaliste)
    // - Via un algo de tri modifié
    /*
    for (int m = 0; m < 1_000; m++)
    {
        for(int n = 0; n < deck.Length -1; n++)
        {
            if(Random.Shared.NextDouble() < 0.5)
            {
                Carte temp = deck[n];
                deck[n] = deck[n + 1];
                deck[n + 1] = temp;
            }
        }
    }
    */

    // - Via un 2e jeu
    List<Carte> tempDeck = new List<Carte>(deck);
    for(int m = 0; m <  deck.Length; m++)
    {
        int index = Random.Shared.Next(0, tempDeck.Count);

        Carte carte = tempDeck[index];
        tempDeck.RemoveAt(index);

        deck[m] = carte;
    }

    Console.WriteLine();

    // Affichage du jeu de carte mélangé
    Console.WriteLine("Jeu de carte (Etat final)");
    foreach (Carte carte in deck)
    {
        Console.WriteLine($" - {carte.Valeur} de {carte.Couleur}");
    }
}
