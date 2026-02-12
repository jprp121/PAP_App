namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    partial class Login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.TextboxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(86, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(88, 131);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // ButtonAction
            // 
            this.ButtonAction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAction.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonAction.Location = new System.Drawing.Point(23, 191);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(87, 36);
            this.ButtonAction.TabIndex = 6;
            this.ButtonAction.Text = "ACTION";
            this.ButtonAction.UseVisualStyleBackColor = false;
            this.ButtonAction.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCancel.Location = new System.Drawing.Point(341, 191);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(87, 36);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Depth = 0;
            this.TextBoxUsername.Hint = "";
            this.TextBoxUsername.Location = new System.Drawing.Point(186, 90);
            this.TextBoxUsername.MaxLength = 20;
            this.TextBoxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.SelectionLength = 0;
            this.TextBoxUsername.SelectionStart = 0;
            this.TextBoxUsername.Size = new System.Drawing.Size(174, 23);
            this.TextBoxUsername.TabIndex = 10;
            this.TextBoxUsername.TabStop = false;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Depth = 0;
            this.TextboxPassword.Hint = "";
            this.TextboxPassword.Location = new System.Drawing.Point(186, 131);
            this.TextboxPassword.MaxLength = 20;
            this.TextboxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.SelectedText = "";
            this.TextboxPassword.SelectionLength = 0;
            this.TextboxPassword.SelectionStart = 0;
            this.TextboxPassword.Size = new System.Drawing.Size(174, 23);
            this.TextboxPassword.TabIndex = 11;
            this.TextboxPassword.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 239);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAction);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.Button ButtonCancel;
        private MaterialSkin.Controls.MaterialTextBox TextBoxUsername;
        private MaterialSkin.Controls.MaterialTextBox TextboxPassword;
    }
}