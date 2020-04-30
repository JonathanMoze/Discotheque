La base `MusiqueSQL` peut être récupérée depuis les liens ci-dessous (autour de `500Mo`).

Il y a 2 morceaux :
- '.mdf' est le fichier des données (307Mo) : https://box.iut.u-bordeaux.fr/f/d7868e74bc774a2da1e1/?dl=1 (mirror https://my.pcloud.com/publink/show?code=XZRPN9kZa4T1edRp9lQkQ3b6wCKNehrbVJ7y).
- '.ldf' est le fichier du journal de transaction (132Mo) : https://box.iut.u-bordeaux.fr/f/ac115759e13f47559007/?dl=1 (mirror https://my.pcloud.com/publink/show?code=XZsPN9kZDEmG7sdRTlj8mwKYqLxLI4NLCjAk).

Pour attacher la base, il suffit de suivre la procédure suivante :
https://docs.microsoft.com/fr-fr/sql/relational-databases/databases/attach-a-database?view=sql-server-ver15 .

***Remarque*** : il peut y avoir un problème de droits d’accès sous Windows, facilement contournable en déposant la base dans l’espace `C:\Utilisateurs\Public\`.
