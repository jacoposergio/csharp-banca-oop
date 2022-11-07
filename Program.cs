//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati 
//che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.





Banca intesa = new Banca("Intesa San Paolo");

Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);
intesa.AvviaBanca();

//registrazione cliente: 
//Console.WriteLine("Nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("cognome: ");
//string cognome = Console.ReadLine();
//Console.WriteLine("Codice fiscale: ");
//string codiceFiscale = Console.ReadLine();
//Console.WriteLine("Stpendio: ");
//int stipendio = Convert.ToInt32(Console.ReadLine());

//intesa.AggiungiCliente(nome, cognome,codiceFiscale,stipendio);
//intesa.CercaTuttiClienti();

//ricerca cliente: 
//Console.WriteLine("Premi 1 per cercare per nome e cognome, 2 per ricercare per codice fiscale");
//int risposta = Convert.ToInt32(Console.ReadLine());

//switch (risposta)
//{
//    case 1:
//        Console.WriteLine("Inserisci nome cliente: ");
//        string rispostaNome = Console.ReadLine();
//        Console.WriteLine("Inserisci cognome cliente: ");
//        string rispostaCognome = Console.ReadLine();
//        Cliente clienteTrovato = intesa.RicercaCliente(rispostaNome, rispostaCognome);
//        if (clienteTrovato != null)
//            Console.WriteLine("Nome: " + clienteTrovato.Nome);
//        Console.WriteLine("Cognome: " + clienteTrovato.Cognome);
//        Console.WriteLine("Codice fiscale: " + clienteTrovato.CodiceFiscale);
//        Console.WriteLine("Stipendio: " + clienteTrovato.Stipendio + "$ al mese");
//        break;
//    case 2:
//        Console.WriteLine("Inserisci codice fiscale cliente: ");
//        string rispostaCodiceFiscale = Console.ReadLine();
//        Cliente clienteTrovato2 = intesa.RicercaCliente(rispostaCodiceFiscale);
//        if (clienteTrovato2 != null)
//            Console.WriteLine("Nome: " + clienteTrovato2.Nome);
//            Console.WriteLine("Cognome: " + clienteTrovato2.Cognome);
//            Console.WriteLine("Codice fiscale: " + clienteTrovato2.CodiceFiscale);
//            Console.WriteLine("Stipendio: " + clienteTrovato2.Stipendio + "$ al mese");
//        break;
//    default:
//        Console.WriteLine("Sei capace di premere un tasto?");
//        break;
//}

//modifica cliente: 
//Console.WriteLine("Cerca cliente da modificare");
//Console.WriteLine("Premi 1 per cercare per nome e cognome, 2 per ricercare per codice fiscale");
//int risposta = Convert.ToInt32(Console.ReadLine());

//switch (risposta)
//{
//    case 1:
//        Console.WriteLine("Inserisci nome cliente: ");
//        string rispostaNome = Console.ReadLine();
//        Console.WriteLine("Inserisci cognome cliente: ");
//        string rispostaCognome = Console.ReadLine();
//        Cliente clienteTrovato = intesa.RicercaCliente(rispostaNome, rispostaCognome);
//        if (clienteTrovato != null)
//            Console.WriteLine("Inserisci nuovo nome: ");
//            string rispostaNuovoNome = Console.ReadLine();
//             if (rispostaNuovoNome != "")
//               clienteTrovato.Nome = rispostaNuovoNome;
//            Console.WriteLine("Inserisci nuovo cognome: ");
//            string rispostaNuovoCognome = Console.ReadLine();
//            if (rispostaNuovoCognome != "")
//            clienteTrovato.Cognome = rispostaNuovoCognome;
//            intesa.CercaTuttiClienti();
//            break;
//    case 2:
//        Console.WriteLine("Inserisci codice fiscale cliente: ");
//        string rispostaCodiceFiscale = Console.ReadLine();
//        Cliente clienteTrovato2 = intesa.RicercaCliente(rispostaCodiceFiscale);

//        if (clienteTrovato2 != null)
//            Console.WriteLine("Inserisci nuovo nome: ");
//            string rispostaNuovoNome2 = Console.ReadLine();
//            clienteTrovato2.Nome = rispostaNuovoNome2;
//            Console.WriteLine("Inserisci nuovo cognome: ");
//            string rispostaNuovoCognome2 = Console.ReadLine();
//            clienteTrovato2.Cognome = rispostaNuovoCognome2;
//            intesa.CercaTuttiClienti();
//            break;
//        default:
//             Console.WriteLine("Sei capace di premere un tasto?");
//        break;
//}




//aggiunta di un prestito
 //1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito
Console.WriteLine("Creazione di un nuovo prestito");
Console.WriteLine();
Console.WriteLine("Inserisci il codice fiscale:");
string codiceFiscale = Console.ReadLine();

Cliente esistente = intesa.RicercaCliente(codiceFiscale);

if (esistente == null)
{
    Console.WriteLine("errore: Cliente non trovato!");
}
else
{

    Console.WriteLine("Ammontare del prestito: ");
    int ammontarePrestito = Convert.ToInt32(Console.ReadLine());
    Prestito nuovoPrestito = new Prestito(0, esistente, 0,0, new DateOnly(), new DateOnly());

    intesa.AggiungiPrestito(nuovoPrestito);
    intesa.StampaTuttiPrestiti();
}