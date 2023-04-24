## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMon.cs`



## Constructors toevoegen

We hebben 2 constructors nodig:
* de default
* waar we alle properties aan kunnen meegeven


### Constructor 1 
- Maak een constructor voor `ConsoleMon`
- geen argumenten
- doet niets
- access is `public`


`!!` dit is de default constructor

### Constructor 2

- Maak een constructor voor `ConsoleMon`
- access is `internal`
- heeft argumenten voor:
* health
* energy
* name
* weakness
- gebruik de `this.A= A` constructie voor `alle` argumenten om de `class properties` te vullen

## testen:

plak de code hieronder in `Program.cs` in je `Program` class.

roep `TestConstructors` aan in je `Main` function

- zie je 4 keer `True` verschijnen onder `TestConstructors`? dan klopt je code!

```
 static void TestConstructors()
{
    Console.WriteLine("TestConstructors");
    ConsoleMon mon = new ConsoleMon(200,200,"ConsoleColorMon",Element.Earth);

    Console.WriteLine(mon.energy == 200);
    Console.WriteLine(mon.name == "ConsoleColorMon");
    Console.WriteLine(mon.health == 200);
    Console.WriteLine(mon.weakness == Element.Earth);

}
```

## commit

`commit` & `push` naar je git!

