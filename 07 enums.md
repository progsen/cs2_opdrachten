## stap 1 nieuw project


Maak met visual studio een nieuw project aan:
- in de map waar van de repository `2023P4ProgCs2` op jouw `computer`
- new project type is `console app` 
- Naam van het project is `EnumOpdracht`

## Enum maken

- maak een nieuwe class aan en noem deze `Colors`
- de class moet in een aparte file!
- open de file
- verander het woordje `class` wat voor `Colors` staat in `enum`

## waardes geven

De body van een enum heeft geen functions of variabelen maar waardes:

- voeg 4 waardes toe, gebruik namen van kleuren bv: `purple`

## Gebruiken

in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `myMainThemeColor`
- type wordt: `Colors`
- geef deze enum variabel nu 1 van jouw 4 kleuren als waarde

## if testen:

gebruik nu een `if` statement om:
- te testen of de waarde van `myMainThemeColor` gelijk is aan jou gekozen kleur
- als het waar is `WriteLine` dan `dat is mijn kleur!`

## run je programma

test of je programma werkt

## commit

`commit` & `push` naar je git!

### Sneller klaar? doe de extra!

## EXTRA

- Vraag alle waardes van jouw `enum` op. zoek de function `GetValues` van de `Enum` class en het keyword `typeof` op
- sla het resultaat van `GetValues` op in een `variable` van het type `Colors[]`. Je hebt hier een `cast` voor nodig: `(Colors[])`
- print het resultaat nu 1 voor 1 uit 

## EXTRA 2


- Na het `printen` vraag je met `Console.ReadLine()` een kleur aan de gebruiken.
- sla de input in een variabele van het type `string` met naam `value` op
- Maak nu een `Colors` variable met naam `parsedColor`
- Maak nu van `value` een `waarde` die je dan in `parsedColor` kan stoppen. zoek de function `Parse` van de `Enum` class op
