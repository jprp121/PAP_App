using System;
using System.Drawing;

public class User {
	public int ID { get; set; }
	public string Username { get; set; }
	public string Pass { get; set; }
	public string Nome { get; set; }
	public int Idade { get; set; }
	public long Niss { get; set; }
	public long Nif { get; set; }
	public long CodCivil { get; set; }
	public DateTime DataDeNascimento { get; set; }
	public Image Foto { get; set; }
	public int NumTelefone { get; set; }
	public string Localizacao { get; set; }
	public bool IsBoss { get; set; }

	public User_Team[] user_Team;
	public Morada[] moradas;

	public OrdemTrabalho[] ordemTrabalho;
	public Artigo[] artigo;
	public CategoriaUser userControls = new CategoriaUser();
}
