using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class FuncionariosDetalhes : MaterialForm
    {
        int actionlocal;
        User user;
        int indexLocal;

        DB? db;

        public FuncionariosDetalhes(int action, int index)
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
                    ButtonAction.Text = "adicionar";

                    break;

                case edit:
                    ButtonAction.Text = "Editar";

                    //caso ocorra alguma exceção oo catch apresenta um msg box
                    try
                    {
                        user = db.Users.First(x => x.ID == indexLocal);

                        if (user == null)
                        {
                            throw new InvalidProgramException();
                        }

                        TextFieldNome.Text = user.Nome;
                        TextFieldIdade.Text = user.Idade.ToString();
                        TextFieldNiss.Text = user.Niss.ToString();
                        TextFieldNif.Text = user.Nif.ToString();
                        TextFieldCodCivil.Text = user.CodCivil.ToString();
                        TextFieldTelefone.Text = user.NumTelefone.ToString();
                        TextFieldUser.Text = user.Username;
                        TextFieldPassword.Text = user.Pass;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(
                            "Artigo: \n Ocorreu um erro a tentar obter o user selecionad: \n",
                            "Stock",   // Título
                            MessageBoxButtons.OK,       // Botões
                            MessageBoxIcon.Error  // Icon
                        );
                    }
                    break;

                case delete:
                    user = db.Users.First(x => x.ID == indexLocal);

                    if (user == null)
                    {
                        throw new InvalidProgramException();
                    }

                    TextFieldNome.Text = user.Nome;
                    TextFieldIdade.Text = user.Idade.ToString();
                    TextFieldNiss.Text = user.Niss.ToString();
                    TextFieldNif.Text = user.Nif.ToString();
                    TextFieldCodCivil.Text = user.CodCivil.ToString();
                    TextFieldTelefone.Text = user.NumTelefone.ToString();
                    TextFieldUser.Text = user.Username;
                    TextFieldPassword.Text = user.Pass;

                    TextFieldNome.Enabled = false;
                    TextFieldIdade.Enabled = false;
                    TextFieldNiss.Enabled = false;
                    TextFieldNif.Enabled = false;
                    TextFieldCodCivil.Enabled = false;
                    TextFieldTelefone.Enabled = false;
                    TextFieldUser.Enabled = false;
                    TextFieldPassword.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// metodo chamado pelo evento click do botao cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// metodo chamado pelo evento click do botao Criar Morada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCriarMorada_Click(object sender, EventArgs e)
        {
            Form morada = new FormMoradaDetalhes(add, 0);
            morada.ShowDialog();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {

                case add:
                    user = new User();

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        user.Nome = TextFieldNome.Text;
                        user.Idade = Convert.ToInt32(TextFieldIdade.Text.Trim());
                        user.Niss = Convert.ToInt32(TextFieldNiss.Text.Trim());
                        user.Nif = Convert.ToInt32(TextFieldNif.Text.Trim());
                        user.CodCivil = Convert.ToInt32(TextFieldCodCivil.Text.Trim());
                        user.NumTelefone = Convert.ToInt32(TextFieldTelefone.Text.Trim());
                        user.Username = TextFieldUser.Text.Trim();
                        user.Pass = TextFieldPassword.Text.Trim();
                        user.DataDeNascimento = DateTime.Today;
                        user.userControls.ID = 2;

                        db.Add(user);

                        Close();
                    }

                    break;

                case edit:

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        user.Nome = TextFieldNome.Text;
                        user.Idade = Convert.ToInt32(TextFieldIdade.Text.Trim());
                        user.Niss = Convert.ToInt32(TextFieldNiss.Text.Trim());
                        user.Nif = Convert.ToInt32(TextFieldNif.Text.Trim());
                        user.CodCivil = Convert.ToInt32(TextFieldCodCivil.Text.Trim());
                        user.NumTelefone = Convert.ToInt32(TextFieldTelefone.Text.Trim());
                        user.Username = TextFieldUser.Text.Trim();
                        user.Pass = TextFieldPassword.Text.Trim();
                        user.DataDeNascimento = DateTime.Today;
                        user.userControls.ID = 2;
                        db.Update(user);

                        Close();
                    }

                    break;

                case delete:
                    db.Remove(user);
                    Close();
                    break;
            }
        }

        /// <summary>
        /// método valida local chama o metodo valida global para fazer as verificações
        /// </summary>
        /// <returns></returns>
        private bool MetodoValidaLocal()
        {
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldUser.Text.Trim(), 20, 5, "Username", true, true))
            {
                TextFieldUser.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!IsPasswordValid(TextFieldPassword.Text.Trim(), 20, 5, PasswordRules.All))
            {
                TextFieldPassword.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldNome.Text.Trim(), 30, 2, "Nome", true, true))
            {
                TextFieldNome.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldIdade.Text.Trim(), 2, 1, "Idade", false, true))
            {
                TextFieldIdade.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldNiss.Text.Trim(), 12, 9, "Niss", false, true))
            {
                TextFieldNiss.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldNif.Text.Trim(), 12, 9, "Nif", false, true))
            {
                TextFieldNif.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldCodCivil.Text.Trim(), 12, 9, "CodCivil", false, true))
            {
                TextFieldNiss.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldTelefone.Text.Trim(), 12, 9, "Numero Telefone", false, true))
            {
                TextFieldTelefone.Focus();
                return false;
            }
            return true;
        }

    }
}
