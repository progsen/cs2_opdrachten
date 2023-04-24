
## stap 1 nieuw project


Maak met visual studio een nieuw project aan:
- in de map waar van de repository `2023P4ProgCs2` op jouw `computer`
- new project type is `console app` 
- Naam van het project is `FileIOOpdracht`


## Tekstfile toevoegen

- voeg aan je project een tekstfile toe, noem deze `leesdezefile.txt`
- open de file
- voeg de volgende zin toe: `op een goede morgen was er wat data in een file`


## Properties van een file in visual studio

Elke file heeft properties. Wij willen dat onze `leesdezefile.txt` ook meegaat naar onze `bin` folder bij het `compilen`

- `rechter` muis click op de file `leesdezefile.txt` in je `solution explorer`
- click op `properties`
- zoek de dropdown `Copy to output directory`
- staat deze op `Do not copy`? zet het om naar `Copy if newer`

- build je solution

## Bin directory

- ga in je windows `verkenner/explorer` naar de directory van `FileIOOpdracht`
- ga nu naar de `FileIOOpdracht\bin\Debug\net7.0` directory
- daar staat een exe `FileIOOpdracht.exe` en als het goed is ook je `leesdezefile.txt` file


- klopt dat? dan kunnen we verder!

## File inlezen


in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `content`
- type wordt: `string[]`

- gebruik de `File` class om de regels te lezen (gebruik de goede function!) 
- print de regels 1 voor 1 naar de console met een `for`


## Meer tekst

zet nu een extra regel in `leesdezefile.txt`:
- `en een tweede regel aan data`

- run je programma


## Tekst toevoegen:

in je `Main` gaan we nu regels toevoegen in een nieuwe file:

- Gebruik de `File` class om tekst te schrijven naar de file `mijnnieuwefile.txt`
- Gebruik de `File` class om nu een extra regel toe te voegen aan `mijnnieuwefile.txt`, dat heet `Append` 

TIP: gebruik niet de variant waar een `StreamReader/StreamWriter` uitkomt. deze zijn hier niet nodig


## Een directory maken

Nu willen we de nieuwe file in een output directory:

- maak met de `Directory` class een nieuwe directory met de naam `output`
- controlleer of deze in je bin folder `FileIOOpdracht\bin\Debug\net7.0` staat
- pas je code aan zodat `mijnnieuwefile.txt` in `output` komt


## commit

`commit` & `push` naar je git!


### Sneller klaar? doe de extra!

## EXTRA

- Je hebt nu alle files en directories opgehaald en laten zien, wij willen nu ook alle files in de hele directory boom onder jouw gekozen directory zien
- maak van het laten zien van files en directories van 1 DirectoryInfo, `1 function`
- Als je over de subdirectories loopt om te printen, roep je nu ook de function aan voor die subdirectory

Tip: dit heet `recursion`, zoek dat maar eens op! 

