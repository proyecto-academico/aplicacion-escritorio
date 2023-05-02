<<<<<<< HEAD:PRUEAS/PRUEAS/Login.cs
using System.Drawing.Text;
=======
using Microsoft.Data.SqlClient;
>>>>>>> 258953a3ee843b073dca3450ba08b5b1a7223870:PRUEAS/PRUEAS/Form1.cs
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
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); // convierte la contraseña en bytes

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
<<<<<<< HEAD:PRUEAS/PRUEAS/Login.cs
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
=======
        static void dataaseconn ()
        {
            //https://www.guru99.com/c-sharp-access-database.html#:~:text=SqlCommand%20in%20C%23%20allow%20the,best%20for%20the%20different%20commands.
            SqlCommand Pato;
            SqlDataReader Read;
            SqlDataAdapter Write = new SqlDataAdapter();
            SqlConnection cnn;
            //datasource = pc, inital catalog = db user ID, password
            string connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //WRITE
>>>>>>> 258953a3ee843b073dca3450ba08b5b1a7223870:PRUEAS/PRUEAS/Form1.cs

            string quer = "INSERT";
            Write.InsertCommand = new SqlCommand(quer,cnn);
            Write.InsertCommand.ExecuteNonQuery();
            
            //READ
            string syntax = "SELECT * FROM TABLE";
            Pato = new SqlCommand(syntax, cnn);
            Read = Pato.ExecuteReader();
            while(Read.Read())
            {
                Console.WriteLine("READER.GetValue(0)");
            }
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }

   
    }
}
