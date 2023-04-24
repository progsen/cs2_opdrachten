## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMonFactory.cs`



## Tekstfile toevoegen

- voeg aan je project een tekstfile toe, noem deze `monsterdata.json`
- open de file
- voeg de volgende content toe

```
[
  {
    "health": 100,
    "energy": 10,
    "name": "EnterMon",
    "weakness": 1,
    "skills": [
      {
        "damage": 5,
        "energyCost": 10,
        "name": "KeyPress",
        "element": 2
      }
    ]
  },

  {
    "health": 90,
    "energy": 25,
    "name": "NewLineMon",
    "weakness": 3,
    "skills": [
      {
        "damage": 5,
        "energyCost": 10,
        "name": "Erase",
        "element": 4
      }
    ]
  }
]
```

## Properties van een file in visual studio

Zet net als in de `fileio` opdracht `Copy to output directory` op `Copy if newer`

- build je solution
- controlleer of de file in je bin verschijnt
- klopt dat? dan kunnen we verder!


## function maken

geef deze `ConsoleMonFactory` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `LoadJson`
- heeft `geen` resultaat/return
- heeft 1 argument: naam `datafile` van het type `string`
- access is `internal`

## function implementeren

je gaat nu de body van de function invullen.
- Laad nu de file die als waarde in `datafile` staat in met de `File` class
- gebruik `ReadAllText`
- sla het resultaat op in een variabel met de name `json` van het type `string`
- `WriteLine` alle lines naar de console

## Json to class instance

Zelf tekst inlezen en splitten kan veel code werk zijn.
Laten we kijken naar json serialisation dat maakt het makkelijker

-zet de volgende regel in de  `LoadJson` function

```
List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
Console.WriteLine(templates[0].name);
```


## test aanpassen

plak de code hieronder in `Program.cs` in je `Program` class.

- run je code
- zie `EnterMon` verschijnen? 

Dat zou niet moeten

```
        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
            factory.LoadJson("monsterdata.json");
        }
```

## Hoezo niet?

Omdat json `public properties` gebruikt en niet naar `internal` kijkt, moeten we wat aanpassen

- Maak alle class variables in `Skill` en `ConsoleMon` `public`
- maak er properties van bijvoorbeeld:
    1) `internal int health;` wordt
    2) `public int health { get; set; }`
- run je code
- zie je nu wel `EnterMon` verschijnen?

## commit

`commit` & `push` naar je git!

## EXTRA Unity

In unity kan je ook met JSON werken, maar net iets anders

zoek eens uit wat er anders aan is en of je daar ook de `monsterdata.json` kan inladen
