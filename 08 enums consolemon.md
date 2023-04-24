## solution openen

- open de `ConsoleMonGame` solution

## Enum maken

- maak een nieuwe class aan en noem deze `Element`
- de class moet in een aparte file!
- open de file
- verander het woordje `class` wat voor `Element` staat in `enum`

## waardes geven

De body van een `enum` heeft geen functions of variabelen maar waardes:

voeg 5 waardes toe:
- Fire
- Earth
- Water
- Wind
- Physical


## Gebruiken bij Skill



geef de `Skill` class een nieuwe class variable:
`gebruik precies de namen zoals hieronder!`

- open de class file `Skill.cs`
- access is `internal`
- naam wordt `element`, type wordt `Element`

## Gebruiken bij ConsoleMon



geef de `ConsoleMon` class een nieuwe class variable:
`gebruik precies de namen zoals hieronder!`

- open de class file `ConsoleMon.cs`
- access is `internal`
- naam wordt `weakness`, type wordt `Element`

## UseOn van Skill aanpassen:

- open de class file `Skill.cs`

pas de function `UseOn` aan:
- test met `if` of de `weakness` van `target` gelijk is aan `element` van `Skill`
- als dat zo is: roep `TakeDamage` nogmaals aan met damage/2
## testen:

run je `run` je programma,

als je `TestSkillFunctions` in je main had aangeroepen dan krijg je nu:

```
TestSkillFunctions
False
True
```

Een test is omgevallen!

vervang de function `TestSkillFunctions` met die hieronder staat

run je code

- zie je 2 keer `True` verschijnen onder `TestSkillFunctions`? dan klopt je code!


```
static void TestSkillFunctions()
{
    Console.WriteLine("TestSkillFunctions");
    ConsoleMon casterMon = new ConsoleMon();
    ConsoleMon targetMon = new ConsoleMon();
    Skill skill = new Skill()
    {
        damage = 100,
        energyCost = 20,
    };
    skill.UseOn(targetMon, casterMon);

    Console.WriteLine(targetMon.health == -150);

    Console.WriteLine(casterMon.energy == -20);
}
```

## commit

`commit` & `push` naar je git!