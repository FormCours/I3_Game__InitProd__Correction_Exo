// - Liste de tache
/*
{
    List<string> taches = new List<string>();
    string choix;

    do
    {
        Console.WriteLine("Veuillez selectionner une option (Utilisateur sympa) : ");
        Console.WriteLine(" 1) Ajouter une nouvelle tache");
        Console.WriteLine(" 2) Visualiser les taches");
        Console.WriteLine(" 3) Effacer toutes les taches");
        Console.WriteLine(" 0) Quitter");
        Console.Write("> ");

        choix = Console.ReadLine() ?? "0";
        Console.WriteLine();

        switch (choix)
        {
            case "1":
                Console.Write("Tache à ajouter\n> ");
                string tacheAAjouter = Console.ReadLine()!;
                taches.Add(tacheAAjouter);
                break;
            case "2":
                if (taches.Count > 0)
                {
                    Console.WriteLine("Liste des taches : ");
                    foreach (string tache in taches)
                    {
                        Console.WriteLine($"- {tache}");
                    }
                }
                else
                {
                    Console.WriteLine("Il n'y a point de taches (┬┬_┬┬)");
                }
                break;
            case "3":
                taches.Clear();
                Console.WriteLine("Toutes les taches ont été effacé !");
                break;
            default:
                Console.WriteLine("Votre choix est invalide ! Boulet !");
                break;
        }
        Console.WriteLine();
    }
    while (choix != "0");

    Console.WriteLine("Au revoir !");
}
*/


// Compter les voyelles d'un mot 
/*
{
    Dictionary<char, int> dico = new Dictionary<char, int>();
    char[] voyelles = ['a', 'e', 'i', 'u', 'o', 'y'];
    foreach(char voyelle in voyelles)
    {
        dico.Add(voyelle, 0);
    }

    Console.Write("Veuillez encoder une phrase\n > ");
    string phrase = Console.ReadLine()!.ToLower();
    Console.WriteLine();

    foreach(char lettre in phrase)
    {
        if(dico.ContainsKey(lettre))
        {
            dico[lettre]++;
        }
    }

    Console.WriteLine("Les voyelles suivantes ont été trouvées : ");
    foreach(KeyValuePair<char, int> item in dico)
    {
        if(item.Value > 0)
        {
            Console.WriteLine($" - {item.Key} : {item.Value}");
        }
    }
}
*/

// Application de scoring
{
    // 1) Saisie des noms des joueuses (Unique)
    List<string> joueuses = new List<string>();
    const string STOP_KEY = "STOP";
    Console.WriteLine($"Veuillez encoder le nom des joueuses (\"{STOP_KEY}\" pour arrêter)");
    string nom;
    do
    {
        Console.Write("> ");
        nom = Console.ReadLine()!.ToUpper();
        if (nom != STOP_KEY)
        {
            if (!joueuses.Contains(nom))
            {
                joueuses.Add(nom);
                Console.WriteLine("La joueuse ajoutée ! Ajouter une autre ?");
            }
            else
            {
                Console.WriteLine("La joueuse est déjà encodée ! Essai encore");
            }
        }
    }
    while (nom != STOP_KEY);
    Console.WriteLine();


    // 2) Information pour la partie
    Console.WriteLine("Nombre de manche (Entier positif)");
    int nbManche;
    bool estValide;
    do
    {
        Console.Write("> ");
        estValide = int.TryParse(Console.ReadLine(), out nbManche);
    }
    while (!estValide || nbManche < 1);
    Console.WriteLine();


    // 3) Création du dico pour la partie (Fiche de score)
    Dictionary<string, int[]> scores = new Dictionary<string, int[]>();
    foreach (string joueuse in joueuses)
    {
        scores.Add(joueuse, new int[nbManche]);
    }


    // 4) Saisie des scores par manche
    int indexManche = 0;
    do
    {
        // 4.1) Annonce de la manche
        Console.WriteLine($"Score pour la manche {indexManche + 1}");

        // 4.2) Encode le score de chaque joueuse (Monde des bisounours -> Encodage correct !)
        for (int i = 0; i < joueuses.Count; i++)
        {
            // - Récuperation de la joueuse ciblée
            string joueuseCible = joueuses[i];

            // - Demande le score de la joueuse
            Console.Write($" - ${joueuseCible} : ");
            int scoreCible = int.Parse(Console.ReadLine()!);

            // - Sauvegarde du score dans l'objet "scores"
            int[] ligneScoreDeLaJoueuse = scores[joueuseCible];
            ligneScoreDeLaJoueuse[indexManche] = scoreCible;
        }

        // 4.3) On passe à la manche suivante
        indexManche++;

    } while (indexManche < nbManche);
    Console.WriteLine();

    // 5) Affichage des resultats

    // 5.0) Calculer le score total de chaque joueuses
    Dictionary<string, int> scoreFinaux = new Dictionary<string, int>();
    foreach (var ligne in scores)
    {
        // - Pour rendre le code lisible (variable nommé)
        string joueuse = ligne.Key;
        int[] ligneScore = ligne.Value;

        // - Calculer le score total
        int scoreTotal = ligneScore.Sum(); // Boucle caché !

        // - Sauvegarde du score dans "scoreFinaux"
        scoreFinaux.Add(joueuse, scoreTotal);
    }

    // 5.1) La gagnante (voir les gagnantes)
    // - Obtenir le meilleur score
    int meilleurScore = scoreFinaux.Values.Min();

    // - Obtenir la joueuse (ou les joueuses) avec le meilleur score
    Console.WriteLine($"Avec le score de {meilleurScore}, les gagnantes sont : ");
    foreach(var elem in scoreFinaux)
    {
        if(elem.Value == meilleurScore)
        {
            Console.WriteLine($" - {elem.Key}");
        }
    }

    // 5.2) Le classement des joueurs
    int[] classementScore = scoreFinaux.Values.ToArray();
    string[] classementJoueuse = scoreFinaux.Keys.ToArray();

    for (int k = 0; k < classementScore.Length; k++)
    {
        for (int i = 0; i < (classementScore.Length - k - 1); i++)
        {
            int score1 = classementScore[i];
            int score2 = classementScore[i + 1];

            if (score1 > score2)
            {
                // Tri le score
                classementScore[i] = score2;
                classementScore[i + 1] = score1;

                // Inverse les joueurs pour les synchroniser au classementScore
                string temp = classementJoueuse[i];              // Copie backup
                classementJoueuse[i] = classementJoueuse[i + 1]; // Modifie la joueuse 1 (lier au score1)
                classementJoueuse[i + 1] = temp;                 // Modifie la joueuse 2 (via le backup)
            }
        }
    }



}