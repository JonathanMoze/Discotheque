# Organisation en équipe

- Vous disposez un serveur `Discord` pour le module "M2204/M2106 - Méthodes Agiles et Bases de Données". Une fois que vous serez nommé sous le format "GxEy Nom Prénom" (avec `x` votre groupe et `y` votre numéro d'équipe dans le groupe) vous serez automatiquement affecté dans les canaux texte/audio correspondant à votre équipe.
- Les supports de cours sont disponibles sur Moodle : https://moodle1.u-bordeaux.fr/course/view.php?id=5598

# Utilisation de Gitlab pour gérer son projet

Voici les étapes à suivre pour gérer efficacement votre projet.

## Définir et affecter une `issue` (ou `user-story`)

Si la tâche ne vous a pas encore été attribuée, rendez-vous dans la section `issues` et assignez-vous une `issue` ayant pour label `ToDo`. Les `issues` sont en fait des tâches à faire, elles peuvent être attribuées à une ou plusieurs personnes. Par défaut, nous avons : `Open`, `ToDo`, `Doing`, `Closed`.

Vous pouvez aussi regrouper les `issues` par jalon (ou `milestone`), qui peuvent représenter par exemple des sprints dans une méthodologie agile. Le jalon est terminé lorsque toutes ses `issues` sont `Closed`.

*** Note *** : Sous la présentation Gitlab `Board`, on peut déplacer facilement les différentes issues en fonction de leur état d’avancement.

## Créer une `merge request` pour débuter votre contribution

Une fois assigné, glissez l’`issue` vers le label `Doing`. Ouvrez ensuite l’`issue` puis cliquez sur `Create Merge Request`. Cette action va créer automatiquement une `merge-request` avec le statut `WIP` (Work In Progress). La branche de travail associée à cette dernière est également créée.
Dans votre environnement de développement, pensez à faire un `git pull` pour être sûr d’être à jour. La nouvelle branche que vous venez de créer a été synchronisée. Basculez sur cette branche avec un `git switch` (ou `git checkout` si votre `git` n'est pas suffisamment récent).

*** Note *** : Vous avez toujours accès au dépot https://gitlab-ce.iut.u-bordeaux.fr/Pierre/DEMO-GIT-PT2 pour un rappel des commandes `git` vues au début du semestre 2.

## Passez en mode relecture (ou `Review`)

Une fois l’`issue` traitée, allez voir dans `GitLab` votre `merge-request`. Il se peut que vous ayez des conflits à régler. Vous pouvez tenter de les résoudre automatiquement sur l'interface web de `GitLab`, ou via votre environnement de développement. Une fois résolu, faites un `git commit` pour valider votre `merge`.

On vous recommande de `rebaser` votre branche de travail par rapport à la branche stable (`master` ou `develop`). Des conflits vont probablement apparaître si des contributions ont été intégrées entre temps sur la branche stable. Résolvez-les puis faites un `git rebase -continue` pour valider votre `merge`.

Vérifiez sur `GitLab` que votre problème de `Merge Conflit` a bien disparu.
Puis, cliquez sur `Resolve Wip Status` afin de montrer que le travail est terminé pour cette `merge-request`.

## Attendre les relectures de vos co-équipiers

Prenez en compte les retours proposés par vos relecteurs. Pensez à fermer les discussions pour chaque commentaire lorsque vous avez résolu le problème.
Si tout s’est bien passé, votre relecteur se chargera de faire le `Merge` final de votre branche. L'`issue`sera automatiquement fermée (`Closed`).

*** Note *** Vous pouvez mentionner une `issue` dans le message associé à vos `commit` pour y faire référence. Un message `fix issue #xxx` (avec `xxx` le numéro de l'`issue`) fermera automatiquement cette `issue`. Vous pouvez également faire référence à une autre `merge-request` avec un message contenant `#yyy` (avec `yyy` le numéro de la `merge-request`).

## Estimation du temps d'une `issue`

Il est possible de saisir des estimations du temps passé sur une `issue` en écrivant dans le champs commentaire :
- /estimate \<temps\> : pour ajouter une estimation
- /spend \<temps\> : pour indiquer le temps passé

Le temps se décline en :
- mo : mois
- w : semaines
- d : jours
- h : heures
- m : minutes

La barre de progression du jalon pourra en tenir compte.

## Quelques ressources complémentaires :

- https://makina-corpus.com/blog/metier/2019/gitlab-astuces-projets
- https://www.youtube.com/watch?v=tv4UM1ruQRs
- https://www.youtube.com/watch?v=Ddd3dbl4-2w
