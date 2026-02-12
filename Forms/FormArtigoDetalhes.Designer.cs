namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    partial class FormArtigoDetalhes
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
            this.ButtonAction = new MaterialSkin.Controls.MaterialButton();
            this.ButtonCancel = new MaterialSkin.Controls.MaterialButton();
            this.labelNome = new System.Windows.Forms.Label();
            this.TextFieldNome = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBoxArtigo = new System.Windows.Forms.PictureBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.TextFieldPreco = new MaterialSkin.Controls.MaterialTextBox();
            this.TextFieldQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.TextFieldModelo = new MaterialSkin.Controls.MaterialTextBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.TextFieldMarca = new MaterialSkin.Controls.MaterialTextBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.TextFieldSerialNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtigo)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAction
            // 
            this.ButtonAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAction.AutoSize = true;
            this.ButtonAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAction.Depth = 0;
            this.ButtonAction.Icon = null;
            this.ButtonAction.Location = new System.Drawing.Point(12, 630);
            this.ButtonAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(70, 36);
            this.ButtonAction.TabIndex = 0;
            this.ButtonAction.Text = "Action";
            this.ButtonAction.UseVisualStyleBackColor = true;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCancel.Depth = 0;
            this.ButtonCancel.Icon = null;
            this.ButtonCancel.Location = new System.Drawing.Point(677, 630);
            this.ButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(73, 36);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(174, 108);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // TextFieldNome
            // 
            this.TextFieldNome.Depth = 0;
            this.TextFieldNome.Hint = "";
            this.TextFieldNome.Location = new System.Drawing.Point(285, 108);
            this.TextFieldNome.MaxLength = 30;
            this.TextFieldNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldNome.Name = "TextFieldNome";
            this.TextFieldNome.SelectedText = "";
            this.TextFieldNome.SelectionLength = 0;
            this.TextFieldNome.SelectionStart = 0;
            this.TextFieldNome.Size = new System.Drawing.Size(261, 23);
            this.TextFieldNome.TabIndex = 3;
            this.TextFieldNome.TabStop = false;
            this.TextFieldNome.Password = false;
            // 
            // pictureBoxArtigo
            // 
            this.pictureBoxArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxArtigo.Location = new System.Drawing.Point(23, 87);
            this.pictureBoxArtigo.Name = "pictureBoxArtigo";
            this.pictureBoxArtigo.Size = new System.Drawing.Size(110, 96);
            this.pictureBoxArtigo.TabIndex = 4;
            this.pictureBoxArtigo.TabStop = false;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(174, 137);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(88, 16);
            this.labelQuantidade.TabIndex = 6;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // TextFieldPreco
            // 
            this.TextFieldPreco.Depth = 0;
            this.TextFieldPreco.Hint = "";
            this.TextFieldPreco.Location = new System.Drawing.Point(656, 166);
            this.TextFieldPreco.MaxLength = 10;
            this.TextFieldPreco.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldPreco.Name = "TextFieldPreco";
            this.TextFieldPreco.SelectedText = "";
            this.TextFieldPreco.SelectionLength = 0;
            this.TextFieldPreco.SelectionStart = 0;
            this.TextFieldPreco.Size = new System.Drawing.Size(75, 23);
            this.TextFieldPreco.TabIndex = 7;
            this.TextFieldPreco.TabStop = false;
            this.TextFieldPreco.Password = false;
            // 
            // TextFieldQuantidade
            // 
            this.TextFieldQuantidade.Depth = 0;
            this.TextFieldQuantidade.Hint = "";
            this.TextFieldQuantidade.Location = new System.Drawing.Point(285, 137);
            this.TextFieldQuantidade.MaxLength = 3;
            this.TextFieldQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldQuantidade.Name = "TextFieldQuantidade";
            this.TextFieldQuantidade.SelectedText = "";
            this.TextFieldQuantidade.SelectionLength = 0;
            this.TextFieldQuantidade.SelectionStart = 0;
            this.TextFieldQuantidade.Size = new System.Drawing.Size(75, 23);
            this.TextFieldQuantidade.TabIndex = 8;
            this.TextFieldQuantidade.TabStop = false;
            this.TextFieldQuantidade.Password = false;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(394, 137);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(51, 16);
            this.labelMarca.TabIndex = 9;
            this.labelMarca.Text = "Marca";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(20, 213);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(79, 16);
            this.labelDescricao.TabIndex = 10;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(571, 167);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(49, 16);
            this.labelPreco.TabIndex = 11;
            this.labelPreco.Text = "Preço";
            // 
            // TextFieldModelo
            // 
            this.TextFieldModelo.Depth = 0;
            this.TextFieldModelo.Hint = "";
            this.TextFieldModelo.Location = new System.Drawing.Point(471, 166);
            this.TextFieldModelo.MaxLength = 20;
            this.TextFieldModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldModelo.Name = "TextFieldModelo";
            this.TextFieldModelo.SelectedText = "";
            this.TextFieldModelo.SelectionLength = 0;
            this.TextFieldModelo.SelectionStart = 0;
            this.TextFieldModelo.Size = new System.Drawing.Size(75, 23);
            this.TextFieldModelo.TabIndex = 12;
            this.TextFieldModelo.TabStop = false;
            this.TextFieldModelo.Password = false;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescricao.Location = new System.Drawing.Point(23, 232);
            this.richTextBoxDescricao.MaxLength = 65535;
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(708, 381);
            this.richTextBoxDescricao.TabIndex = 13;
            this.richTextBoxDescricao.Text = "";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(394, 170);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(60, 16);
            this.labelModelo.TabIndex = 14;
            this.labelModelo.Text = "Modelo";
            // 
            // TextFieldMarca
            // 
            this.TextFieldMarca.Depth = 0;
            this.TextFieldMarca.Hint = "";
            this.TextFieldMarca.Location = new System.Drawing.Point(471, 137);
            this.TextFieldMarca.MaxLength = 30;
            this.TextFieldMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldMarca.Name = "TextFieldMarca";
            this.TextFieldMarca.SelectedText = "";
            this.TextFieldMarca.SelectionLength = 0;
            this.TextFieldMarca.SelectionStart = 0;
            this.TextFieldMarca.Size = new System.Drawing.Size(75, 23);
            this.TextFieldMarca.TabIndex = 15;
            this.TextFieldMarca.TabStop = false;
            this.TextFieldMarca.Password = false;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(174, 170);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(103, 16);
            this.labelSerialNumber.TabIndex = 16;
            this.labelSerialNumber.Text = "SerialNumber";
            // 
            // TextFieldSerialNumber
            // 
            this.TextFieldSerialNumber.Depth = 0;
            this.TextFieldSerialNumber.Hint = "";
            this.TextFieldSerialNumber.Location = new System.Drawing.Point(285, 166);
            this.TextFieldSerialNumber.MaxLength = 19;
            this.TextFieldSerialNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldSerialNumber.Name = "TextFieldSerialNumber";
            this.TextFieldSerialNumber.SelectedText = "";
            this.TextFieldSerialNumber.SelectionLength = 0;
            this.TextFieldSerialNumber.SelectionStart = 0;
            this.TextFieldSerialNumber.Size = new System.Drawing.Size(75, 23);
            this.TextFieldSerialNumber.TabIndex = 17;
            this.TextFieldSerialNumber.TabStop = false;
            this.TextFieldSerialNumber.Password = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(571, 108);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(76, 16);
            this.labelCategoria.TabIndex = 18;
            this.labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(656, 108);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 19;
            // 
            // FormArtigoDetalhes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.TextFieldSerialNumber);
            this.Controls.Add(this.labelSerialNumber);
            this.Controls.Add(this.TextFieldMarca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.TextFieldModelo);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.TextFieldQuantidade);
            this.Controls.Add(this.TextFieldPreco);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.pictureBoxArtigo);
            this.Controls.Add(this.TextFieldNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAction);
            this.Name = "FormArtigoDetalhes";
            this.Text = "Artigo";
            this.Load += new System.EventHandler(this.Artigo_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormArtigoDetalhes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormArtigoDetalhes_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonAction;
        private MaterialSkin.Controls.MaterialButton ButtonCancel;
        private System.Windows.Forms.Label labelNome;
        private MaterialSkin.Controls.MaterialTextBox TextFieldNome;
        private System.Windows.Forms.PictureBox pictureBoxArtigo;
        private System.Windows.Forms.Label labelQuantidade;
        private MaterialSkin.Controls.MaterialTextBox TextFieldPreco;
        private MaterialSkin.Controls.MaterialTextBox TextFieldQuantidade;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelPreco;
        private MaterialSkin.Controls.MaterialTextBox TextFieldModelo;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Label labelModelo;
        private MaterialSkin.Controls.MaterialTextBox TextFieldMarca;
        private System.Windows.Forms.Label labelSerialNumber;
        private MaterialSkin.Controls.MaterialTextBox TextFieldSerialNumber;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}