## class openen

- open de `ConsoleMonGame` solution
- open de class file `ConsoleMon.cs`


## function maken

geef deze `ConsoleMon` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `TakeDamage`
- heeft `geen` resultaat/return
- heeft 1 argument: naam `damage` van het type `int`
- access is `internal`

## function implementeren

je gaat nu de body van de function invullen.
Het doel is dat het getal wat in het argument `damage` zit van de `health` van de class wordt afgetrokken.

## function 2 maken

geef deze `ConsoleMon` class een nieuwe function:

`gebruik de namen zoals hieronder!`

- Naam van de function wordt: `DepleteEnergy`
- heeft `geen` resultaat/return
- heeft 1 argument: naam `energy` van het type `int`
- access is `internal`

## function implementeren

je gaat nu de body van de function invullen.
Het doel is dat het getal wat in het argument `energy` zit van de `energy` van de class wordt afgetrokken.

Tip: `this`


## testen:

plak de code hieronder in je `Program.cs` in je `Program` class.

roep `TestConsoleMonFunctions` aan in je `Main` function

- zie je 2 keer `True` verschijnen? dan klopt je code!

```  
static void TestConsoleMonFunctions()
{
    Console.WriteLine("TestConsoleMonFunctions");
    ConsoleMon mon = new ConsoleMon();
    mon.TakeDamage(100);
    mon.DepleteEnergy(20);

    Console.WriteLine(mon.health == -100);

    Console.WriteLine(mon.energy == -20);
}

```

## commit

`commit` & `push` naar je git!