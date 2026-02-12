using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using System.Drawing;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class FormOrdemTrabalho : MaterialForm
    {
        int ordemLocal;
        OrdemTrabalho ordem;
        int actionLocal;
        int indexLocal;
        private DB? dbContext;

        /// <summary>
        /// constructor da form
        /// </summary>
        /// <param name="ordem">int para identificar qual é a ordem a selecionada</param>
        /// <param name="action">int para identificar qual é a açao a ser tomada</param>
        public FormOrdemTrabalho(int ordem, int action,int index)
        {
            InitializeComponent();

            dbContext = new DB();
            this.dbContext.Database.EnsureCreated();

            ordemLocal = ordem;
            actionLocal = action;
            indexLocal = index;
        }

        private void OrdemTrabalho_Load(object sender, System.EventArgs e)
        {
            //switch para identificar qual é a ordem selecionada
            switch (ordemLocal)
            {
                case ORDEMCORRETIVA:
                    this.Text = "Ordem Corretiva";      //muda o titulo da form
                    labelMarca.Visible = false;         // muda a visibilidade do control para false
                    labelModelo.Visible = false;        // muda a visibilidade do control para false
                    textBoxMarca.Visible = false;       // muda a visibilidade do control para false
                    textBoxModelo.Visible = false;      // muda a visibilidade do control para false
                    pictureBoxFoto.Visible = false;     // muda a visibilidade do control para false

                    ////////////////////////////////////////////////////////////////
                    /////Move os controls para dar espaço para a picture box
                    ////////////////////////////////////////////////////////////////
                    labelTitulo.Location = new Point(42, 99);
                    textBoxTitulo.Location = new Point(147, 99);

                    labelLocalizacao.Location = new Point(42, 143);
                    textBoxLocalizacao.Location = new Point(147, 143);
                    break;

                case ORDEMPREVENTIVA:
                    this.Text = "Ordem Preventiva";         //muda o titulo da form

                    labelAssinaturaCliente.Visible = false; // muda a visibilidade do control para false
                    break;
            }

            //switch para identificar qual é a açao a ser tomada
            switch (actionLocal)
            {
                case add:
                    buttonAction.Text = "ADICIONAR";    //muda o texto do btn action 
                    buttonEnviar.Visible = false;       // muda a visibilidade do control para false
                    buttonImprimir.Visible = false;     // muda a visibilidade do control para false
                    break;

                case edit:
                    buttonAction.Text = "EDITAR";    //muda o texto do btn action 

                    try
                    {
                        ordem = dbContext.OrdemTrabalhos.First(x => x.ID == indexLocal);

                        if (ordem == null)
                        {
                            throw new InvalidProgramException();
                        }

                        textBoxTitulo.Text = ordem.NomeTitulo;
                        textBoxLocalizacao.Text = ordem.Localizacao;
                        textBoxMarca.Text = ordem.Marca;
                        textBoxModelo.Text = ordem.Modelo;
                        richTextBoxAssunto.Text = ordem.Descricao;

                        if (ordem.Estagio == true)
                        {
                            comboBoxEstagio.SelectedValue = 1;
                        }
                        else if (ordem.Estagio == false)
                        {
                            comboBoxEstagio.SelectedValue = 2;
                        }

                        comboBoxPrioridade.SelectedValue = ordem.Prioridade;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Artigo: \n Ocorreu um erro a tentar obter o ordem selecionad: \n",
                            "Stock",   // Título
                            MessageBoxButtons.OK,       // Botões
                            MessageBoxIcon.Error  // Icon
                        );
                    }

                    break;

                case delete:
                    buttonAction.Text = "Eliminar";    //muda o texto do btn action 
                    try
                    {
                        ordem = dbContext.OrdemTrabalhos.First(x => x.ID == indexLocal);

                        if (ordem == null)
                        {
                            throw new InvalidProgramException();
                        }

                        textBoxTitulo.Text = ordem.NomeTitulo;
                        textBoxLocalizacao.Text = ordem.Localizacao;
                        textBoxMarca.Text = ordem.Marca;
                        textBoxModelo.Text = ordem.Modelo;
                        richTextBoxAssunto.Text = ordem.Descricao;

                        if (ordem.Estagio == true)
                        {
                            comboBoxEstagio.SelectedValue = 1;
                        }
                        else if (ordem.Estagio == false)
                        {
                            comboBoxEstagio.SelectedValue = 2;
                        }

                        comboBoxPrioridade.SelectedValue = ordem.Prioridade;

                        textBoxTitulo.Enabled = false;
                        textBoxLocalizacao.Enabled = false;
                        textBoxMarca.Enabled = false;
                        textBoxModelo.Enabled = false;
                        richTextBoxAssunto.Enabled = false;
                        comboBoxEstagio.Enabled = false;
                        comboBoxPrioridade.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Artigo: \n Ocorreu um erro a tentar obter o ordem selecionad: \n",
                            "Stock",   // Título
                            MessageBoxButtons.OK,       // Botões
                            MessageBoxIcon.Error  // Icon
                        );
                    }

                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAction_Click(object sender, System.EventArgs e)
        {

            if(ordemLocal == ORDEMPREVENTIVA)
            {
                if (MetodoValidaLocal())
                {
                    //switch para verificar qual é a ação a tomar
                    switch (actionLocal)
                    {

                        case add:
                            ordem = new OrdemTrabalho();

                            //if para verificar se todos os campos estao corretos
                            if (MetodoValidaLocal())
                            {
                                ordem.NomeTitulo = textBoxTitulo.Text.Trim();
                                ordem.Localizacao = textBoxLocalizacao.Text.Trim();
                                ordem.Marca = textBoxLocalizacao.Text.Trim();
                                ordem.Descricao = textBoxLocalizacao.Text.Trim();
                                ordem.Modelo = textBoxModelo.Text.Trim();
                                ordem.DataDeInsercao = DateTime.Today;
                                ordem.Foto = pictureBoxFoto.Image;

                                if (comboBoxEstagio.SelectedIndex == 1)
                                {
                                    ordem.Estagio = true;
                                }
                                else if (comboBoxEstagio.SelectedIndex == 2)
                                {
                                    ordem.Estagio = false;
                                }

                                ordem.Prioridade = comboBoxPrioridade.SelectedIndex;
                                ordem.user.ID = 3;
                                ordem.controloDeOrdem.ID = 1;

                                dbContext.Add(ordem);
                                Close();
                            }

                            break;

                        case edit:

                            //if para verificar se todos os campos estao corretos
                            if (MetodoValidaLocal())
                            {
                                ordem.NomeTitulo = textBoxTitulo.Text.Trim();
                                ordem.Localizacao = textBoxLocalizacao.Text.Trim();
                                ordem.Marca = textBoxLocalizacao.Text.Trim();
                                ordem.Descricao = textBoxLocalizacao.Text.Trim();
                                ordem.Modelo = textBoxModelo.Text.Trim();

                                if (comboBoxEstagio.SelectedIndex == 1)
                                {
                                    ordem.Estagio = true;
                                }
                                else if (comboBoxEstagio.SelectedIndex == 2)
                                {
                                    ordem.Estagio = false;
                                }

                                ordem.Prioridade = comboBoxPrioridade.SelectedIndex;
                                ordem.user.ID = 1;
                                ordem.controloDeOrdem.ID = 1;

                                dbContext.Update(ordem);

                                Close();
                            }

                            break;

                        case delete:
                            dbContext.Remove(ordem);
                            Close();
                            break;
                    }
                }
            }
        }

        private void FormOrdemTrabalho_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FormOrdemTrabalho_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBoxFoto.Location.X && x <= pictureBoxFoto.Location.X + pictureBoxFoto.Width && y >= pictureBoxFoto.Location.Y && y <= pictureBoxFoto.Location.Y + pictureBoxFoto.Height)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBoxFoto.Image = Image.FromFile(files[0]);
                pictureBoxFoto.BackgroundImageLayout = ImageLayout.Stretch;

            }
        }

        /// <summary>
        /// método valida local chama o metodo valida global para fazer as verificações
        /// </summary>
        /// <returns></returns>
        private bool MetodoValidaLocal()
        {
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(textBoxTitulo.Text.Trim(), 50, 5, "Titulo", true, true))
            {
                textBoxTitulo.Focus();
                return false;
            }

            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(textBoxLocalizacao.Text.Trim(), 50, 5, "Localização", true, true))
            {
                textBoxLocalizacao.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(textBoxMarca.Text.Trim(), 20, 5, "Marca", true, true) && ordemLocal == 1)
            {
                textBoxMarca.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(textBoxModelo.Text.Trim(), 20, 5, "Modelo", true, true) && ordemLocal == 1)
            {
                textBoxModelo.Focus();
                return false;
            }
            return true;
        }
    }
}
