
## stap 1 nieuw project


Maak met visual studio een nieuw project aan:
- in de map waar van de repository `2023P4ProgCs2` op jouw `computer`
- new project type is `console app` 
- Naam van het project is `FileDirOpdracht`


## DirectoryInfo variable


in je `Main` maak je een nieuwe lokale variable:

- naam wordt: `dir`
- type wordt: `DirectoryInfo`
- je moet een `path` opgeven aan de `constructor` van `DirectoryInfo` gebruik daar het pad naar je repository `2023P4ProgCs2` op je computer voor

## Files ophalen

- vraag aan `dir` alle files op.
- sla die op in een variable van het type `FileInfo[]`
- laat nu alle files zien met een `WriteLine` en een `for`

Tip: lees de Documentatie:
https://docs.microsoft.com/en-us/dotnet/api/system.io.directoryinfo.getfiles?view=net-6.0#system-io-directoryinfo-getfiles

## Directories ophalen

- vraag nu aan `dir` alle directories.
- sla die op in een variable van het type `DirectoryInfo[]`
- laat nu alle directories zien met een `WriteLine` en een `for`

## testen:

run je `run` je programma,
Nu zou je alle files en directories op het hoofdniveau van je repository `2023P4ProgCs2` op jouw `computer` moeten zien


## commit

`commit` & `push` naar je git!


### Sneller klaar? doe de extra!

## EXTRA

- Je hebt nu alle files en directories opgehaald en laten zien, wij willen nu ook alle files in de hele directory boom onder jouw gekozen directory zien
- maak van het laten zien van files en directories van 1 DirectoryInfo, `1 function`
- Als je over de subdirectories loopt om te printen, roep je nu ook de function aan voor die subdirectory

Tip: dit heet `recursion`, zoek dat maar eens op! 