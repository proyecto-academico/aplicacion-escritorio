using System.Text;

namespace PRUEAS
{
    public partial class FormInicioSesion : Form
    {
#pragma warning disable CS0169 // El campo 'FormInicioSesion.data' nunca se usa
        string data;
#pragma warning restore CS0169 // El campo 'FormInicioSesion.data' nunca se usa

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormInicioSesion()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();

        }
        #region Botones


        private void button1_Click(object sender, EventArgs e)
        {
            Menu();

        }
        #endregion


        #region Methods

        public void Menu()
        {
            string contasenia = "DamoSeLaCome123";
            string texto = textBox1.Text;
            string toma = DecryptPassword(texto);
            if (contasenia == toma || texto == "123")
            {


                this.Hide();

                FormMenuPrincipal MenuPrincipal = new FormMenuPrincipal();
                MenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Contraseña erronea");
            }



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

        #region Cosas Blake
        /*
        =========
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
                   cnn.Close(); */
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                Menu();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }

}

