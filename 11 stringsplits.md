
## stap 1 nieuw project


Maak met visual studio een nieuw project aan:
- in de map waar van de repository `2023P4ProgCs2` op jouw `computer`
- new project type is `console app` 
- Naam van het project is `SplitOpdracht`


## Tekstfile toevoegen

- voeg aan je project een tekstfile toe, noem deze `stringsplit.txt`
- open de file
- voeg de volgende zin toe: `cijferlijst:vak1 =6 ,vak2= 9,,`



## Properties van een file in visual studio

Zet net als in de `fileio` opdracht `Copy to output directory` op `Copy if newer`

## File inlezen


in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `content`
- type wordt: `string`

- gebruik de function `ReadAllText` van de  `File` class om de file te lezen 
- gebruik nu de function `Split` op de class `String` en split `content` op met `:` als separator
- je krijgt nu `2` strings in 1 `string[]` terug. Sla deze op in een variabel met naam `keyvalue`
- Schrijf de strings naar de `Console`

## nog een split per vak

nu hebben we de key `cijferlijst` in `keyvalue[0]` en de vakken in `keyvalue[1]`
- nu gaan we `keyvalue[1]` nog een keer splitten
- split met `,` de 2de string op
- sla het resultaat op in een variabel met naam `cijfersPerVak`
- Schrijf de strings naar de `Console`


## commit

`commit` & `push` naar je git!


### Sneller klaar? doe de extra!

## EXTRA

- Zorg dat er geen `extra spaties` in de resultaten zitten 
- Tip: gebruik de function Replace die op elke string bestaat

## EXTRA 2

- Zorg dat er geen `lege resultaten` tussen de vakken zitten
- Zorg dat er geen `extra spaties` in de resultaten zitten
- Tip: de function `Split` heeft andere `variant` waar je `StringSplitOptions` aan kan meegeven!

