using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using System.Collections.Generic;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class FormMoradaDetalhes : MaterialForm
    {
        int actionlocal;
        Morada morada;
        int indexLocal;
        private DB? dbContext;
        public FormMoradaDetalhes(int action, int index)
        {
            InitializeComponent();

            dbContext = new DB();
            this.dbContext.Database.EnsureCreated();

            actionlocal = action;
            indexLocal = index;

            //Build a list
            List<User> dataSource = new List<User>();
            dataSource = dbContext.Users.ToList();

            comboBox1.DataSource = new BindingSource(dataSource, null);       // Associa a lista à ComboBox
            comboBox1.DisplayMember = "Nome";                                  // Define qual o campo que surge na comboBox
            comboBox1.ValueMember = "ID";                                      // Define qual o campo que é extraído.
                                                                               // make it readonly
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

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
                        morada = dbContext.Moradas.First(x => x.ID == indexLocal);

                        if (morada == null)
                        {
                            throw new InvalidProgramException();
                        }

                        TextFieldRua.Text = morada.Rua;
                        TextFieldLote.Text = morada.Lote.ToString();
                        TextFieldAndar.Text = morada.Andar.ToString();
                        TextFieldPorta.Text = morada.Porta.ToString();
                        TextFieldPais.Text = morada.Pais;
                        TextFieldCodPostal1.Text = morada.CodPostal1.ToString();
                        TextFieldCodPostal2.Text = morada.CodPostal2.ToString();
                        comboBox1.SelectedValue = morada.user.ID;
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

                    morada = dbContext.Moradas.First(x => x.ID == indexLocal);

                    if (morada == null)
                    {
                        throw new InvalidProgramException();
                    }

                    TextFieldRua.Text = morada.Rua;
                    TextFieldLote.Text = morada.Lote.ToString();
                    TextFieldAndar.Text = morada.Andar.ToString();
                    TextFieldPorta.Text = morada.Porta.ToString();
                    TextFieldPais.Text = morada.Pais;
                    TextFieldCodPostal1.Text = morada.CodPostal1.ToString();
                    TextFieldCodPostal2.Text = morada.CodPostal2.ToString();
                    comboBox1.SelectedValue = morada.user.ID;

                    TextFieldRua.Enabled = false;
                    TextFieldLote.Enabled = false;
                    TextFieldAndar.Enabled = false;
                    TextFieldPorta.Enabled = false;
                    TextFieldPais.Enabled = false;
                    TextFieldCodPostal1.Enabled = false;
                    TextFieldCodPostal2.Enabled = false;
                    comboBox1.Enabled = false;
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

        private void ButtonAction_Click(object sender, System.EventArgs e)
        {
            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {

                case add:
                    morada = new Morada();

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        morada.Rua = TextFieldRua.Text.Trim();
                        morada.Porta = Convert.ToChar(TextFieldPorta.Text.Trim());
                        morada.Pais = TextFieldPais.Text.Trim();
                        morada.Lote = Convert.ToInt32(TextFieldLote.Text.Trim());
                        morada.Andar = Convert.ToInt32(TextFieldAndar.Text.Trim());
                        morada.CodPostal1 = Convert.ToInt32(TextFieldCodPostal1.Text.Trim());
                        morada.CodPostal2 = Convert.ToInt32(TextFieldCodPostal2.Text.Trim());
                        morada.user.ID = Convert.ToInt32(comboBox1.SelectedValue);

                        dbContext.Add(morada);

                        Close();
                    }

                    break;

                case edit:

                    //if para verificar se todos os campos estao corretos
                    if (MetodoValidaLocal())
                    {
                        morada.Rua = TextFieldRua.Text.Trim();
                        morada.Porta = Convert.ToChar(TextFieldPorta.Text.Trim());
                        morada.Pais = TextFieldPais.Text.Trim();
                        morada.Lote = Convert.ToInt32(TextFieldLote.Text.Trim());
                        morada.Andar = Convert.ToInt32(TextFieldAndar.Text.Trim());
                        morada.CodPostal1 = Convert.ToInt32(TextFieldCodPostal1.Text.Trim());
                        morada.CodPostal2 = Convert.ToInt32(TextFieldCodPostal2.Text.Trim());
                        morada.user.ID = Convert.ToInt32(comboBox1.SelectedValue);
                        dbContext.Update(morada);

                        Close();
                    }

                    break;

                case delete:
                    dbContext.Remove(morada);
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
            if(Convert.ToInt32(comboBox1.SelectedValue) == 0)
            {
                MessageBox.Show(
                    "Por favor selecione o funcionario dono desta morada",
                    "Aviso",   // Título
                    MessageBoxButtons.OK,       // Botões
                    MessageBoxIcon.Error  // Icon
                );

                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldRua.Text.Trim(), 30, 6, "Rua", true, true))
            {
                TextFieldRua.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldLote.Text.Trim(), 3, 1, "Lote", false, true))
            {
                TextFieldLote.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldAndar.Text.Trim(), 3, 1, "Andar", false, true))
            {
                TextFieldAndar.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldPorta.Text.Trim(), 1, 0, "Porta", true, true))
            {
                TextFieldLote.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldPais.Text.Trim(), 20, 4, "País", true, true))
            {
                TextFieldPais.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldCodPostal1.Text.Trim(), 4, 4, "codigo postal", false, true))
            {
                TextFieldAndar.Focus();
                return false;
            }
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextFieldCodPostal2.Text.Trim(), 5, 3, "codigo postal", false, true))
            {
                TextFieldCodPostal2.Focus();
                return false;
            }
            return true;
        }

    }
}
