


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

    public List<Prestito> RicercaPrestito(string codiceFiscale)
    {
        List<Prestito> trovati = new List<Prestito>();



        return trovati;
    }

    public int AmmontareTotalePrestitiCliente(string codiceFiscale)
    {
        int ammontare = 0; //metterò il conteggio

        //conteggio...

        return ammontare;
    }

    public int RateMancantiCliente(string codiceFiscale)
    {
        int rateMancanti = 0; //metterò il conteggio

        //conteggio...

        return rateMancanti;
    }

    public void StampaProspettoClienti()
    {
        //stampare per tutti i clienti
    }

    public void StampaProspettoPrestiti()
    {
        //stampa per tutti i prestiti
    }

    public void AggiungiPrestito(Prestito nuovoPrestito)
    {

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
}
