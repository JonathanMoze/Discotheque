## Projet exemple pour illustrer les mises à jour d'une base de données via OLEDB

Ce projet permet de voir comment fonctionnent les opérations de mise à jour d'une table via OLEDB.

Il ne s'agit pas d'un outil "complet", mais d'une simple illustration. Il ne permet ainsi que d'effectuer 
des opérations de mise à jour sur la table JOUEURS de la base de données CHAMPIONNAT, et uniquement pour
les joueurs de l'équipe ayant pour ID_EQUIPE la valeur "1".

Pour tester ce projet, vous devrez :
* adapter le fichier app.config (nom de votre serveur)
* éventuellement adapter le code dans Form1.cs si vous n'avez pas d'équipe ayant "1" pour identifiant.