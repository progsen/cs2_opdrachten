## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMon.cs`



## Tekstfile toevoegen

- voeg aan je project een tekstfile toe, noem deze `monsterdata.txt`
- open de file
- voeg de volgende content toe

```
EnterMon,health,100,energy,20,weakness,Fire|Skills;KeyPress,damage,5,energyCost,10,element,Fire;Default,damage,1,energyCost,0,element,Physical
NewLineMon,health,90,energy,15,weakness,Water|Skills;Clear,damage,5,energyCost,10,element,Earth;Default,damage,1,energyCost,0,element,Physical
DeleteMon,health,90,energy,25,weakness,Earth|Skills;Erase,damage,4,energyCost,2,element,Wind;Default,damage,1,energyCost,0,element,Physical
```

## Properties van een file in visual studio

Zet net als in de `fileio` opdracht `Copy to output directory` op `Copy if newer`

- build je solution
- controlleer of de file in je bin verschijnt
- klopt dat? dan kunnen we verder!

## class aanmaken

- maak een nieuwe class aan en noem deze `ConsoleMonFactory`
- de class moet in een aparte file!


## function maken

geef deze `ConsoleMonFactory` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `Load`
- heeft `geen` resultaat/return
- heeft 1 argument: naam `datafile` van het type `string`
- access is `internal`

## function implementeren

je gaat nu de body van de function invullen.
- Laad nu de file die als waarde in `datafile` staat in met de `File` class
- zorg dat je regels terugkrijgt `string[]`
- sla het resultaat op in een variabel met de name `lines` van het type `string[]`
- `WriteLine` alle lines naar de console

## testen

plak de code hieronder in `Program.cs` in je `Program` class.

roep `TestFactoryFunctions` aan in je `Main` function

- zie je alle regels verschijnen onder `TestFactoryFunctions`? dan klopt je code!

```

        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
        }
```

## commit

`commit` & `push` naar je git!