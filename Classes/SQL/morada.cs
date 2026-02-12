using System;
/// <summary>
/// Morada para o user
/// </summary>
public class Morada {

    public int ID { get; set; }
    public string Rua { get; set; }
    public int Lote { get; set; }
    public int Andar { get; set; }
    public char Porta { get; set; }
    public string Pais { get; set; }
    public int CodPostal1 { get; set; }
    public int CodPostal2 { get; set; }

    public  User user = new User();
}
