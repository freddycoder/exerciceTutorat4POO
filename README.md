# Exercice Tutorat #4 POO
L'exercice réaliser en classe lors de la 4e seance de tutorat printemps 2019.

Ceci est un exemple simple d'une application asp.net core MVC. 

La règles d'affaire et l'application web sont dans deux projets différents.
Ceci va permetre de tester les règles d'affaire et de les rendre indépendantes de la technologie utiliser pour le UI.

## Réalisation

L'utilisateur peut se créer un compte à l'aide du projet MVC de base avec authentification.

Il est possible d'ajouter des items et d'afficher la liste des items.

## À propos du code

Dans le Projet Application se trouve une class nommé Executor qui va servir à executer toutes les requêtes de l'application.
Une requête comme une action de Lecture avec l'interface IRequest.
Une command comme une action d'écriture avec l'interface ICommand.
Les classes sont séparées par des dossier du nom de leurs entités.

## Pour la suite
L'exemple ici est très simple, il manque plusieurs chose.
 - Patron repository pour l'accès au donnée
 - Validation des données avant l'execution des commandes
 - Créer un projet Persistance et enlever le DbContext du projet Application
 - Continuer à ajouter les fonctionnalitées du RestoConcept!
 - ...
