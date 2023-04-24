## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMonFactory.cs`




## Copy van een template maken

Stel we willen vanuit deze data een nieuwe `ConsoleMon` maken zonder de template aan te passen
- soort van een `Unity prefab/clone`
- Maar `ConsoleMon` heeft een `List<Skill>` dat is een reference type

## function maken


geef deze `ConsoleMonFactory` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `CopyConsoleMon`
- heeft `ConsoleMon` als resultaat/return
- heeft 1 argumenten: naam `copyFrom` van het type `ConsoleMon`
- access is `internal`

## function implementeren


Het doel is dat er een nieuwe `ConsoleMon` gemaakt wordt die dezelfde `eigenschappen` als de template heeft

In je function body:
- Maak je een `new` `ConsoleMon`
- sla die op in een `variable` met de naam `copyResult`
- gebruik de `constructor` met argumenten bij je `new`
- als argumenten gebruik je de waarden van de `ConsoleMon` `copyFrom`
* bijvoorbeeld: `copyFrom.name`
- return `copyResult`

## Reference type kopieeren

- in `CopyConsoleMon` zet je nu het volgende: `copyResult.skills = copyFrom.skills;`
- dit is nog niet goed dat gaan we testen!

## testen:

plak de code hieronder in `Program.cs` in je `Program` class.

roep `TestCopyConsoleMon` aan in je `Main` function

- zie je 5 keer `True` en 1 keer `False` verschijnen onder `TestCopyConsoleMon`? dan klopt je code!

```
 static void TestCopyConsoleMon()
{
    Console.WriteLine("TestCopyConsoleMon");
    ConsoleMonFactory factory = new ConsoleMonFactory();
    List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
    ConsoleMon copyFrom = templates[0];

    ConsoleMon copy = factory.CopyConsoleMon(copyFrom);
    Console.WriteLine(copy.name == copyFrom.name);
    Console.WriteLine(copy.health == copyFrom.health);
    Console.WriteLine(copy.skills == copyFrom.skills);
    Console.WriteLine(copy.skills[0] == copyFrom.skills[0]);
    copy.name = "anders";
    copy.skills[0].name = "newskill";
    Console.WriteLine(copy.name != copyFrom.name);
    Console.WriteLine(copy.skills[0].name != copyFrom.skills[0].name);
}
```


## False: de test faalt

de regel `Console.WriteLine(copy.skills[0].name != copyFrom.skills[0].name);` geeft geen `True`
- waarom niet?

Dus we moeten in `CopyConsoleMon` ook elke `Skill` kopieeren!

- verander ` copyResult.skills = copyFrom.skills;` naar `copyResult.skills = new List<Skill>();`
- daaronder doen we een `for` over alle `skills` van `copyFrom`
- voor elke `skill` in `copyFrom` maken we met `CopySkill` een kopie
- `die` kopie geven we aan `copyResult` door het aan `copyResult.skills` toe te voegen met `Add`

## test 2

Doet het het nu wel?

`HEY!` waarom krijgen we nu

```
True
True
False
False
True
True
```
Dit klopt wel, bedenk je waarom die 2 keer `False` goed zijn

## commit

`commit` & `push` naar je git!

