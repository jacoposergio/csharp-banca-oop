


//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito


public class Prestito
{
    public int Id { get; set; }
    public String Intestatario { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateOnly DataInizio { get; set; }
    public DateOnly DataFine { get; set; }

    //prestito in partenza dalla data specificata
    public Prestito(int id, string intestatario, int ammontare, int valoreRata, DateOnly dataInizio, DateOnly dataFine)
    {
        Id = id;
        Intestatario = intestatario;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        DataInizio = dataInizio;
        DataFine = dataFine;
    }

    //un prestito in data di oggi
    //public Prestito(int iD, int ammontare, int valoreRata, DateOnly fine, Cliente intestatario)
    //{
    //    ID = iD;
    //    Ammontare = ammontare;
    //    ValoreRata = valoreRata;
    //    //data di oggi
    //    Inizio = new DateOnly();
    //    Fine = fine;
    //    Intestatario = intestatario;
    //}
}
