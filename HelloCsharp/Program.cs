// See https://aka.ms/new-console-template for more information
/*
Installare Visual Studio 2022 per chi di voi non lo ha ancora fatto questa mattina. Una volta finito di installare
Visual Studio 2022 create un nuovo progetto “Console App” chiamato HelloCsharp.
A questo punto nel file Program.cs scrivete un programma che stampi un messaggio di Benvenuto.
Successivamente stampa i mesi dell’anno riga per riga e chiede all’utente di scrivere il suo mese preferito.
Una volta inserito il mese preferito, il programma stampa un messaggio di saluto e termina
*/

//Messaggio di Benvenuto
Console.WriteLine(" BENVENUTO ");
 
// Stampo riga per riga tutti i mesi dell'anno

Console.WriteLine(" Gennaio \n Febbraio \n Marzo \n Aprile \n Maggio \n Giugno \n Luglio \n Agosto \n Settembre \n Ottobre \n Novembre \n Dicembre");

//Chiedo all'utente qual è il suo mese preferito stampando un messaggio.

Console.WriteLine(" Qual è il tuo mese preferito? Inseriscilo di seguito");

//Creo una variabile dove l'utente inserirà il suo mese preferito e successivamente stamperò un messaggio di saluto 

var mesePreferito = Console.ReadLine();

Console.WriteLine( mesePreferito + " è anche il mio mese preferito grazie molte, buona giornata ");

