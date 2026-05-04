# Exercice Structure

## Exercice 1 — Encodage de pokemon
Créer une structure `Pokemon` contenant :
- Son nom : `string`
- Son id : `int`
- Son surnom : `string`
- Ses stats (PV, Attaque, Défense, Attaque Spécial, Défense  Spécial, Vitesse)

Permettre à l'utilisateur d'encoder son pokemon via la console.  
Une fois le pokemon encoder :
- Effacer la console → `Console.clear()`
- Afficher le detail du pokemon
- Afficher sa "Catégorie"

### Classification en catégorie
Voici un tableau se basé sur la totalité des stats du pokemon
Total         | Categorie
 ------------ | --------
400 et moins  | Faible
400 à 549     | Moyen
550 à 599     | Fort
600 et plus   | Très fort

---

## Exercice 2 — Gestion d'inventaire de butin
Créer une structure `Butin` :
- Son nom : `string`
- Sa quantité: `int` 
- Son poids : `double`

Créer une structure `Sac` :
- Un poids maximal : `double`
- Le butins : `List<Butin>`

Permettre à l'utilisateur de remplire le sac avec du butin : 
- Arrêter quand le sac est plein
-  Afficher l’inventaire complet
- Calculer le poids total

--- 

## Exercice 3 — Personnage de jeu vidéo
Créer une énumération `ClassePersonnage` :
- Guerrier
- Mage
- Archer
- Etc...

Créer une structure `Personnage` :
- Son nom : `string`
- Sa classe : `ClassePersonnage`
- Son niveau : `int`
- Ses points de vie (actuel et max) : `int`

Permettre à l'utilisateur d'encoder ses personnages.

---

## Exercice 4 — Jeu de carte
Créer deux énumérations `CouleurCarte` et `ValeurCarte`.

Créer une structure `Cartes` : 
- Sa valeur : `ValeurCarte` 
- Sa couleur : `CouleurCarte`

En utilisant une boucle, créer un tableau de 52 cartes.  
Afficher les cartes dans la console.

Ensuite, mélanger les cartes (Have fun :p).  
Afficher les cartes après le mélange. 