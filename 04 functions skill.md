## class openen

- open de `ConsoleMonGame` solution
- open de class file `Skill.cs`


## function maken

geef deze `Skill` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `UseOn`
- heeft `geen` resultaat/return
- heeft 2 argumenten:
	1) naam `target` van het type `ConsoleMon`
	2) naam `caster` van het type `ConsoleMon`
- access is `internal`

## function implementeren

je gaat nu de body van de function invullen.
Het doel is dat de `Skill` gebruikt wordt en damage doet tegen de `target`

In je function body:
- haal je `energyCost` van `Skill` van de `caster` door de `DepleteEnergy` function te aan te roepen op `caster`
- geef je `damage` van de `Skill` aan de `target` door de `TakeDamage` function te aan te roepen op `target`


## testen:

plak de code hieronder in je `Program.cs` in je `Program` class.

roep `TestSkillFunctions` aan in je `Main` function

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
    skill.UseOn( targetMon, casterMon);

    Console.WriteLine(targetMon.health == -100);

    Console.WriteLine(casterMon.energy == -20);
}
```

## commit

`commit` & `push` naar je git!