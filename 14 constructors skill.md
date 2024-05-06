## class openen

- open de `ConsoleMonGame` solution
- open de class file `Skill.cs`



## Constructors toevoegen

We hebben 2 constructors nodig:
* de default
* waar we alle properties aan kunnen meegeven


### Constructor 1 
- Maak een constructor voor `Skill`
- geen argumenten
- doet niets
- access is `public`


`!!` dit is de default constructor

### Constructor 2

- Maak een constructor voor `Skill`
- access is `internal`
- heeft argumenten voor:
* damage
* energyCost
* name
* element
- gebruik de `this.A= A` constructie voor `alle` argumenten om de `class properties` te vullen

## testen:

vervang 'TestConstructors' met de code hieronder in `Program.cs` in je `Program` class.

roep `TestConstructors` aan in je `Main` function

- zie je 8 keer `True` verschijnen onder `TestConstructors`? dan klopt je code!

```
static void TestConstructors()
{
    Console.WriteLine("TestConstructors");
    ConsoleMon mon = new ConsoleMon(200,200,"ConsoleColorMon",Element.Earth);

    Console.WriteLine(mon.energy == 200);
    Console.WriteLine(mon.name == "ConsoleColorMon");
    Console.WriteLine(mon.health == 200);
    Console.WriteLine(mon.weakness == Element.Earth);


    Skill skill = new Skill(90, 80, "FireBlade", Element.Fire);
    Console.WriteLine(skill.energyCost == 80);
    Console.WriteLine(skill.name == "FireBlade");
    Console.WriteLine(skill.damage == 90);
    Console.WriteLine(skill.element == Element.Fire);

}
```

## commit

`commit` & `push` naar je git!

