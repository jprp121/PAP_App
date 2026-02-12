using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using System.Drawing;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class FormArtigoDetalhes : MaterialForm
    {
        int actionlocal;
        Artigo artigo;
        int indexLocal; 
        private DB? dbContext;
        public FormArtigoDetalhes(int action, int index)
        {
            InitializeComponent();
            actionlocal = action;
            indexLocal = index; 

            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {
                case add:
                    ButtonAction.Text = "adicionar";
                    break;

                case edit:
                    ButtonAction.Text = "Editar";

                    try
                    {
                        artigo = dbContext.Artigos.First((e) => e.ID == indexLocal);
                            
                        if(artigo == null)
                        {
                            throw new InvalidProgramException();
                        }

                        TextFieldNome.Text = artigo.Nome;
                        TextFieldQuantidade.Text = artigo.Quantidade.ToString();
                        TextFieldPreco.Text = artigo.Preco.ToString();
                        richTextBoxDescricao.Text = artigo.Descricao;
                        pictureBoxArtigo.Image = artigo.Foto;
                        TextFieldModelo.Text = artigo.Modelo;
                        TextFieldMarca.Text = artigo.Marca;
                        TextFieldSerialNumber.Text = artigo.SerialNumber.ToString();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(
                            "Artigo: \n Ocorreu um erro a tentar obter o artigo selecionad: \n",
                            "Stock",   // Título
                            MessageBoxButtons.OK,       // Botões
                            MessageBoxIcon.Error  // Icon
                        );
                    }
                    break;

                case delete:
                    ButtonAction.Text = "Eliminar";

                    artigo = dbContext.Artigos.First((e) => e.ID == indexLocal);

                    if (artigo == null)
                    {
                        throw new InvalidProgramException();
                    }

                    TextFieldNome.Text = artigo.Nome;
                    TextFieldQuantidade.Text = artigo.Quantidade.ToString();
                    TextFieldPreco.Text = artigo.Preco.ToString();
                    richTextBoxDescricao.Text = artigo.Descricao;
                    pictureBoxArtigo.Image = artigo.Foto;
                    TextFieldModelo.Text = artigo.Modelo;
                    TextFieldMarca.Text = artigo.Marca;
                    TextFieldSerialNumber.Text = artigo.SerialNumber.ToString();
                    break;
            }
        }
        /// <summary>
        /// evento de click que fecha a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            Close(); 
        }

        private void Artigo_Load(object sender, System.EventArgs e)
        {
            dbContext = new DB();
            this.dbContext.Database.EnsureCreated();
        }

        private void ButtonAction_Click(object sender, System.EventArgs e)
        {
            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {

                case add:
                    artigo = new Artigo();

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        artigo.Nome = TextFieldNome.Text.Trim();
                        artigo.Quantidade = Convert.ToInt32(TextFieldQuantidade.Text.Trim());
                        artigo.Preco = Convert.ToDecimal(TextFieldPreco.Text.Trim());
                        artigo.Descricao = richTextBoxDescricao.Text.Trim();
                        artigo.Foto = pictureBoxArtigo.Image;
                        artigo.Modelo = TextFieldModelo.Text.Trim();
                        artigo.Marca = TextFieldMarca.Text.Trim();
                        artigo.SerialNumber = Convert.ToInt64(TextFieldSerialNumber.Text.Trim());
                        artigo.CategoriaID = 1;

                        dbContext.Artigos.Add(artigo);

                        Close();
                    }
                    
                    break;

                case edit:

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        artigo.Nome = TextFieldNome.Text.Trim();
                        artigo.Quantidade = Convert.ToInt32(TextFieldQuantidade.Text.Trim());
                        artigo.Preco = Convert.ToDecimal(TextFieldPreco.Text.Trim());
                        artigo.Descricao = richTextBoxDescricao.Text.Trim();
                        artigo.Foto = pictureBoxArtigo.Image;
                        artigo.Modelo = TextFieldModelo.Text.Trim();
                        artigo.Marca = TextFieldMarca.Text.Trim();
                        artigo.SerialNumber = Convert.ToInt64(TextFieldSerialNumber.Text.Trim());
                        artigo.CategoriaID = 1;

                        dbContext.Update(artigo);

                        Close();
                    }
                    
                    break;

                case delete:
                    dbContext.Remove(artigo);
                    Close();
                    break;
            }

                dbContext.SaveChanges();
        }

        /// <summary>
        /// método valida local chama o metodo valida global para fazer as verificações
        /// </summary>
        /// <returns></returns>
        private bool MetodoValidaLocal()
        {
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldNome.Text.Trim(), 30, 1, "Nome", true, true))
            {
                TextFieldNome.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldQuantidade.Text.Trim(), 3, 1, "Quantidade", false, true))
            {
                TextFieldQuantidade.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldMarca.Text.Trim(), 30, 5, "Marca", true, false))
            {
                TextFieldMarca.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldModelo.Text.Trim(), 20, 5, "Modelo", true, false))
            {
                TextFieldModelo.Focus();
                return false;
            }
            return true;
        }

        private void FormArtigoDetalhes_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBoxArtigo.Location.X && x <= pictureBoxArtigo.Location.X + pictureBoxArtigo.Width && y >= pictureBoxArtigo.Location.Y && y <= pictureBoxArtigo.Location.Y + pictureBoxArtigo.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBoxArtigo.Image = Image.FromFile(files[0]);
                pictureBoxArtigo.BackgroundImageLayout = ImageLayout.Stretch;

            }
        }

        private void FormArtigoDetalhes_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
