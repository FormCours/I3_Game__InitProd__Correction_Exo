# Exercice Collection - Suite


## 5) L'Inventaire de l'Aventurier
Un héros commence son aventure avec un sac à dos limité à 5 emplacements (type: string).
- Permettre à l'utilisateur de remplir chaque emplacement en encodant le nom d'un objet (ex: Épée, Potion, Bouclier).
- Une fois le sac plein, l'application doit :
  1. Afficher la liste complète des objets avec leur numéro d'index (de 0 à 4).
  2. Demander à l'utilisateur s'il veut remplacer un objet. 
     Si oui, l'utilisateur encode l'index de l'objet à remplacer et le nom du nouvel objet.
  3. Afficher l'inventaire mis à jour.


## 6) Le Bestiaire de Combat
Dans un jeu de rôle, le maître du jeu veut lister les monstres présents dans une zone.
* Utilisez une liste pour stocker les noms des monstres.
* Créez un menu en boucle qui propose :
  1. **Ajouter un monstre** : L'utilisateur entre un nom (ex: "Gobelin"), qui est ajouté à la liste.
  2. **Supprimer un monstre** : L'utilisateur entre le nom d'un monstre à retirer (si un monstre est vaincu).
  3. **Afficher le bestiaire** : Montrer tous les monstres et le nombre total de créatures présentes.
  4. **Quitter**.


## 7) File d'attente Multijoueur
Simulez la file d'attente d'un serveur de jeu massivement multijoueur (MMO).
- Créez une `Queue<string>` pour stocker les noms des joueurs en attente.
- Initialiser la collection avec 5 joueurs à la file au démarrage (ex: "Joueur_A", "Joueur_B", etc.).
- Créez un menu en boucle qui propose :
  1. **Prochain joueur** : Afficher qui est le prochain joueur à entrer sans le retirer de la file (Méthode `Peek`).
  2. **Faites entrer** : Retirer les deux premiers joueurs de la file (Méthode `Dequeue`) et affichez leur nom à l'écran.
  3. **Nouveau arrivant** : Ajouter un nouveau joueur dans la file d'attente.
  4. **Nombre de joueur** : Afficher le nombre de joueurs dans la file.


## 8) La Boutique d'équipement
Dans un jeu, le joueur intéragi avec le marchant de la boutique pour acheter de l'equipement.  
- L'application doit permettre de gérer le stock des équipements (quantité et prix).  
- Le joueur à 250 piece pour acheter de l'équipements.

Fonctionnement de l'application : 
- Créer un `Dictionary<string, int>` pour représenter le stock de la boutique.
- Initialisez le dictionnaire avec de l'équipement (ex: "Arc": 5, "Hache": 2, "Dague": 10, ...).
- Créez un menu en boucle qui propose :
  1. **Voir le catalogue** : Afficher l'équipement en stock avec son prix
  2. **Acheter un équipement** : Le joueur dépense son or pour faire un achat.
  3. **Voler un équipement** : Le joueur peut tenter de volé un équipement (10% de succes, en cas d'echec -> Game Over).
  4. **Quitter la boutique** : Fin de l'intéraction avec le marchant. Afficher la liste des achats de joueur.

Condition à respecter :
- Si l'équipement est en stock et que le joueur a l'or necessaire, l'achat est réussi.
- Si le joueur n'a pas assez d'or pour faire l'achat, le marchant se fou de lui !
- Si l'équipement n'est pas en stock, le marchant indique que c'est en rupture de stock.
- Si le joueur arrive à 0 or, le marchant force le joueur à partir en ricanant.


## 9) Le Simulateur de Combat au Tour par Tour (Complexe)
Réalisez un moteur de combat simplifié entre une équipe de héros et un Boss.

### Structures de données à utiliser
- Une `Queue<string>` pour gérer l'ordre de passage (L'initiative).
- Une `Dictionary<string, int>` pour stocker les héros (Nom du héro et ses points de vie).

### Déroulement de l'application :
- **Initialisation** :  
  1. L'utilisateur encode le nom des 3 héros (30 pdv). 
  2. Le boss à 100 pdv.
  3. Remplir la file d'attente (Ordre : Héros 1, Héros 2, Héros 3, puis le Boss).

- **La Boucle de Combat** : 
  1. Récuperer le personnage dont c'est le tour.
     - **Si c'est un héros** : L'utilisateur choisit entre "Attaque" (entre 5 et 15 dégâts) ou "Soin" (rend entre 10 PV).
     - **Si c'est le Boss** : Il attaque un héros au hasard et lui inflige 13 dégâts.
  2. Fin de tour, si le personnage est toujours vivant, il se réinscrit à la fin de la file.

- **Fin de partie** : Affichez qui a gagné et le nombre de tours qui ont eu lieu.
