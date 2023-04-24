## stap 1 nieuw project


Maak met visual studio een nieuw project aan:
- in de map waar van de repository `2023P4ProgCs2` op jouw `computer`
- new project type is `console app` 
- Naam van het project is `ListOpdracht`

## List maken

in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `birds`
- type wordt: `List<string>`
- vul de list met de volgende strings (gebruik de `{"hiermijnstring", etc}` initializer):
	* uil
	* kraai
	* hond
	* papegaai

## Tweede list maken

in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `birds2`
- type wordt: `List<string>`
- vul de list met de volgende strings:
	* meeuw
	* duif

## Combineren van de lijsten

gebruik de `AddRange` function op `List` om:
- alle strings in `birds2` bij `birds` te voegen

## en die hond dan?

tja dat is geen vogel, gebruik `Remove`:
- om `hond` uit `birds` te halen


## printen!

gebruik een `for` om alles naar de console te schrijven


## testen:

Als je je programma draait moet je het volgende zien:

```
Hello, World!
uil
kraai
papegaai
meeuw
duif
```

## commit

`commit` & `push` naar je git!