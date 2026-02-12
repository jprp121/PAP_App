using System;

public class Team {
	public int ID;
	public string Nome { get; set; }
	public string Descricao { get; set; }
    public int CategoriaTeamID { get; set; }

    public CategoriaTeam categoriaTeam;
	public User_Team[] users;

}
