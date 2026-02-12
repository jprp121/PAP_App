namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    partial class FormTeamDetalhes
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
            this.TextFieldNome = new MaterialSkin.Controls.MaterialTextBox();
            this.LabelNome = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDescriçao = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextFieldNome
            // 
            this.TextFieldNome.Depth = 0;
            this.TextFieldNome.Hint = "";
            this.TextFieldNome.Location = new System.Drawing.Point(199, 97);
            this.TextFieldNome.MaxLength = 30;
            this.TextFieldNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldNome.Name = "TextFieldNome";
            this.TextFieldNome.SelectedText = "";
            this.TextFieldNome.SelectionLength = 0;
            this.TextFieldNome.SelectionStart = 0;
            this.TextFieldNome.Size = new System.Drawing.Size(273, 23);
            this.TextFieldNome.TabIndex = 1;
            this.TextFieldNome.TabStop = false;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Depth = 0;
            this.LabelNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelNome.Location = new System.Drawing.Point(53, 97);
            this.LabelNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(50, 19);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome";
            // 
            // LabelDescriçao
            // 
            this.LabelDescriçao.AutoSize = true;
            this.LabelDescriçao.Depth = 0;
            this.LabelDescriçao.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDescriçao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDescriçao.Location = new System.Drawing.Point(53, 132);
            this.LabelDescriçao.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDescriçao.Name = "LabelDescriçao";
            this.LabelDescriçao.Size = new System.Drawing.Size(77, 19);
            this.LabelDescriçao.TabIndex = 4;
            this.LabelDescriçao.Text = "Descrição";
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.Location = new System.Drawing.Point(59, 167);
            this.TextBoxDescricao.MaxLength = 255;
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(494, 83);
            this.TextBoxDescricao.TabIndex = 5;
            this.TextBoxDescricao.Text = "";
            // 
            // buttonAction
            // 
            this.buttonAction.BackColor = System.Drawing.Color.Black;
            this.buttonAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAction.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAction.Location = new System.Drawing.Point(59, 256);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(90, 31);
            this.buttonAction.TabIndex = 6;
            this.buttonAction.Text = "ACTION";
            this.buttonAction.UseVisualStyleBackColor = false;
            this.buttonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(463, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 305);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.TextBoxDescricao);
            this.Controls.Add(this.LabelDescriçao);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextFieldNome);
            this.MaximizeBox = false;
            this.Name = "Team";
            this.Text = "Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox TextFieldNome;
        private MaterialSkin.Controls.MaterialLabel LabelNome;
        private MaterialSkin.Controls.MaterialLabel LabelDescriçao;
        private System.Windows.Forms.RichTextBox TextBoxDescricao;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonCancel;
    }
}