using System.Windows.Forms;
using MaterialSkin.Controls;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using System;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class FormTeamDetalhes : MaterialForm
    {
        int actionlocal;
        Team team;
        int indexLocal;

             DB? db;

        public FormTeamDetalhes(int action, int index)
        {
            InitializeComponent();
             db = new DB();
            this.db.Database.EnsureCreated();
            actionlocal = action;
            indexLocal = index;

            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {
                case add:
                    buttonAction.Text = "adicionar";
                    break;

                case edit:
                    buttonAction.Text = "Editar";

                    try
                    {
                        team = db.Teams.First(x => x.ID ==  indexLocal);

                        if (team == null)
                        {
                            throw new InvalidProgramException();
                        }

                        TextFieldNome.Text = team.Nome;
                        TextBoxDescricao.Text = team.Descricao;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(
                            "Team: \n Ocorreu um erro a tentar obter o team selecionad: \n",
                            "Stock",   // Título
                            MessageBoxButtons.OK,       // Botões
                            MessageBoxIcon.Error  // Icon
                        );
                    }
                    break;

                case delete:
                    buttonAction.Text = "Eliminar";

                    team = db.Teams.First(x => x.ID ==  indexLocal);

                    if (team == null)
                    {
                        throw new InvalidProgramException();
                    }

                    TextFieldNome.Text = team.Nome;
                    TextBoxDescricao.Text = team.Descricao;

                    TextBoxDescricao.Enabled = false;
                    TextFieldNome.Enabled = false;
                    break;
            }
        }
        private void ButtonAction_Click(object sender, System.EventArgs e)
        {
            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {

                case add:
                    team = new Team();

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        team.Nome = TextFieldNome.Text.Trim();
                        team.Descricao = TextBoxDescricao.Text.Trim();
                        team.CategoriaTeamID = 1;

                        db.Add(team);
                        Close();
                    }

                    break;

                case edit:

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        team.Nome = TextFieldNome.Text.Trim();
                        team.Descricao = TextBoxDescricao.Text.Trim();
                        team.CategoriaTeamID = 1;

                        db.Update(team);
                        Close();
                    }

                    break;

                case delete:
                    db.Remove(team);
                    Close();
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

        /// <summary>
        /// método valida local chama o metodo valida global para fazer as verificações
        /// </summary>
        /// <returns></returns>
        private bool MetodoValidaLocal()
        {
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldNome.Text.Trim(), 30, 4, "Nome", true, true))
            {
                TextFieldNome.Focus();
                return false;
            }

            return true;
        }
    }
}
