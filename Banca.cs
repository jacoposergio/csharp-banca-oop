


//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito



public class Banca
{
    public string Nome { get; set; }
    List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }

      public Banca(string Nome)
    {
        this.Nome = Nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();
    }
    public void AvviaBanca()
    {
        Cliente cliente1 = new Cliente("Mario", "Rossi", "rssmr373fr7", 3000);
        Cliente cliente2 = new Cliente("Antonio", "Verdi", "vrdat5737372h", 10000);
        Cliente cliente3 = new Cliente("Luca", "Bianchi", "bnclc6373fr7", 200000);
        Clienti.Add(cliente1);
        Clienti.Add(cliente2);
        Clienti.Add(cliente3);

        Prestito prestito1 = new Prestito(102, cliente1 , 233, 25, DateOnly.Parse("03/07/2022") , DateOnly.Parse("22/12/2022"));
        Prestito prestito2 = new Prestito(104, cliente2, 133, 33, DateOnly.Parse("05/08/2021"), DateOnly.Parse("20/02/2022"));
        Prestito prestito3 = new Prestito(106, cliente3, 433, 56, DateOnly.Parse("11/06/2022"), DateOnly.Parse("11/11/2022"));
        Prestito prestito4 = new Prestito(108, cliente1, 333, 16, DateOnly.Parse("01/06/2019"), DateOnly.Parse("10/11/2022"));
        Prestiti.Add(prestito1);
        Prestiti.Add(prestito2);
        Prestiti.Add(prestito3);
        Prestiti.Add(prestito4);
    }

    public bool AggiungiCliente(Cliente cliente)
    {
        if (
           cliente.Nome == null || cliente.Nome == "" ||
           cliente.Cognome == null || cliente.Cognome == "" ||
           cliente.CodiceFiscale == null || cliente.CodiceFiscale == "" ||
           cliente.Stipendio < 0
           )
        {
            return false;
        }

        return false;
    }
    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {

        if (
            nome == null || nome == "" ||
            cognome == null || cognome == "" ||
            codiceFiscale == null || codiceFiscale == "" ||
            stipendio < 0
            )
        {
            return false;
        }

        Cliente esistente = RicercaCliente(codiceFiscale);

        //se il cliente esiste l'istanza sarà diversa dal null
        if (esistente != null)
            return false;

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;
    }

    public Cliente RicercaCliente(string codiceFiscale)
    {

        foreach (Cliente cliente in Clienti)
        {
            if (cliente.CodiceFiscale == codiceFiscale)
                return cliente;
        }

        return null;
    }


    public Cliente RicercaCliente(string nome, string cognome)
    {

        foreach (Cliente cliente in Clienti)
        {
            if (cliente.Nome == nome && cliente.Cognome == cognome)
                return cliente;
        }

        return null;
    }

    public Prestito RicercaPrestito(string codiceFiscale)
    {
        foreach (Prestito prestito in Prestiti)
        {
            if (prestito.Intestatario.CodiceFiscale == codiceFiscale)
                return prestito;
        }

        return null;
    }

    public int AmmontareTotalePrestitiCliente(string codiceFiscale)
    {
        int ammontare = 0; //metterò il conteggio
     
        foreach (Prestito prestito in Prestiti)
        {
            ammontare += prestito.Ammontare;
        }

        //conteggio...

        return ammontare;
    }

    public int RateMancantiCliente(string codiceFiscale)
    {
        int rateMancanti = 0; //metterò il conteggio

        //conteggio...

        return rateMancanti;
    }

    public void StampaProspettoClienti(string codiceFiscale)
    {
        //stampare per tutti i clienti
    }

    public void StampaProspettoPrestiti()
    {
        //stampa per tutti i prestiti
    }

    public void AggiungiPrestito(Prestito prestito)
    //public void AggiungiPrestito(int id, Cliente intestatario, int ammontare, int valoreRata, DateOnly dataInizio, DateOnly dataFine)
    {
        //Prestito prestito = new Prestito(id, intestatario, ammontare, valoreRata, dataInizio, dataFine);
        Prestiti.Add(prestito);
    }

    //FUNZIONI DI DEBUG 

    public void CercaTuttiClienti()
    {
        bool isEmpty = !Clienti.Any();
        if (!isEmpty)
        {
            Console.WriteLine("\r\nTutti i clienti: \r\n ");
            foreach (Cliente item in Clienti)
            {
                Console.WriteLine("\r\nNome: " + item.Nome);
                Console.WriteLine("Cognome: " + item.Cognome);
                Console.WriteLine("Codice Fiscale: " + item.CodiceFiscale);
                Console.WriteLine("Stipendio: " + item.Stipendio + " all'anno");
            }
        }
        else
            Console.WriteLine("nessun cliente trovato");
    }

    public void StampaTuttiPrestiti()
    {
        bool isEmpty = !Clienti.Any();
        if (!isEmpty)
        {
            Console.WriteLine("\r\nTutti i prestiti: \r\n ");
            foreach (Prestito item in Prestiti)
            {
                Console.WriteLine("\r\nL'Id prestito: " + item.Id);
                Console.WriteLine("Nome: " + item.Intestatario.Nome);
                Console.WriteLine("Cognome: " + item.Intestatario.Cognome);
                Console.WriteLine("L'ammontare del prestito è: : " + item.Ammontare + "$");
                Console.WriteLine("Il valore della rata è: " + item.ValoreRata + "$ all'anno");
                Console.WriteLine("Data inizio: : " + item.DataInizio);
                Console.WriteLine("Data fine: : " + item.DataFine);
            }
        }
        else
            Console.WriteLine("nessun cliente trovato");
    }
}
