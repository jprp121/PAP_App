using System;
using System.Drawing;

public class OrdemTrabalho {
	public int ID;
	public string NomeTitulo { get; set; }
	public bool Estagio { get; set; }
	public string Localizacao { get; set; }
	public string Descricao { get; set; }
	public DateTime DataDeInsercao { get; set; }
	public string AssinaturaTecnico { get; set; }
	public string AssinaturaCliente { get; set; }
	public int Prioridade { get; set; }
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public Image Foto { get; set; }

	public User user = new User();
	private Artigo_OrdemTrabalho[] artigos;

	public CategoriaOrdem controloDeOrdem = new CategoriaOrdem();
}
