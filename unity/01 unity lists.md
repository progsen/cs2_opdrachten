## unity

start nu unity op

- maak een nieuw project:
    - ListsCsharp2


- maak een nieuw script
- in de class van dit script maak je een nieuwe List aan
- in deze list moeten GameObject (s) komen



## scene
- maak nu een object (de spawner) in je scene
- deze spawner moet om de 0.5 seconde:
    -  een nieuw gameobject maken 
         > gebruik gewoon een standaard object zoals een bal of kubus
    - dat gameobject moet weggaan met een random richting & een *vaste* snelheid 
- elk gameobject wat je maakt stop je in de List die je gemaakt hebt

## limieten
- in je update:
    - kijk je hoe groot de lijst is 
        - als de lijst groter dan 20 is, haal je het eerste object weg 