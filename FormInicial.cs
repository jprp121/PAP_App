using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PAP_AppParaGestaoDeEmpresas.Forms;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;
using PAP_AppParaGestaoDeEmpresas.Classes.SQL;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PAP_AppParaGestaoDeEmpresas
{
    public partial class FormInicial : MaterialForm
    {
        private DB? dbContext;
        bool expandido = false; //var para determinar se a form ja fez dropdown ou nao
        Button badmin = new Button();
        Button bCliente = new Button();
        List<Artigo> listaArtigo;
        List<Team> listaTeam;
        List<User> listaFuncionarios; 
        List<Morada> listaMoradas;
        List<OrdemTrabalho> listaOrdemPreventiva;

        int itemID;

        public object SQL_Connection { get; private set; }



        protected  void EnsureDBContext()
        {
            dbContext = new DB();
            this.dbContext.Database.EnsureCreated();
        }

        public FormInicial()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            Color btnColor = Color.FromArgb(31, 34, 35);

            ////////////////////////////////////////////////////////////////////////////////////////

            badmin.Size = new Size(200, 38);
            badmin.Location = new Point(480, 420);
            badmin.Text = "Add Admin";
            badmin.BackColor = btnColor;
            badmin.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            badmin.FlatStyle = FlatStyle.Popup;
            badmin.ForeColor = Color.White;



            bCliente.Size = new Size(200, 38);
            bCliente.Location = new Point(190, 420);
            bCliente.Text = "Add Cliente";
            bCliente.BackColor = btnColor;
            bCliente.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            bCliente.FlatStyle = FlatStyle.Popup;
            bCliente.ForeColor = Color.White;
            
        }

        /// <summary>
        /// método que cria e muda de lista
        /// </summary>
        /// <param name="lista"></param>
        private void ChangeLista(int lista)
        {
            //recebe um int para verificar qual é a lista inserida
            switch (lista)
            {
                case STOCK:
                    listViewStock.Clear();

                    // Adiciona a Coluna que falta;
                    listViewStock.Columns.Add("ID");
                    listViewStock.Columns.Add("Nome");
                    listViewStock.Columns.Add("Quantidade");
                    listViewStock.Columns.Add("SerialKey");
                    listViewStock.Columns.Add("Preco");
                    listViewStock.Columns.Add("Marca");
                    listViewStock.Columns.Add("Modelo");

                    // Definição dos nomes das colunas
                    listViewStock.Columns[0].Text = "ID";
                    listViewStock.Columns[1].Text = "Nome";
                    listViewStock.Columns[2].Text = "Quantidade";
                    listViewStock.Columns[3].Text = "SerialKey";
                    listViewStock.Columns[4].Text = "Preço";
                    listViewStock.Columns[5].Text = "Marca";
                    listViewStock.Columns[6].Text = "Modelo";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewStock.Columns[0].Width = (5 * listViewStock.Width) / 100;   // ID  -> sempre escondido
                    listViewStock.Columns[1].Width = (16 * listViewStock.Width) / 100;  // nome 
                    listViewStock.Columns[2].Width = (16 * listViewStock.Width) / 100;  // quantidade
                    listViewStock.Columns[3].Width = (16 * listViewStock.Width) / 100;  // serialKey
                    listViewStock.Columns[4].Width = (16 * listViewStock.Width) / 100;  // Preço 
                    listViewStock.Columns[5].Width = (16 * listViewStock.Width) / 100;  // Marca
                    listViewStock.Columns[6].Width = (16 * listViewStock.Width) / 100;  // Modelo

                    listaArtigo = dbContext.Artigos.ToList();

                    // Carregamento da listView
                    foreach (Artigo artigo in listaArtigo)
                    {
                        //Carrega listView, item a item (nota: as ListViewItem só aceitam strings)
                        ListViewItem row = new ListViewItem(new[] {
                            artigo.ID.ToString(),
                            artigo.Nome,
                            artigo.Quantidade.ToString(),
                            artigo.SerialNumber.ToString(),
                            artigo.Preco.ToString(),
                            artigo.Marca,
                            artigo.Modelo
                        });
                        listViewStock.Items.Add(row);
                    }
                    break;

                case FUNCIONARIOS:
                    listViewFuncionarios.Clear();

                    // Adiciona a Coluna que falta;
                    listViewFuncionarios.Columns.Add("ID");
                    listViewFuncionarios.Columns.Add("Nome");
                    listViewFuncionarios.Columns.Add("Idade");
                    listViewFuncionarios.Columns.Add("Niss");
                    listViewFuncionarios.Columns.Add("Nif");
                    listViewFuncionarios.Columns.Add("CodCivil");
                    listViewFuncionarios.Columns.Add("Data De Nascimento");
                    listViewFuncionarios.Columns.Add("Telefone");

                    // Definição dos nomes das colunas
                    listViewFuncionarios.Columns[0].Text = "ID";
                    listViewFuncionarios.Columns[1].Text = "Nome";
                    listViewFuncionarios.Columns[2].Text = "Idade";
                    listViewFuncionarios.Columns[3].Text = "Niss";
                    listViewFuncionarios.Columns[4].Text = "Nif";
                    listViewFuncionarios.Columns[5].Text = "CodCivil";
                    listViewFuncionarios.Columns[6].Text = "Data De Entrada";
                    listViewFuncionarios.Columns[7].Text = "Telefone";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewFuncionarios.Columns[0].Width = (2 * listViewFuncionarios.Width) / 100;   // ID  -> sempre escondido
                    listViewFuncionarios.Columns[1].Width = (14 * listViewFuncionarios.Width) / 100;  // Nome
                    listViewFuncionarios.Columns[2].Width = (14 * listViewFuncionarios.Width) / 100;  // Idade
                    listViewFuncionarios.Columns[3].Width = (14 * listViewFuncionarios.Width) / 100;  // Niss
                    listViewFuncionarios.Columns[4].Width = (14 * listViewFuncionarios.Width) / 100;  // Nif
                    listViewFuncionarios.Columns[5].Width = (14 * listViewFuncionarios.Width) / 100;  // CodCivil
                    listViewFuncionarios.Columns[6].Width = (14 * listViewFuncionarios.Width) / 100;  // Data De Nascimento
                    listViewFuncionarios.Columns[7].Width = (14 * listViewFuncionarios.Width) / 100;  // Telefone

                    listaFuncionarios = dbContext.Users.ToList();


                    // Carregamento da listView
                    foreach (User user in listaFuncionarios)
                    {
                        //Carrega listView, item a item (nota: as ListViewItem só aceitam strings)
                        ListViewItem row = new ListViewItem(new[] {
                            user.ID.ToString(),
                            user.Nome,
                            user.Idade.ToString(),
                            user.Niss.ToString(),
                            user.Nif.ToString(),
                            user.CodCivil.ToString(),
                            user.DataDeNascimento.ToString(),
                            user.NumTelefone.ToString()
                        });
                        listViewFuncionarios.Items.Add(row);
                    }

                    break;

                case MORADA:
                    listViewMorada.Clear();

                    // Adiciona a Coluna que falta
                    listViewMorada.Columns.Add("ID");
                    listViewMorada.Columns.Add("Rua");
                    listViewMorada.Columns.Add("Lote");
                    listViewMorada.Columns.Add("Andar");
                    listViewMorada.Columns.Add("Porta");
                    listViewMorada.Columns.Add("Pais");
                    listViewMorada.Columns.Add("Cod.Postal");

                    // Definição dos nomes das colunas
                    listViewMorada.Columns[0].Text = "ID";
                    listViewMorada.Columns[1].Text = "Rua";
                    listViewMorada.Columns[2].Text = "Lote";
                    listViewMorada.Columns[3].Text = "Andar";
                    listViewMorada.Columns[4].Text = "Porta";
                    listViewMorada.Columns[5].Text = "País";
                    listViewMorada.Columns[6].Text = "Cod.Postal";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewMorada.Columns[0].Width = (14 * listViewMorada.Width) / 100;   // ID  -> sempre escondido
                    listViewMorada.Columns[1].Width = (14 * listViewMorada.Width) / 100;  // Rua
                    listViewMorada.Columns[2].Width = (14 * listViewMorada.Width) / 100;  // Lote
                    listViewMorada.Columns[3].Width = (14 * listViewMorada.Width) / 100;  // Andar
                    listViewMorada.Columns[4].Width = (14 * listViewMorada.Width) / 100;  // Porta
                    listViewMorada.Columns[5].Width = (14 * listViewMorada.Width) / 100;  // País
                    listViewMorada.Columns[6].Width = (14 * listViewMorada.Width) / 100;  // Cod.Postal

                    listaMoradas = dbContext.Moradas.ToList();

                    // Carregamento da listView
                    foreach (Morada morada in listaMoradas)
                    {
                        //Carrega listView, item a item (nota: as ListViewItem só aceitam strings)
                        ListViewItem row = new ListViewItem(new[] {
                            morada.ID.ToString(),
                            morada.Rua,
                            morada.Lote.ToString(),
                            morada.Andar.ToString(),
                            morada.Porta.ToString(),
                            morada.Pais,
                            morada.CodPostal1.ToString()+ "-" + morada.CodPostal2.ToString(),
                        });
                        listViewMorada.Items.Add(row);
                    }

                    break;

                case TEAM:
                    listViewTeam.Clear();

                    // Adiciona a Coluna que falta
                    listViewTeam.Columns.Add("ID");
                    listViewTeam.Columns.Add("Nome");
                    listViewTeam.Columns.Add("Descricao");

                    // Definição dos nomes das colunas
                    listViewTeam.Columns[0].Text = "ID";
                    listViewTeam.Columns[1].Text = "Nome";
                    listViewTeam.Columns[2].Text = "Descrição";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewTeam.Columns[0].Width = (5 * listViewTeam.Width) / 100;   // ID  -> sempre escondido
                    listViewTeam.Columns[1].Width = (20 * listViewTeam.Width) / 100;  // Nome
                    listViewTeam.Columns[2].Width = (75 * listViewTeam.Width) / 100;  // Descrição

                    listaTeam = dbContext.Teams.ToList();

                    // Carregamento da listView
                    foreach (Team team in listaTeam)
                    {
                        //Carrega listView, item a item (nota: as ListViewItem só aceitam strings)
                        ListViewItem row = new ListViewItem(new[] {
                            team.ID.ToString(),
                            team.Nome,
                            team.Descricao,
                        });
                        listViewTeam.Items.Add(row);
                    }

                    break;

                case ORDEMCORRETIVA:
                    listViewOrdensCorretivas.Clear();

                    // Adiciona a Coluna que falta
                    listViewOrdensCorretivas.Columns.Add("ID");
                    listViewOrdensCorretivas.Columns.Add("Nome");
                    listViewOrdensCorretivas.Columns.Add("Estagio");
                    listViewOrdensCorretivas.Columns.Add("Localizacao");
                    listViewOrdensCorretivas.Columns.Add("Data");
                    listViewOrdensCorretivas.Columns.Add("Prioridade");

                    // Definição dos nomes das colunas
                    listViewOrdensCorretivas.Columns[0].Text = "ID";
                    listViewOrdensCorretivas.Columns[1].Text = "Nome";
                    listViewOrdensCorretivas.Columns[2].Text = "Estagio";
                    listViewOrdensCorretivas.Columns[3].Text = "Localizacao";
                    listViewOrdensCorretivas.Columns[4].Text = "Data";
                    listViewOrdensCorretivas.Columns[5].Text = "Prioridade";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewOrdensCorretivas.Columns[0].Width = (5 * listViewOrdensCorretivas.Width) / 100;   // ID  -> sempre escondido
                    listViewOrdensCorretivas.Columns[1].Width = (30 * listViewOrdensCorretivas.Width) / 100;  // Nome
                    listViewOrdensCorretivas.Columns[2].Width = (10 * listViewOrdensCorretivas.Width) / 100;  // Estagio
                    listViewOrdensCorretivas.Columns[3].Width = (20 * listViewOrdensCorretivas.Width) / 100;  // Localizacao
                    listViewOrdensCorretivas.Columns[4].Width = (20 * listViewOrdensCorretivas.Width) / 100;  // Data
                    listViewOrdensCorretivas.Columns[5].Width = (15 * listViewOrdensCorretivas.Width) / 100;  // Prioridade
                    break;

                case ORDEMPREVENTIVA:
                    listViewOrdensPreventivas.Clear();

                    // Adiciona a Coluna que falta
                    listViewOrdensPreventivas.Columns.Add("ID");
                    listViewOrdensPreventivas.Columns.Add("Nome");
                    listViewOrdensPreventivas.Columns.Add("Estagio");
                    listViewOrdensPreventivas.Columns.Add("Localizacao");
                    listViewOrdensPreventivas.Columns.Add("Data");
                    listViewOrdensPreventivas.Columns.Add("Prioridade");

                    // Definição dos nomes das colunas
                    listViewOrdensPreventivas.Columns[0].Text = "ID";
                    listViewOrdensPreventivas.Columns[1].Text = "Nome";
                    listViewOrdensPreventivas.Columns[2].Text = "Estagio";
                    listViewOrdensPreventivas.Columns[3].Text = "Localizacao";
                    listViewOrdensPreventivas.Columns[4].Text = "Data";
                    listViewOrdensPreventivas.Columns[5].Text = "Prioridade";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listViewOrdensPreventivas.Columns[0].Width = (8 * listViewOrdensPreventivas.Width) / 100;   // ID  -> sempre escondido
                    listViewOrdensPreventivas.Columns[1].Width = (12 * listViewOrdensPreventivas.Width) / 100;  // Nome
                    listViewOrdensPreventivas.Columns[2].Width = (12 * listViewOrdensPreventivas.Width) / 100;  // Estagio
                    listViewOrdensPreventivas.Columns[3].Width = (12 * listViewOrdensPreventivas.Width) / 100;  // Localizacao
                    listViewOrdensPreventivas.Columns[4].Width = (12 * listViewOrdensPreventivas.Width) / 100;  // Data
                    listViewOrdensPreventivas.Columns[5].Width = (12 * listViewOrdensPreventivas.Width) / 100;  // Prioridade

                    listaOrdemPreventiva = dbContext.OrdemTrabalhos.ToList();

                    // Carregamento da listView
                    foreach (OrdemTrabalho ordem in listaOrdemPreventiva)
                    {
                        string estagio;

                        if(ordem.Estagio == true)
                        {
                            estagio = "aberta";
                        }
                        else
                        {
                            estagio = "fechada";
                        }

                        //Carrega listView, item a item (nota: as ListViewItem só aceitam strings)
                        ListViewItem row = new ListViewItem(new[] {
                            ordem.ID.ToString(),
                            ordem.NomeTitulo,
                            estagio,
                            ordem.Localizacao,
                            ordem.DataDeInsercao.ToString(),
                            ordem.Prioridade.ToString()
                        });
                        listViewOrdensPreventivas.Items.Add(row);
                    }
                    break;

            }
        }

        /// <summary>
        /// sempre que o Index da tab muda, ou seja sempre que o user selecione 
        /// outra tab este metodo é ativado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaterialTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GC.Collect(); //Da clean up na memory excessiva
            ////switch para verificar qual foi a tab selecionada
            switch(materialTabControl.SelectedIndex)
            {
                case 0:
                    AlterarControls(0);
                    break;

                case STOCK:
                    AlterarControls(STOCK);
                    ChangeLista(STOCK);
                    break;

                case FUNCIONARIOS:
                    AlterarControls(FUNCIONARIOS);
                    ChangeLista(FUNCIONARIOS);
                    break;

                case MORADA:
                    AlterarControls(MORADA);
                    ChangeLista(MORADA);
                    break;

                case TEAM:
                    AlterarControls(TEAM);
                    ChangeLista(TEAM);
                    break;

                case ORDEMCORRETIVA:
                    AlterarControls(ORDEMCORRETIVA);
                    ChangeLista(ORDEMCORRETIVA);
                    break;

                case ORDEMPREVENTIVA:
                    AlterarControls(ORDEMPREVENTIVA);
                    ChangeLista(ORDEMPREVENTIVA);
                    break;
            }
        }

        /// <summary>
        /// evento de click que chama a form OrdemPreventiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOrdemCorretiva_Click(object sender, EventArgs e)
        {
            Form ordemCorretiva1 = new FormOrdemTrabalho(ordemCorretiva,add,0);
            ordemCorretiva1.ShowDialog();
        }

        /// <summary>
        /// evento de click que chama a form OrdemCorretiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOrdemPreventiva_Click(object sender, EventArgs e)
        {
            Form ordemPreventiva1 = new FormOrdemTrabalho(ordemPreventiva, add,0);
            ordemPreventiva1.ShowDialog();
        }

        /// <summary>
        /// evento de click que chama a form AcercaDe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAcercaDe_Click(object sender, EventArgs e)
        {
            Form acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        /// <summary>
        /// evento de click que ativa o timer para expandir a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            timerUser.Start();

            //if para verificar se a form ja expandiu ou nao
            if (!expandido)
            {
                ButtonAddUser.Text = "Close User";
                this.Controls.Add(bCliente);        //adiciona o botao a form
                this.Controls.Add(badmin);          //adiciona o botao a form
            }
            else
            {
                ButtonAddUser.Text = "add User";
                this.Controls.Remove(bCliente);     //retira o botao da form
                this.Controls.Remove(badmin);       //retira o botao da form
                timerUser.Start();                  //da start no timer
            }       
            


        }

        /// <summary>
        /// ativa o timer responsável pela mudança no tamanho da form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerUser_Tick(object sender, EventArgs e)
        {
            //if para verificar se a form tem que expandir ou diminuir
            if (this.Height > 440 && expandido)
            {
                this.Height = this.Height - 5;      //diminui o tamanho da form em 5
            }
            else if (this.Height < 500 && !expandido)
            {
                this.Height = this.Height + 5;      //incrementa o tamanho da form em 5

            }
            //caso a form ja esteja no tamanho pretendido para o 
            //timer e muda o bool responsavel por decidir se a form tem que expandir ou diminuir
            else if (this.Height == 440)
            {
                expandido = false;
                timerUser.Stop();
            }
            //caso a form ja esteja no tamanho pretendido para o 
            //timer e muda o bool responsavel por decidir se a form tem que expandir ou diminuir
            else if (this.Height == 500)
            {
                expandido = true;
                timerUser.Stop();
            }
        }

        /// <summary>
        /// chama a form morada atraves do evento click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddMorada_Click(object sender, EventArgs e)
        {
            Form morada = new FormMoradaDetalhes(add, 0);
            morada.ShowDialog();
        }

        #region artigo
        /// <summary>
        /// chama a form artigo atraves do evento click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddArtigo_Click(object sender, EventArgs e)
        {
            Form artigo = new FormArtigoDetalhes(add,0);
            artigo.ShowDialog();
        }

        private void listViewStock_Click(object sender, EventArgs e)
        {
            itemID = 0;
            // Obtem o 1º item clicado e extrai id
            ListViewItem item = listViewStock.SelectedItems[0];
            itemID = Int32.Parse(item.SubItems[0].Text);
        }
        #endregion

        #region team

        private void ButtonTeam_Click(object sender, EventArgs e)
        {
            Form team = new FormTeamDetalhes(add,0);
            team.ShowDialog();
        }

        private void listViewTeam_Click(object sender, EventArgs e)
        {
            itemID = 0;
            // Obtem o 1º item clicado e extrai id
            ListViewItem item = listViewTeam.SelectedItems[0];
            itemID = Int32.Parse(item.SubItems[0].Text);
        }

        #endregion

        #region funcionarios

        private void listViewFuncionarios_Click(object sender, EventArgs e)
        {
            itemID = 0;
            // Obtem o 1º item clicado e extrai id
            ListViewItem item = listViewFuncionarios.SelectedItems[0];
            itemID = Int32.Parse(item.SubItems[0].Text);
        }

        /// <summary>
        /// evento de click que chama a form Funcionario detlhes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddFuncionario_Click(object sender, EventArgs e)
        {
            Form a1 = new FuncionariosDetalhes(add, 0);
            a1.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Torna os controls visivel ou invisel de acordo com qual for o index da tab selecionado
        /// </summary>
        /// <param name="index"></param>
        private void AlterarControls(int index)
        {
            if (index != 0)
            {
                /////////////////////////////////////////////
                ////esconde os botões
                /////////////////////////////////////////////
                ButtonTeam.Visible = false;
                ButtonAddFuncionario.Visible = false;
                ButtonAddMorada.Visible = false;

                ButtonAddArtigo.Visible = false;
                ButtonCheckStock.Visible = false;
                ButtonAddUser.Visible = false;

                ButtonOrdemCorretiva.Visible = false;
                ButtonOrdemPreventiva.Visible = false;
                ButtonCheckOrdens.Visible = false;
                /////////////////////////////////////////////

                panelAddEditDel.Visible = true;

                /////////////////////////////////////////////
                ////Mostra a lista
                /////////////////////////////////////////////
                materialTabControl.Size = new Size(553, 298);

            }
            else if (index == 0)
            {
                /////////////////////////////////////////////
                ////Esconde a lista
                /////////////////////////////////////////////
                materialTabControl.Size = new Size(0, 0);

                /////////////////////////////////////////////
                ////Mostra os botões
                /////////////////////////////////////////////
                ButtonTeam.Visible = true;
                ButtonAddFuncionario.Visible = true;
                ButtonAddMorada.Visible = true;

                ButtonAddArtigo.Visible = true;
                ButtonCheckStock.Visible = true;
                ButtonAddUser.Visible = true;

                ButtonOrdemCorretiva.Visible = true;
                ButtonOrdemPreventiva.Visible = true;
                ButtonCheckOrdens.Visible = true;

                /////////////////////////////////////////////

                panelAddEditDel.Visible = false;
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro, tente novamente");
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            switch (materialTabControl.SelectedIndex)
            {
                case STOCK:
                    Form artigo = new FormArtigoDetalhes(add,0);
                    artigo.ShowDialog();
                    ChangeLista(STOCK);
                    break;

                case FUNCIONARIOS:
                    Form funcionario = new FuncionariosDetalhes(add, 0);
                    funcionario.ShowDialog();
                    ChangeLista(FUNCIONARIOS);
                    break;

                case MORADA:
                    Form morada = new FormMoradaDetalhes(add, 0);
                    morada.ShowDialog();
                    ChangeLista(MORADA);
                    break;

                case TEAM:
                    Form team = new FormTeamDetalhes(add, 0);
                    team.ShowDialog();
                    ChangeLista(TEAM);
                    break;

                case ORDEMPREVENTIVA:
                    Form ordemPreventiva = new FormOrdemTrabalho(ORDEMPREVENTIVA, add, 0);
                    ordemPreventiva.ShowDialog();
                    ChangeLista(ORDEMPREVENTIVA);
                    break;
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Se o ID é válido => constroi o objeto e envia-o para a Form respetiva 
            if (itemID > -1)
            {
                switch (materialTabControl.SelectedIndex)
                {
                    case STOCK:
                        // Caso haja itens clicados => we are good to go
                        if (listViewStock.SelectedItems.Count > 0)
                        {
                            Form artigo = new FormArtigoDetalhes(edit, itemID);
                            artigo.ShowDialog();
                            ChangeLista(STOCK);
                        }
                        break;

                    case FUNCIONARIOS:

                        // Caso haja itens clicados => we are good to go
                        if (listViewFuncionarios.SelectedItems.Count > 0)
                        {
                            Form funcionario = new FuncionariosDetalhes(edit, itemID);
                            funcionario.ShowDialog();
                            ChangeLista(FUNCIONARIOS);
                        }
                        break;

                    case MORADA:

                        // Caso haja itens clicados => we are good to go
                        if (listViewMorada.SelectedItems.Count > 0)
                        {
                            Form morada = new FormMoradaDetalhes(edit, itemID);
                            morada.ShowDialog();
                            ChangeLista(MORADA);
                        }
                        break;

                    case TEAM:

                        // Caso haja itens clicados => we are good to go
                        if (listViewTeam.SelectedItems.Count > 0)
                        {
                            Form team = new FormTeamDetalhes(edit, itemID);
                            team.ShowDialog();
                            ChangeLista(TEAM);
                        }
                        break;

                    case ORDEMPREVENTIVA:
                        
                        // Caso haja itens clicados => we are good to go
                        if (listViewOrdensPreventivas.SelectedItems.Count > 0)
                        {
                            Form ordemPreventiva = new FormOrdemTrabalho(ORDEMPREVENTIVA,edit, itemID);
                            ordemPreventiva.ShowDialog();
                            ChangeLista(ORDEMPREVENTIVA);
                        }
                        break;
                }
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            switch (materialTabControl.SelectedIndex)
            {
                case STOCK:
                    Form artigo = new FormArtigoDetalhes(delete, itemID);
                    artigo.ShowDialog();
                    ChangeLista(STOCK);
                    break;
                    
                case FUNCIONARIOS:
                    Form funcionario = new FuncionariosDetalhes(delete, itemID);
                    funcionario.ShowDialog();
                    ChangeLista(FUNCIONARIOS);
                    break;

                case MORADA:
                    Form morada = new FormMoradaDetalhes(delete, itemID);
                    morada.ShowDialog();
                    ChangeLista(MORADA);
                    break;

                case TEAM:
                    Form team = new FormTeamDetalhes(delete, itemID);
                    team.ShowDialog();
                    ChangeLista(TEAM);
                    break;

                case ORDEMPREVENTIVA:
                    Form ordemPreventiva = new FormOrdemTrabalho(ORDEMPREVENTIVA, delete, itemID);
                    ordemPreventiva.ShowDialog();
                    ChangeLista(ORDEMPREVENTIVA);
                    break;
            }
        }

        private void listViewMorada_Click(object sender, EventArgs e)
        {
            itemID = 0;
            // Obtem o 1º item clicado e extrai id
            ListViewItem item = listViewMorada.SelectedItems[0];
            itemID = Int32.Parse(item.SubItems[0].Text);
        }

        private void listViewOrdensPreventivas_Click(object sender, EventArgs e)
        {
            itemID = 0;
            // Obtem o 1º item clicado e extrai id
            ListViewItem item = listViewOrdensPreventivas.SelectedItems[0];
            itemID = Int32.Parse(item.SubItems[0].Text);
        }
    }
}
