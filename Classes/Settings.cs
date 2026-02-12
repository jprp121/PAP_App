using System;
using System.Windows.Forms;

namespace PAP_AppParaGestaoDeEmpresas.Classes
{
    // <summary>
    /// Classe para registo de Constantes e variáveis globais ao projeto
    /// Static para não gerar objetos. É o repositório de dados e métodos central.
    /// Internal para só ser acedida a partir do projeto
    /// </summary>
    static public class Settings
    {
        #region variaveis globais

        public const int ordemCorretiva = 1;
        public const int ordemPreventiva = 2;

        public const int STOCK = 1;
        public const int FUNCIONARIOS = 2;
        public const int MORADA = 3;
        public const int TEAM = 4;
        public const int ORDEMCORRETIVA = 5;
        public const int ORDEMPREVENTIVA = 6;

        public const int add = 1;
        public const int edit = 2;
        public const int delete = 3;

        public const int DBMS_NULL = 0;
        public const int DBMS_MYSQL = 1;
        #endregion

        #region flags
        [Flags]
        public enum PasswordRules
        {
            /// <summary>
            /// Password must contain a digit
            /// </summary>
            Digit = 1,
            /// <summary>
            /// Password must contain an uppercase letter
            /// </summary>
            UpperCase = 2,
            /// <summary>
            /// Password must contain a lowercase letter
            /// </summary>
            LowerCase = 4,
            /// <summary>
            /// Password must have both upper and lower case letters
            /// </summary>
            MixedCase = 6,
            /// <summary>
            /// Password must include a non-alphanumeric character
            /// </summary>
            SpecialChar = 8,
            /// <summary>
            /// All rules should be checked
            /// </summary>
            All = 15,
            /// <summary>
            /// No rules should be checked
            /// </summary>
            None = 0
        }
        #endregion

        #region Métodos Globais

        /// <summary>
        /// Método para verificar se a password foi bem introduzida
        /// </summary>
        /// <param name="password">input do user</param>
        /// <param name="charMax">quantidade max de caracteres permitidos pela BD</param>
        /// <param name="charMin">quantidade min de caracteres permitidos pela BD</param>
        /// <param name="rules">A flag que identifica quais sao os parametros a serem verificados</param>
        /// <returns></returns>
        public static bool IsPasswordValid(string password, int charMax, int charMin, PasswordRules rules)
        { 
            bool result = true;
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            string allChars = lower + upper + digits;

            if (password == "")
            {
                MessageBox.Show(
                    "A password tem que ser preenchida",
                    "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            if (password.Length > charMax)
            {

                MessageBox.Show(
                    "A password excede o valor máximo de carateres: " + charMax + ".",
                    "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            //if para verificar se o input excede o min de chars permitidos
            if (password.Length < charMin)
            {
                MessageBox.Show(
                    "A password não atinge o requisito minimo de caracteres: " + charMin + ".",
                    "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            //Check Lowercase if rule is enforced
            if (Convert.ToBoolean(rules & PasswordRules.LowerCase))
            {
                result &= (password.IndexOfAny(lower.ToCharArray()) >= 0);
            }
            if(!result)
            {
                MessageBox.Show("Falta a Inserção de Caracters minusculos");
                return result;
            }
            //Check Uppercase if rule is enforced
            if (Convert.ToBoolean(rules & PasswordRules.UpperCase))
            {
                result &= (password.IndexOfAny(upper.ToCharArray()) >= 0);
            }
            if (!result)
            {
                MessageBox.Show("Falta a Inserção de Caracters Maisculos");
                return result;
            }
            //Check to for a digit in password if digit is required
            if (Convert.ToBoolean(rules & PasswordRules.Digit))
            {
                result &= (password.IndexOfAny(digits.ToCharArray()) >= 0);
            }
            if (!result)
            {
                MessageBox.Show("Falta a Inserção de numeros");
                return result;
            }
            //Check to make sure special character is included if required
            if (Convert.ToBoolean(rules & PasswordRules.SpecialChar))
            {
                result &= (password.Trim(allChars.ToCharArray()).Length > 0);
            }
            if (!result)
            {
                MessageBox.Show("Falta a Inserção de characteres especiais");
                return result;
            }
            return result;
        }

        /// <summary>
        /// Metodo global de validação para validar o imput do user de qualquer sitio do programa
        /// </summary>
        /// <param name="input">string introduzida pelo user</param>
        /// <param name="charMax">quantidade max de caracteres permitidos pela BD</param>
        /// <param name="charMin">quantidade min de caracteres permitidos pela BD</param>
        /// <param name="inputName">nome do campo que esta a receber input</param>
        /// <param name="letra">verifica se o campo requer letras ou numeros</param>
        /// <param name="obrigatorio">verifica se o campo é obrigatorio ou nao</param>
        /// <returns></returns>
        static public Boolean Valida(string input, int charMax, int charMin, string inputName, Boolean letra, Boolean obrigatorio)
        {
            //If para verificar se o campo esta vazio ou nao
            if (input == "" && obrigatorio)
            {
                MessageBox.Show(
                    "O campo " + inputName + " tem que ser preenchido",
                    "Campo obrigatório",                // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            //if para verificar se o input excede o max de chars permitidos
            else if (input.Length > charMax)
            {

                MessageBox.Show(
                    "O campo " + inputName + " excede o valor máximo de carateres: " + charMax + ".",
                    "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            //if para verificar se o input excede o min de chars permitidos
            else if (input.Length < charMin && input != "")
            {
                MessageBox.Show(
                    "O campo " + inputName + " não atinge o requisito minimo de caracteres: " + charMin + ".",
                    "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                    MessageBoxButtons.OK,               // botões
                    MessageBoxIcon.Warning              // Icon
                );

                return false;       // Termina a validação e retorna à Form
            }
            //if para verificar se é necessario que o input tenha apenas numeros
            else if (!letra && input != "")
            {
                int Num;
                string pontos = ".";

                bool isNum = int.TryParse(input, out Num);  //verifica se a string contem ints caso tenha o bool fica a true

                if (!isNum && !input.Contains(pontos))
                {
                    MessageBox.Show(
                        "O campo " + inputName + " so pode conter numeros.",
                        "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                        MessageBoxButtons.OK,               // botões
                        MessageBoxIcon.Warning              // Icon
                    );
                    return false;       // Termina a validação e retorna à Form
                }
            }
            //if para verificar se é necessario que o input tenha apenas numeros
            else if (letra && input != "")
            {
                int Num;

                bool isNum = int.TryParse(input, out Num); //verifica se a string contem ints caso tenha o bool fica a true

                //caso o isNum esteja a null devolve um erro 
                if (isNum)
                {
                    MessageBox.Show(
                       "O campo " + inputName + " so pode conter letras.",
                       "Dados Inválidos",                  // Título manual ou Constantes: TITLE_
                       MessageBoxButtons.OK,               // botões
                       MessageBoxIcon.Warning              // Icon
                    );
                    return false;       // Termina a validação e retorna à Form
                }
            }
            return true;
        }

        /// <summary>
        /// Metodo que verifica o input do user, para impedir SQLInjection
        /// </summary>
        /// <param name="userInput">input do user</param>
        /// <returns></returns>
        public static Boolean CheckForSQLInjection(string userInput)
        {
            bool isSQLInjection = false;    //boolean que determina se é SQLInjection ou não 

            //array de string com todos comandos usados para SQLInjection
            string[] sqlCheckList = { "--",";--",";","/*","*/","@@","@","char","nchar","varchar",
                                       "nvarchar","alter","begin","cast","create","cursor","declare",
                                       "delete","drop","end","exec","execute","fetch","insert","kill",
                                        "select","sys","sysobjects","syscolumns","table","update"};

            string CheckString = userInput.Replace("'", "''");  //checkString toma valor do Input do user
                                                                //.Replace que substitui o valor antigo por um novo,

            //for para correr o array de comandos de SQL e verificar se algum deles está no imput do user
            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                //se o input conter algum tipo de comando no array ele torna o bool isSQLInjection em true
                if ((CheckString.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    isSQLInjection = true;
                }
            }
            return isSQLInjection;  //devolve o bool que confirma se é SQLInjection ou nao
        }
    }
    #endregion

   
}

