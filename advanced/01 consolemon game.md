## consolemon game maken

we gaan een soort pokemon maken met de console.
En later kijken of we dan die code in OF unity OF een 2d windows form kunnen gebruiken!

## opstarten

maak 2 projecten:
 - een console applicatie
    - dit runt je game code
 - een library 
    - hier komt je game code
        - denk aan je data classes
        - denk aan je logica classes
    - hier mogen geen Console.writelines in!

## library linken

- link (reference) je library aan je console applicatie
    - zoek uit hoe dat moet
    - gebruik PUBLIC voor je classes in je libary

## UI

Zorg ervoor dat je UI en je logica gescheiden zijn
- UI gaat in de console applicatie
- logica in de library

## opdracht

Maak een pokemon achtige console applicatie:
- waar je consolemon hebt
    - consolemons hebben skills
- waar je de consolemon data uit files komt
    - je mag in de normale opdrachten kijken voor dat stuk
- er zijn trainers
    - trainers hebben consolemon
- de consolemon moeten kunnen vechten met elkaar

## console mon data

Hier wat voorbeeld data om consolemon te maken:

```
EnterMon,health,100,energy,20,weakness,Fire|Skills;KeyPress,damage,5,energyCost,10,element,Fire;Default,damage,1,energyCost,0,element,Physical
NewLineMon,health,90,energy,15,weakness,Water|Skills;Clear,damage,5,energyCost,10,element,Earth;Default,damage,1,energyCost,0,element,Physical
DeleteMon,health,90,energy,25,weakness,Earth|Skills;Erase,damage,4,energyCost,2,element,Wind;Default,damage,1,energyCost,0,element,Physical
```

## wereld


- zorg ervoor dat je een wereld hebt waar je in kan lopen
    - ja dit kan ook in een console app ^^
- zorg dat je random encounters hebt
    - na een encounter ga je naar het battle screen

## battle

- zorg dat je kan kiezen welke skill je gebruikt
- je moet kunnen winnen en verliezen

- optioneel: je moet consolemon kunnen vangen
