namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    partial class AcercaDe
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogotipo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(21, 82);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(633, 100);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TGPSI \r\nTurma De Gestão e Programação de Sistemas informaticos\r\n\r\nGestão e Manute" +
    "nção de Empresas\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "João Pedro Pina Nº10 3ºGI\r\n\r\nCiclo Letivo - 2018/19 ";
            // 
            // pictureBoxLogotipo
            // 
            this.pictureBoxLogotipo.BackgroundImage = global::PAP_AppParaGestaoDeEmpresas.Properties.Resources.ESFD;
            this.pictureBoxLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogotipo.Location = new System.Drawing.Point(487, 225);
            this.pictureBoxLogotipo.Name = "pictureBoxLogotipo";
            this.pictureBoxLogotipo.Size = new System.Drawing.Size(167, 103);
            this.pictureBoxLogotipo.TabIndex = 3;
            this.pictureBoxLogotipo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 357);
            this.Controls.Add(this.pictureBoxLogotipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.Name = "AcercaDe";
            this.Text = "AcercaDe";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogotipo;
    }
}