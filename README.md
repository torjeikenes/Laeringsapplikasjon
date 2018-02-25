# Laeringsapplikasjon - av Torje Eikenes og Øyvind Skaaden

Dette programmet er skrevet i C# og er et læringsprogram, basert på kahn academy sin måte å lære enkelte temaer

Programmet er fremdeles under utvikling, men er mulig å teste selv. For å gjøre dette, følg installasjonsinstruks under

## Instalasjonsinstrukser

* Last ned eller clone denne giten
  - Git Clone: https://github.com/torjeikenes/Laeringsapplikasjon.git
  - Zip-fil: https://github.com/torjeikenes/Laeringsapplikasjon/archive/master.zip
    * Unzip mappen
* Flytt "Kurs"-mappen til Mine Dokumenter mappen på maskinen din.
  - Typisk `C:\Users\DITTNAVN\My Documets\`
* Åpne `Læringsapplikasjon.sln` i Visual Studio 2017
* For at programmet skal fungere må du installere [Json.NET](https://www.newtonsoft.com/json)
  - Trykk last ned og følg instrukser
    - Trykk `Tools > NuGet Package Manager > Package Manager Console`
    - Lim inn denne teksten i konsollen: `Install-Package Newtonsoft.Json`
    - [Json.NET](https://www.newtonsoft.com/json) skal nå være installert
    - [Denne](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio) artikkelen av microsoft er også ganske bra, bruker også [Json.NET](https://www.newtonsoft.com/json) som et eksempel.
* Programmet skal fungere som normalt nå

## Lage dine egene "læringspakker"

Programmet støtter egenlagdte spørsmål og svar "pakker". Disse består av en json-fil og evt andre bilde og lydfiler.
Disse må skrives på en spesiell måte. Bruk [`Kurs/Test/Test.json`](https://github.com/torjeikenes/Laeringsapplikasjon/blob/master/Kurs/Test/Test.json) som et eksempel.

Format på læringsdelen er slik:
```json
"teach": [
		{
			"title":"Test1",
			"info":"Info about test1",
			"photo":"frosk.png",
			"audio":"frog.wav"
		},
		{
			"title":"Test2",
			"info":"Info about test2",
			"photo":"frosk.png",
			"audio":"frog.wav"
		},
```

Spørsmåldelen er litt anderledes:
```json
"quiz":[
		{
			"question":"What are frogs?",
			"answer":["en Meme", "frosk", "Answer3", "Answer4"],
			"correct":"frosk",
			"photo":"frosk.png",
			"audio":"frog.wav"
		},
		{
			"question":"testus",
			"answer":["maksimus", "Answer2", "Answer3", "Answer4"],
			"correct":"maksimus",
			"photo":"frosk.png",
			"audio":""
		}
```
Svaralternativene står i listen `answer` og det riktige svaret står i `correct`. Det riktige svaralternativet og listen må være like.
