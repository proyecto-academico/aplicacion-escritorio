using System.Drawing.Text;
using System.Text;

namespace PRUEAS
{
    public partial class Login : Form
    {
        string data;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contasenia = "DamoSeLaCome123";
            string texto = textBox1.Text;
            string toma = DecryptPassword(texto);
            if (contasenia == toma)
            {
                Menu();
                this.Hide();

                // jajaj hace esto jaja 
            }

        }

        #region Methods

        public void Menu()
        {
            BaseDeDatos baseDeDatos = new BaseDeDatos();
            baseDeDatos.Show();

        }

        static string EncryptPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); // convierte la contrase�a en bytes

            string hexString = BitConverter.ToString(passwordBytes).Replace("-", ""); // convierte los bytes a un string en formato hexadecimal

            return hexString;
        }

        static string DecryptPassword(string encryptedPassword)
        {
            byte[] passwordBytes = new byte[encryptedPassword.Length / 2];

            for (int i = 0; i < passwordBytes.Length; i++)
            {
                passwordBytes[i] = Convert.ToByte(encryptedPassword.Substring(i * 2, 2), 16); // convierte los caracteres hexadecimales a bytes
            }

            string password = Encoding.UTF8.GetString(passwordBytes); // convierte los bytes a una cadena de texto

            return password;
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


   
    }
}
