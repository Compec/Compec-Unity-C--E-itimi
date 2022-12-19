public class Insan
{
    protected string GozRenki;
    private float boyUzunlugu;

    public Insan(string gozRengiParametresi)
    {
        GozRenki = gozRengiParametresi;
    }

    public string GozRenkiGetir()
    {
        return GozRenki;
    }
    

    void Yuru()
    {
        //Yurume
    }
}



































public class Isci : Insan
{
    public Isci(string gozRengiParametresi) : base(gozRengiParametresi)
    {
        GozRenki = "asdasd";
    }
}
