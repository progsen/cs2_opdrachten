## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMonFactory.cs`

## Data begrijpen

- kijk in `monsterdata.txt`

je ziet:
`EnterMon,health,100,energy,20,weakness,Fire|Skills;KeyPress,damage,5,energyCost,10,element,Fire;Default,damage,1,energyCost,0,element,Physical`

als we daar naar kijken zijn er `2` delen gescheiden door `|`:
1. `EnterMon,health,100,energy,20,weakness,Fire`
2. `Skills;KeyPress,damage,5,energyCost,10,element,Fire;Default,damage,1,energyCost,0,element,Physical`

1 heeft de data voor `ConsoleMon`
2 heeft de data voor `Skill` van `ConsoleMon` en kan meerdere hebben



## Load aanpassen

Ga naar de `Load` function

we gaan nu met `string.Split` de data lezen

Je hebt een `for` waar je `WriteLine` doet van elke regel tekst
die `for` gaan we aanpassen

- split voor elke stap van de `for` de `line` op `|`
- sla dit op in een `string[]` met naam `typeSplit`
- maak een variable met naam `consoleMonData` type `string[]` 
- geef `consoleMonData` de waarde van `typeSplit[0]` gesplit op `,`


## ConsoleMon maken

- maak een `new` `instance` van de `ConsoleMon` class
- sla dat resultaat in een variable op van type `ConsoleMon` met naam `dataMon`
- haal uit `consoleMonData` de waarden van de `eigenschappen` (name,energy,health) en geef die aan `dataMon`
* voorbeeld: `dataMon.name = consoleMonData[0]`

- schrijf alle eigenschappen naar de `Console` bv `WriteLine(dataMon.name)`

## test


```
        static void TestFactoryFunctions()
        {
            Console.WriteLine("TestFactoryFunctions");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            factory.Load("monsterdata.txt");
            factory.LoadJson("monsterdata.json");
        }
```

## commit

`commit` & `push` naar je git!

## EXTRA

kan jij ook de Skills uitlezen?
- maak de skills aan vanuit de data