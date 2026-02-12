using System;
using System.Drawing;
/// <summary>
/// O cliente ter� que ter a op��o de adicionar um artigo oo stock da empresa, para isso ter� que introduzindo toda a informa��o acerca do artigo como foto, descri��o marca, modelo, log�tipo da empresa, nome, m�nimo de stock e tarefas a serem executadas quando for feita uma revis�o no artigo em quest�o.
/// </summary>
public class Artigo {
	public long ID { get; set; }
	public string Nome { get; set; }
	public int Quantidade { get; set; }
	public decimal Preco { get; set; }
	public string Descricao { get; set; }
	public Image Foto { get; set; }
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public long SerialNumber { get; set; }
	public long CategoriaID { get; set; }

	public Artigo_OrdemTrabalho[] artigo_OrdemTrabalho;
	public User[] user;

 
}

