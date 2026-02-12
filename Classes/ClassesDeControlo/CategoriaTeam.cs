using System;
/// <summary>
/// Class para categoria para criar categorias e associa- las ao artigo
/// </summary>
public class CategoriaTeam {
	public long ID { get; set; }
	public string Nome { get; set; }
	public int Tipo { get; set; }

	private Team[] team;

}
