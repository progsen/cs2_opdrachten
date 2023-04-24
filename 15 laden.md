## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMonFactory.cs`



## LoadJson

we gaan loadjson aanpassen:

- geef de function een `return`
- `return` de templates


## Copy van een template maken

Stel we willen vanuit deze data een nieuwe `Skill` maken zonder de template aan te passen
- soort van een `Unity prefab/clone`

## function maken


geef deze `ConsoleMonFactory` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `CopySkill`
- heeft `Skill` als resultaat/return
- heeft 1 argumenten: naam `copyFrom` van het type `Skill`
- access is `internal`

## function implementeren


Het doel is dat er een nieuwe `Skill` gemaakt wordt die dezelfde `eigenschappen` als de template heeft

In je function body:
- Maak je een `new` `Skill`
- sla die op in een `variable` met de naam `copyResult`
- gebruik de `constructor` met argumenten bij je `new`
- als argumenten gebruik je de waarden van de `Skill` `copyFrom`
* bijvoorbeeld: `copyFrom.name`
- return `copyResult`


## testen:

plak de code hieronder in `Program.cs` in je `Program` class.

roep `TestCopySkill` aan in je `Main` function

- zie je 4 keer `True` verschijnen onder `TestCopySkill`? dan klopt je code!

```
static void TestCopySkill()
{
    Console.WriteLine("TestCopySkill");
    ConsoleMonFactory factory = new ConsoleMonFactory();
    List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
    Skill copyFrom = templates[0].skills[0];

    Skill copy = factory.CopySkill(copyFrom);
    Console.WriteLine(copy.name == copyFrom.name);
    Console.WriteLine(copy.damage == copyFrom.damage);
    Console.WriteLine(copy.element == copyFrom.element);
    copy.name = "anders";
    Console.WriteLine(copy.name != copyFrom.name);
}
```

## commit

`commit` & `push` naar je git!

