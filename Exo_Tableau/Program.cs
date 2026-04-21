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
{
    Dictionary<char, int> dico = new Dictionary<char, int>();
    dico.Add('a', 0);
    dico.Add('e', 0);
    dico.Add('i', 0);
    dico.Add('o', 0);
    dico.Add('u', 0);
    dico.Add('y', 0);

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