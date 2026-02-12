using System.Windows.Forms;
using MaterialSkin.Controls;
using static PAP_AppParaGestaoDeEmpresas.Classes.Settings;

namespace PAP_AppParaGestaoDeEmpresas.Forms
{
    public partial class Login : MaterialForm
    {
        int actionlocal;

        public Login(int action)
        {
            InitializeComponent();
            actionlocal = action;

            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {
                case 1:
                    ButtonAction.Text = "login";
                    break;

                case 2:
                    ButtonAction.Text = "Registar";
                    break;
            }
        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// evento de click que chama a form Principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAction_Click(object sender, System.EventArgs e)
        {
            //switch para verificar qual é a ação a tomar
            switch (actionlocal)
            {

                case 1:
                    var formInicial = new FormInicial();

                    //if (MetodoValidaLocal())
                    //{
                    this.Hide();
                    formInicial.Show();
                    //}

                    break;

                case 2:

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
            Application.Exit();
        }

        /// <summary>
        /// método valida local chama o metodo valida global para fazer as verificações
        /// </summary>
        /// <returns></returns>
        private bool MetodoValidaLocal()
        {
            //se o metodo valida global devolver um false significa que o campo nao foi preenchido corretamente assim sendo o metodo devolve um false
            if (!Valida(TextBoxUsername.Text.Trim(), 20, 5, "Username", true, true))
            {
                TextBoxUsername.Focus();
                return false;
            }


            return true;
        }
    }
}
