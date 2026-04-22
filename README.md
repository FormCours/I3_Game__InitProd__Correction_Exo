# Exo

## Rappel des commandes Git

### Commande de base _(Local)_
Initialiser un projet
```git
git init
```

Valider des modifications
```git
git add .
git commit -m "message"
```

Consulter l'historique et le status
```git
git status
git log --oneline
```

### Commande pour le repo en ligne _(Github, GitLab, Azure Devops, ...)_
Configurer git pour ajouter un repo distant
```git
git remote add origin <url-repo>
```

Envoyer le code vers le repo distant
```git
git push
```

Récuperer le code du repo distant
```git
git pull
```

Créer un repo local via un repo distant
```git
# Créer un dossier avec le nom du repo distant et copie le code
git clone <url-repo>

# Créer un dossier avec le nom choisi et copie le code
git clone <url-repo> <nom-local>

# Copie le code dans le dossier actuel
git clone <url-repo> .
```