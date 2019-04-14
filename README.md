# Maijang

Projet iCreate 2019

## Présentation du projet

- **Porteur de projet** : Musée d'Arts de Nantes
- **Technologie d'entrée** : Leap motion
- **Technologie de sortie** : Projection immersive

## Membres de l'équipe

- **Polytech Nantes**
  - Pierre-Adrien Delisle
  - Damien Tassetti
  - Xinyu Qi
- **L'École de Design**
  - Julia Haremza
  - Clara Saillant
  - Léa Manchajm
  
  
 
 # [Rapport du projet complet](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Rapport%20du%20projet%20-%20Majiang_compressed.pdf)
 
 Ci-dessus le lien vers le rapport du projet qui inclus:
   - La problématique
   - Le positionnement
   - Le scénario d'usage
   - L'univers graphique
   - ...

# Description du projet 
    
  Notre projet est proposé par le Musée d'art de Nantes sur la thématique d'intéresser les adolescents (13-18) à venir au musée découvrir l'art ancien en sortant du cadre scolaire via des projet innovants.
  Nous nous sommes donc inspirés des jeux d'énigmes très populaire auprès des jeunes que sont les escapes games pour faire ce projet. En étant dans le musée d'art de Nantes, nous avons choisi le tableau de Girardet : "Le campement"
    
  ![alt text](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/PeinturePNG.png)
    
    
# Principe du jeu
  Le jeu est basé sur des énigmes dans la tente et dans la projection entre "virtuel" et "réel".
  
  Les énigmes sont affichés sur la projection immersive dans la tente. Elles vont vous inciter à regarder et observer ce qui est dans la tente où vous vous trouvez. Via ces élements trouvés dans la tente, vous pourrez résoudre cette énigme et répondre sur la projection immersive via le leap motion.
  
  Vous survolez le totem avec votre main et le leap motion va capter votre main et la faire apparaitre afin de répondre.

Les différentes mouvements reconnus par le leap motion sont :

   - étape 1 : Pointer avec le doigt pour choisir ce qu'on a découvert dans la tente
   - étape 2 : Faire des chiffres 1,2 ou 3 pour valider notre réponse à l'énigme
   - étape 3 : Zoomer en faisant un mouvement de pincement avec les doigts pour trouver un élément intrus dans le tableau.
    
    
#  Matériel nécessaire
  Un  ordinateur sous une version de Windows récente.
  
  Un leap motion
  
  Un projecteur à longue focale avec haut-parleurs (sinon possibilité de prendre des haut-parleurs indépendants)
  

# Logiciels nécessaires et procédure d'installation
  Le projet est un jeu créé en langage C# via le logiciel Unity.
  L'application est en forme de .exe donc exécutable sous Windows.
  
  Tout d'abord, il faut vous fournir :
  
   - d'un ordinateur
   - d'un leap motion via USB
   - d'un projecteur via HDMI
      
 Une fois l'ordinateur branché à ces deux appareils. 
 
 Il faut simplement lancer le .exe qui contient le jeu (seulement compatible Windows).
 
 Dans le projet, l'application à lancer s'appelle iCreate.exe dans le dossier "Test"
 
# Scripts fournis dans le projet
Les script utilisés dans le projet sont commentés afin de comprendre mieux leur utilisation. 
Voici un résumé des features développées :
  - ActivateZoom : active la feature de zoom lorsque son GameObject auquel le script est rataché devient actif
  - CurrentState : stocke l'état courant du jeu (Début, énigme 1, énigme 2,...)
  - LookHighlight : si actif va afficher un élément en surbrillance pour l'énigme 1 et change l'état.
  - NumberFingers : gère la feature de compter le nombre de doigts "tendus" pour répondre à l'énigme 2.
  - PrintMessage : contient beaucoup de méthodes afin d'afficher les événements détéctés par le leap motion
  - PuzzleManager : observe le currentState et désactive la scène courante pour passer à la prochaine étape
  - ResolveTime : si le joueur gagne, il obtient le temps qu'il a mit afin de résoudre le jeu.
  - Timer : gère l'affichage du temps en bas à droite de l'écran
  - Zoom : gère la feature de zoom quand il y a un pincement
  - ZoomChevre : change l'état du jeu lorsque le joueur zoom sur la position de l'élément intrus
  
On utilise dans le projet, la librairie Orion fourni par le Leap Motion pour Unity avec des scripts de détection d'événements comme :
  - LeapExtendedFingerDetector
  - LeapPinchDetector
  - ...
  
  
# Installation du matériel
  Tout d'abord, il faut mettre en place la structure de la tente au centre de laquelle on trouvera le projecteur ainsi que le capteur leap motion. Pour cela, il vous faut :
  
  ![image de tasseaux de bois, vis et équerre en métal](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/materiel.jpg)
  
  Assemblez-les pour créer la structure suivante :
  
  ![image des premiers éléments de structure](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/installation_structure_1.png)
  
  Puis former le squelette global:
  
  ![image de la structure bois](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/installation_structure_2.png)
  
  Positionnez ensuite les tapisseries ou drapés (au préalable décorés de motifs dans les tons de l'oeuvre étudiée) par dessus la structure de manière à couvrir l'intérieur. Faire tenir avec des punaises ou des agrafes.
  
  ![image des drapés recouvrant la structure](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/vue_arriere.jpg)
  
  Laissez une ouverture sur un côté pour pouvoir accéder à l'intérieur de la tente, puis installez le projecteur et les indices à l'intérieur.
  
  ![image de l'entrée de la tente](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/vue_devant.jpg)
  
  ![schéma de l'intérieur de la tente](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/interieur.jpg)
  
  Le projecteur est dissimulé sur un trépied situé à l'intérieur d'un "totem" de carton, lui aussi marqué de motifs tels qu'on en retrouve à l'extérieur de la tente. Au-dessus de ce totem, le capteur du leap motion est fixé dans un encart pour une utilisation facile.

  ![schéma du totem](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/totem.jpg)
  
  ![image du haut du totem](https://github.com/PierreAdrienDelisle/iCreate/blob/master/Assets/PNG/readme/totem_haut.jpg)
