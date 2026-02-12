namespace PAP_AppParaGestaoDeEmpresas
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabpageStock = new System.Windows.Forms.TabPage();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.tabPageFuncionarios = new System.Windows.Forms.TabPage();
            this.listViewFuncionarios = new System.Windows.Forms.ListView();
            this.tabPageMorada = new System.Windows.Forms.TabPage();
            this.listViewMorada = new System.Windows.Forms.ListView();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.listViewTeam = new System.Windows.Forms.ListView();
            this.tabPageOrdemCorretiva = new System.Windows.Forms.TabPage();
            this.listViewOrdensCorretivas = new System.Windows.Forms.ListView();
            this.tabPageOrdensPreventivas = new System.Windows.Forms.TabPage();
            this.listViewOrdensPreventivas = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAcercaDe = new MaterialSkin.Controls.MaterialButton();
            this.timerUser = new System.Windows.Forms.Timer(this.components);
            this.ButtonTeam = new System.Windows.Forms.Button();
            this.ButtonCheckStock = new System.Windows.Forms.Button();
            this.ButtonAddMorada = new System.Windows.Forms.Button();
            this.ButtonAddFuncionario = new System.Windows.Forms.Button();
            this.ButtonOrdemPreventiva = new System.Windows.Forms.Button();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.ButtonAddArtigo = new System.Windows.Forms.Button();
            this.ButtonOrdemCorretiva = new System.Windows.Forms.Button();
            this.ButtonCheckOrdens = new System.Windows.Forms.Button();
            this.panelAddEditDel = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.materialTabControl.SuspendLayout();
            this.tabpageStock.SuspendLayout();
            this.tabPageFuncionarios.SuspendLayout();
            this.tabPageMorada.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.tabPageOrdemCorretiva.SuspendLayout();
            this.tabPageOrdensPreventivas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAddEditDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.BaseTabControl = this.materialTabControl;
            this.materialTabSelector.CausesValidation = false;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector.ForeColor = System.Drawing.SystemColors.Control;
            this.materialTabSelector.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(869, 23);
            this.materialTabSelector.TabIndex = 0;
            this.materialTabSelector.Text = "Stock";
            // 
            // materialTabControl
            // 
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tabPageHome);
            this.materialTabControl.Controls.Add(this.tabpageStock);
            this.materialTabControl.Controls.Add(this.tabPageFuncionarios);
            this.materialTabControl.Controls.Add(this.tabPageMorada);
            this.materialTabControl.Controls.Add(this.tabPageTeam);
            this.materialTabControl.Controls.Add(this.tabPageOrdemCorretiva);
            this.materialTabControl.Controls.Add(this.tabPageOrdensPreventivas);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(156, 115);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(31, 0);
            this.materialTabControl.TabIndex = 1;
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.MaterialTabControl_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(23, 0);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabpageStock
            // 
            this.tabpageStock.Controls.Add(this.listViewStock);
            this.tabpageStock.Location = new System.Drawing.Point(4, 22);
            this.tabpageStock.Name = "tabpageStock";
            this.tabpageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageStock.Size = new System.Drawing.Size(23, 0);
            this.tabpageStock.TabIndex = 1;
            this.tabpageStock.Text = "Stock";
            this.tabpageStock.UseVisualStyleBackColor = true;
            // 
            // listViewStock
            // 
            this.listViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStock.FullRowSelect = true;
            this.listViewStock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStock.Location = new System.Drawing.Point(3, 3);
            this.listViewStock.MultiSelect = false;
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(17, 0);
            this.listViewStock.TabIndex = 0;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            this.listViewStock.View = System.Windows.Forms.View.Details;
            this.listViewStock.Click += new System.EventHandler(this.listViewStock_Click);
            // 
            // tabPageFuncionarios
            // 
            this.tabPageFuncionarios.Controls.Add(this.listViewFuncionarios);
            this.tabPageFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageFuncionarios.Name = "tabPageFuncionarios";
            this.tabPageFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuncionarios.Size = new System.Drawing.Size(23, 0);
            this.tabPageFuncionarios.TabIndex = 2;
            this.tabPageFuncionarios.Text = "Funcionarios";
            this.tabPageFuncionarios.UseVisualStyleBackColor = true;
            // 
            // listViewFuncionarios
            // 
            this.listViewFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFuncionarios.FullRowSelect = true;
            this.listViewFuncionarios.LabelEdit = true;
            this.listViewFuncionarios.Location = new System.Drawing.Point(3, 3);
            this.listViewFuncionarios.MultiSelect = false;
            this.listViewFuncionarios.Name = "listViewFuncionarios";
            this.listViewFuncionarios.Size = new System.Drawing.Size(17, 0);
            this.listViewFuncionarios.TabIndex = 1;
            this.listViewFuncionarios.UseCompatibleStateImageBehavior = false;
            this.listViewFuncionarios.View = System.Windows.Forms.View.Details;
            this.listViewFuncionarios.Click += new System.EventHandler(this.listViewFuncionarios_Click);
            // 
            // tabPageMorada
            // 
            this.tabPageMorada.Controls.Add(this.listViewMorada);
            this.tabPageMorada.Location = new System.Drawing.Point(4, 22);
            this.tabPageMorada.Name = "tabPageMorada";
            this.tabPageMorada.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMorada.Size = new System.Drawing.Size(23, 0);
            this.tabPageMorada.TabIndex = 4;
            this.tabPageMorada.Text = "morada";
            this.tabPageMorada.UseVisualStyleBackColor = true;
            // 
            // listViewMorada
            // 
            this.listViewMorada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMorada.FullRowSelect = true;
            this.listViewMorada.LabelEdit = true;
            this.listViewMorada.Location = new System.Drawing.Point(3, 3);
            this.listViewMorada.MultiSelect = false;
            this.listViewMorada.Name = "listViewMorada";
            this.listViewMorada.Size = new System.Drawing.Size(17, 0);
            this.listViewMorada.TabIndex = 2;
            this.listViewMorada.UseCompatibleStateImageBehavior = false;
            this.listViewMorada.View = System.Windows.Forms.View.Details;
            this.listViewMorada.Click += new System.EventHandler(this.listViewMorada_Click);
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.listViewTeam);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(23, 0);
            this.tabPageTeam.TabIndex = 5;
            this.tabPageTeam.Text = "Team";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // listViewTeam
            // 
            this.listViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTeam.FullRowSelect = true;
            this.listViewTeam.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewTeam.Location = new System.Drawing.Point(3, 3);
            this.listViewTeam.MultiSelect = false;
            this.listViewTeam.Name = "listViewTeam";
            this.listViewTeam.Size = new System.Drawing.Size(17, 0);
            this.listViewTeam.TabIndex = 2;
            this.listViewTeam.UseCompatibleStateImageBehavior = false;
            this.listViewTeam.View = System.Windows.Forms.View.Details;
            this.listViewTeam.Click += new System.EventHandler(this.listViewTeam_Click);
            // 
            // tabPageOrdemCorretiva
            // 
            this.tabPageOrdemCorretiva.Controls.Add(this.listViewOrdensCorretivas);
            this.tabPageOrdemCorretiva.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrdemCorretiva.Name = "tabPageOrdemCorretiva";
            this.tabPageOrdemCorretiva.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdemCorretiva.Size = new System.Drawing.Size(23, 0);
            this.tabPageOrdemCorretiva.TabIndex = 6;
            this.tabPageOrdemCorretiva.Text = "Ordens Corretivas";
            this.tabPageOrdemCorretiva.UseVisualStyleBackColor = true;
            // 
            // listViewOrdensCorretivas
            // 
            this.listViewOrdensCorretivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrdensCorretivas.Enabled = false;
            this.listViewOrdensCorretivas.LabelEdit = true;
            this.listViewOrdensCorretivas.Location = new System.Drawing.Point(3, 3);
            this.listViewOrdensCorretivas.MultiSelect = false;
            this.listViewOrdensCorretivas.Name = "listViewOrdensCorretivas";
            this.listViewOrdensCorretivas.Size = new System.Drawing.Size(17, 0);
            this.listViewOrdensCorretivas.TabIndex = 2;
            this.listViewOrdensCorretivas.UseCompatibleStateImageBehavior = false;
            this.listViewOrdensCorretivas.View = System.Windows.Forms.View.Details;
            this.listViewOrdensCorretivas.VirtualMode = true;
            // 
            // tabPageOrdensPreventivas
            // 
            this.tabPageOrdensPreventivas.Controls.Add(this.listViewOrdensPreventivas);
            this.tabPageOrdensPreventivas.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrdensPreventivas.Name = "tabPageOrdensPreventivas";
            this.tabPageOrdensPreventivas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdensPreventivas.Size = new System.Drawing.Size(23, 0);
            this.tabPageOrdensPreventivas.TabIndex = 7;
            this.tabPageOrdensPreventivas.Text = "Ordens Preventivas";
            this.tabPageOrdensPreventivas.UseVisualStyleBackColor = true;
            // 
            // listViewOrdensPreventivas
            // 
            this.listViewOrdensPreventivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrdensPreventivas.FullRowSelect = true;
            this.listViewOrdensPreventivas.LabelEdit = true;
            this.listViewOrdensPreventivas.Location = new System.Drawing.Point(3, 3);
            this.listViewOrdensPreventivas.MultiSelect = false;
            this.listViewOrdensPreventivas.Name = "listViewOrdensPreventivas";
            this.listViewOrdensPreventivas.Size = new System.Drawing.Size(17, 0);
            this.listViewOrdensPreventivas.TabIndex = 3;
            this.listViewOrdensPreventivas.UseCompatibleStateImageBehavior = false;
            this.listViewOrdensPreventivas.View = System.Windows.Forms.View.Details;
            this.listViewOrdensPreventivas.Click += new System.EventHandler(this.listViewOrdensPreventivas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.materialTabSelector);
            this.panel1.Location = new System.Drawing.Point(-2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 23);
            this.panel1.TabIndex = 2;
            // 
            // ButtonAcercaDe
            // 
            this.ButtonAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAcercaDe.AutoSize = true;
            this.ButtonAcercaDe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAcercaDe.Depth = 0;
            this.ButtonAcercaDe.Icon = null;
            this.ButtonAcercaDe.Location = new System.Drawing.Point(767, 389);
            this.ButtonAcercaDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonAcercaDe.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAcercaDe.Name = "ButtonAcercaDe";
            this.ButtonAcercaDe.Size = new System.Drawing.Size(94, 36);
            this.ButtonAcercaDe.TabIndex = 12;
            this.ButtonAcercaDe.Text = "Acerca De";
            this.ButtonAcercaDe.UseVisualStyleBackColor = true;
            this.ButtonAcercaDe.Click += new System.EventHandler(this.ButtonAcercaDe_Click);
            // 
            // timerUser
            // 
            this.timerUser.Interval = 1;
            this.timerUser.Tick += new System.EventHandler(this.TimerUser_Tick);
            // 
            // ButtonTeam
            // 
            this.ButtonTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonTeam.Location = new System.Drawing.Point(65, 157);
            this.ButtonTeam.Name = "ButtonTeam";
            this.ButtonTeam.Size = new System.Drawing.Size(225, 36);
            this.ButtonTeam.TabIndex = 15;
            this.ButtonTeam.Text = "ADD TEAM";
            this.ButtonTeam.UseVisualStyleBackColor = false;
            this.ButtonTeam.Click += new System.EventHandler(this.ButtonTeam_Click);
            // 
            // ButtonCheckStock
            // 
            this.ButtonCheckStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonCheckStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCheckStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCheckStock.Location = new System.Drawing.Point(362, 230);
            this.ButtonCheckStock.Name = "ButtonCheckStock";
            this.ButtonCheckStock.Size = new System.Drawing.Size(141, 36);
            this.ButtonCheckStock.TabIndex = 16;
            this.ButtonCheckStock.Text = "CHECK STOCK";
            this.ButtonCheckStock.UseVisualStyleBackColor = false;
            // 
            // ButtonAddMorada
            // 
            this.ButtonAddMorada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonAddMorada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddMorada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddMorada.Location = new System.Drawing.Point(65, 303);
            this.ButtonAddMorada.Name = "ButtonAddMorada";
            this.ButtonAddMorada.Size = new System.Drawing.Size(225, 36);
            this.ButtonAddMorada.TabIndex = 17;
            this.ButtonAddMorada.Text = "CRIAR MORADA";
            this.ButtonAddMorada.UseVisualStyleBackColor = false;
            this.ButtonAddMorada.Click += new System.EventHandler(this.ButtonAddMorada_Click);
            // 
            // ButtonAddFuncionario
            // 
            this.ButtonAddFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonAddFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddFuncionario.Location = new System.Drawing.Point(65, 230);
            this.ButtonAddFuncionario.Name = "ButtonAddFuncionario";
            this.ButtonAddFuncionario.Size = new System.Drawing.Size(225, 36);
            this.ButtonAddFuncionario.TabIndex = 18;
            this.ButtonAddFuncionario.Text = "ADD FUNCIONARIO";
            this.ButtonAddFuncionario.UseVisualStyleBackColor = false;
            this.ButtonAddFuncionario.Click += new System.EventHandler(this.ButtonAddFuncionario_Click);
            // 
            // ButtonOrdemPreventiva
            // 
            this.ButtonOrdemPreventiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonOrdemPreventiva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOrdemPreventiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOrdemPreventiva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonOrdemPreventiva.Location = new System.Drawing.Point(580, 157);
            this.ButtonOrdemPreventiva.Name = "ButtonOrdemPreventiva";
            this.ButtonOrdemPreventiva.Size = new System.Drawing.Size(225, 36);
            this.ButtonOrdemPreventiva.TabIndex = 19;
            this.ButtonOrdemPreventiva.Text = "CRIAR ORDEM PREVENTIVA";
            this.ButtonOrdemPreventiva.UseVisualStyleBackColor = false;
            this.ButtonOrdemPreventiva.Click += new System.EventHandler(this.ButtonOrdemPreventiva_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddUser.Location = new System.Drawing.Point(362, 365);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(141, 36);
            this.ButtonAddUser.TabIndex = 20;
            this.ButtonAddUser.Text = "ADD USER";
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ButtonAddArtigo
            // 
            this.ButtonAddArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonAddArtigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddArtigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddArtigo.Location = new System.Drawing.Point(362, 157);
            this.ButtonAddArtigo.Name = "ButtonAddArtigo";
            this.ButtonAddArtigo.Size = new System.Drawing.Size(141, 36);
            this.ButtonAddArtigo.TabIndex = 21;
            this.ButtonAddArtigo.Text = "ADD ARTIGO";
            this.ButtonAddArtigo.UseVisualStyleBackColor = false;
            this.ButtonAddArtigo.Click += new System.EventHandler(this.ButtonAddArtigo_Click);
            // 
            // ButtonOrdemCorretiva
            // 
            this.ButtonOrdemCorretiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonOrdemCorretiva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOrdemCorretiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOrdemCorretiva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonOrdemCorretiva.Location = new System.Drawing.Point(580, 230);
            this.ButtonOrdemCorretiva.Name = "ButtonOrdemCorretiva";
            this.ButtonOrdemCorretiva.Size = new System.Drawing.Size(225, 36);
            this.ButtonOrdemCorretiva.TabIndex = 22;
            this.ButtonOrdemCorretiva.Text = "CRIAR ORDEM CORRETIVA";
            this.ButtonOrdemCorretiva.UseVisualStyleBackColor = false;
            this.ButtonOrdemCorretiva.Click += new System.EventHandler(this.ButtonOrdemCorretiva_Click);
            // 
            // ButtonCheckOrdens
            // 
            this.ButtonCheckOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ButtonCheckOrdens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCheckOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckOrdens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCheckOrdens.Location = new System.Drawing.Point(580, 303);
            this.ButtonCheckOrdens.Name = "ButtonCheckOrdens";
            this.ButtonCheckOrdens.Size = new System.Drawing.Size(225, 36);
            this.ButtonCheckOrdens.TabIndex = 23;
            this.ButtonCheckOrdens.Text = "CHECK ORDENS ABERTAS";
            this.ButtonCheckOrdens.UseVisualStyleBackColor = false;
            // 
            // panelAddEditDel
            // 
            this.panelAddEditDel.Controls.Add(this.buttonDel);
            this.panelAddEditDel.Controls.Add(this.buttonEdit);
            this.panelAddEditDel.Controls.Add(this.buttonAdd);
            this.panelAddEditDel.Location = new System.Drawing.Point(5, 93);
            this.panelAddEditDel.Name = "panelAddEditDel";
            this.panelAddEditDel.Size = new System.Drawing.Size(152, 335);
            this.panelAddEditDel.TabIndex = 24;
            this.panelAddEditDel.Visible = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(7, 210);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(132, 36);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "ELIMINAR";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(7, 137);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(132, 36);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "EDITAR";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(7, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 36);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "ADD ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 440);
            this.Controls.Add(this.panelAddEditDel);
            this.Controls.Add(this.ButtonCheckOrdens);
            this.Controls.Add(this.ButtonOrdemCorretiva);
            this.Controls.Add(this.ButtonAddArtigo);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.ButtonOrdemPreventiva);
            this.Controls.Add(this.ButtonAddFuncionario);
            this.Controls.Add(this.ButtonAddMorada);
            this.Controls.Add(this.ButtonCheckStock);
            this.Controls.Add(this.ButtonTeam);
            this.Controls.Add(this.ButtonAcercaDe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormInicial";
            this.Text = "gestão de empresas";
            this.materialTabControl.ResumeLayout(false);
            this.tabpageStock.ResumeLayout(false);
            this.tabPageFuncionarios.ResumeLayout(false);
            this.tabPageMorada.ResumeLayout(false);
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageOrdemCorretiva.ResumeLayout(false);
            this.tabPageOrdensPreventivas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelAddEditDel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabpageStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageFuncionarios;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ListView listViewFuncionarios;
        private MaterialSkin.Controls.MaterialButton ButtonAcercaDe;
        private System.Windows.Forms.Timer timerUser;
        private System.Windows.Forms.Button ButtonTeam;
        private System.Windows.Forms.Button ButtonCheckStock;
        private System.Windows.Forms.Button ButtonAddMorada;
        private System.Windows.Forms.Button ButtonAddFuncionario;
        private System.Windows.Forms.Button ButtonOrdemPreventiva;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button ButtonAddArtigo;
        private System.Windows.Forms.Button ButtonOrdemCorretiva;
        private System.Windows.Forms.Button ButtonCheckOrdens;
        private System.Windows.Forms.TabPage tabPageMorada;
        private System.Windows.Forms.ListView listViewMorada;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.ListView listViewTeam;
        private System.Windows.Forms.TabPage tabPageOrdemCorretiva;
        private System.Windows.Forms.ListView listViewOrdensCorretivas;
        private System.Windows.Forms.TabPage tabPageOrdensPreventivas;
        private System.Windows.Forms.ListView listViewOrdensPreventivas;
        private System.Windows.Forms.Panel panelAddEditDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
    }
}

